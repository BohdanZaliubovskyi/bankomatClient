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
    class EnterPinNumberPresenter : BaseEnterNumberPresenter
    {
        public EnterPinNumberPresenter(BoolEventArgs bea, IEnterCardNumberView enterCardNumberView) : base(bea, enterCardNumberView)
        {
            SetViewLabels("Подтверждение владельца карты", "Введите ПИН-код");
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
            long pin = 0;
            try
            {
                pin = Convert.ToInt64(e.Argument);
            }
            catch
            {
                e.Result = null;
            }

            if (pin != 0)
            {
                BaseCard bc = _bankomatLocalService.CheckCardPin(CurrentCard.CardNumber, pin);
                if (bc != null)
                {
                    Cards card = (Cards)bc;
                    e.Result = card;
                }
                else
                    e.Result = null;
            }
        }

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером.");
            else if (e.Result == null)
                SendMessage("Пин-код не верен");
            else
            {
                Cards cr = e.Result as Cards;
                if (cr.IsBlocked)
                    SendMessage("Карта заблокирована. Любые операции с ней запрещены.");
                else
                    Confirm?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.EnterPinNumberPresenter), cr, BaseViewsFunctionality.PersonalAreaBaseView));
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
                    SendMessage("Вы ввели неправильный ПИН-код");
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
