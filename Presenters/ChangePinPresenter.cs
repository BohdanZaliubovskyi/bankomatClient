using BankomatClient.BankomatLocalService;
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
    public interface IChangePinPresenter : IEnterNumberPresenter
    {

    }
    public class ChangePinPresenter : BaseEnterNumberPresenter, IChangePinPresenter
    {
        public ChangePinPresenter(BoolEventArgs bea,IEnterCardNumberView enterCardNumberView) : base(bea, enterCardNumberView)
        {
            SetViewLabels("Смена пин-кода карты", "Введите новый пин-код:");
        }

        public override event EventHandler Confirm;

        protected override bool CheckNumber(string number)
        {
            if (number == "")
                return false;

            if (!Regex.IsMatch(number, "\\d{4}"))
                return false;

            return true;
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            long pin = Convert.ToInt64(e.Argument);

            string message = _bankomatLocalService.ChangeCardPin(CurrentCard.CardNumber, CurrentCard.Pin, pin);

            if (message != null)
            {
                e.Result = message;
            }
            else
                e.Result = null;
        }

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером.");
            else if (e.Result == null)
                SendMessage("Такого номера карты не существует.");
            else
            {
                Confirm?.Invoke(this, new BoolEventArgs(e.Result.ToString(), CurrentCard, _baseViewsFunctionality));
            }
            _waitForm.Close();
        }

        protected override void _enterNumberView_CheckNumber(object sender, EventArgs e)
        {
            if (_basePersonalAreaView == null)
                return;

            NumberEventArgs pin = e as NumberEventArgs;
            if (pin != null)
            {
                if (CheckNumber(pin.Number))
                    (_basePersonalAreaView as IEnterCardNumberView).ConfirmSending(pin.Number);
                else
                    SendMessage("Вы ввели неправильный пин.");
            }
        }

        protected override void _enterNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            NumberEventArgs pin = e as NumberEventArgs;
            if (pin != null)
            {
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(pin.Number);
            }
        }
    }
}
