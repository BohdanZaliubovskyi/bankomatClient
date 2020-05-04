using BankomatClient.BankomatLocalService;
using BankomatClient.Models;
using BankomatClient.Models.MyEventArgs;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    public interface IEnterTelephoneNumberPresenter : IEnterNumberPresenter
    {

    }
    public class EnterTelephoneNumberPresenter : BaseEnterNumberPresenter, IEnterTelephoneNumberPresenter
    {
        public override event EventHandler Confirm;
        public EnterTelephoneNumberPresenter(BoolEventArgs bea, IEnterCardNumberView enterTelephoneNumberView) : base(bea, enterTelephoneNumberView)
        {
             SetViewLabels("Номер телефона", "Введите номер телефона, 10 цифр");
        }

        protected override void _enterNumberView_CheckNumber(object sender, EventArgs e)
        {
            if (_basePersonalAreaView == null)
                return;

            NumberEventArgs card = e as NumberEventArgs;
            if (card != null)
            {
                if (CheckNumber(card.Number))
                    (_basePersonalAreaView as IEnterCardNumberView).ConfirmSending(card.Number);
                else
                    SendMessage("Вы ввели неправильный номер телефона");
            }
        }

        protected override void _enterNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            // здесь номер телефона
            NumberEventArgs number = e as NumberEventArgs;
            if (number != null)
            {
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(new Phones() { ClientId = CurrentCard.ClientId, Number = number.Number});
            }
        }
        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером");
            else if (e.Result == null)
                SendMessage("Такого номера телефона не существует");
            else
            {
                Confirm?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.EnterTelephoneNumberPresenter), CurrentCard, _baseViewsFunctionality));
            }
            _waitForm.Close();
        }
         

        protected override bool CheckNumber(string number)
        {
            if (!Regex.IsMatch(number, "\\d{10}"))
                return false;

            try
            {
                long numb = Convert.ToInt64(number);
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Phones ph = e.Argument as Phones;
            if (ph != null)
            {
                // проверить на валидность полученный номер
                if (CheckNumber(ph.Number))
                {
                    bool isValidKey = _bankomatLocalService.SetPhoneNumber(ph.Number, ph.ClientId);
                    e.Result = isValidKey;
                }
                else
                    e.Result = null;
            }
            else
                e.Result = null;
        }

    }
}
