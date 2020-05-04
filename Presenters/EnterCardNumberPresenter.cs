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
    public interface IEnterCardNumberPresenter : IEnterNumberPresenter
    {

    }
    public class EnterCardNumberPresenter : BaseEnterNumberPresenter, IEnterCardNumberPresenter
    {
        public EnterCardNumberPresenter(BoolEventArgs bea, IEnterCardNumberView enterCardNumberView) :base(bea, enterCardNumberView)
        {
            SetViewLabels("Пополнение карты", "Введите номер карты");
        }

        protected override void _enterNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            NumberEventArgs card = e as NumberEventArgs;
            if (card != null)
            {              
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(card.Number);               
            }
        }

        public override event EventHandler Confirm;

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером.");
            else if (e.Result == null)
                SendMessage("Такого номера карты не существует.");
            else
            {
                Cards cr = e.Result as Cards;
                if (cr.IsBlocked)
                    SendMessage("Карта заблокирована. Любые операции с ней запрещены.");
                else
                {
                    switch (_baseViewsFunctionality)
                    {
                        case BaseViewsFunctionality.StartPageBaseView:
                            Confirm?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.EnterCardNumberPresenter), cr, _baseViewsFunctionality));
                            break;
                        case BaseViewsFunctionality.PersonalAreaBaseView:
                            Confirm?.Invoke(this, new SendingMoneyEventArgs(cr.CardNumber, GetMessageAboutCurrentPage(MyPresenters.EnterCardNumberPresenter), CurrentCard, _baseViewsFunctionality));
                            break;
                    }
                }
            }
            _waitForm.Close();
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BaseCard bc = _bankomatLocalService.CheckCardNumber(e.Argument.ToString());
            if (bc != null)
            {
                Cards card = (Cards)bc;
                e.Result = card;
            }
            else
                e.Result = null;
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
                    SendMessage("Вы ввели неправильный номер банковской карты");
            }
        }

        /// <summary>
        /// проверка номера карты на правильность записи
        /// </summary>
        /// <param name="number">проверяемый номер карты</param>
        /// <returns>true=все верно false=неправильная запись</returns>
        protected override bool CheckNumber(string number)
        {
            if (number == "")
                return false;

            if (!Regex.IsMatch(number, "\\d{16}"))
                return false;

            return true;
        }
    }
}
