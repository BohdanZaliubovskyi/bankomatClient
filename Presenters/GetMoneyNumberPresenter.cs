using BankomatClient.BankomatLocalService;
using BankomatClient.Models.MyEventArgs;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    public interface IGetMoneyNumberPresenter : IEnterNumberPresenter
    {

    }
    public class GetMoneyNumberPresenter : BaseEnterNumberPresenter, IGetMoneyNumberPresenter
    {
        readonly string _emptyNumber = "EMPTY_NUMBER";
        string _toCardNumber;
        CharityForm _charityForm;

        void Initialize()
        {
            SetViewLabels("Ввод суммы", "Введите желаемую сумму для списания");
            _toCardNumber = _emptyNumber;
            _charityForm = CharityForm.None;
        }
        public GetMoneyNumberPresenter(BoolEventArgs bea,IEnterCardNumberView enterCardNumberView) : base(bea, enterCardNumberView)
        {
            Initialize();            
        }
        public GetMoneyNumberPresenter(SendingMoneyEventArgs sea, IEnterCardNumberView enterCardNumberView) : base(new BoolEventArgs(sea.Argument,sea.Card, sea.BaseViewsFunctionality), enterCardNumberView)
        {
            Initialize();
            _toCardNumber = sea.ToCardNumber;
        }
        public GetMoneyNumberPresenter(CharityEventArgs cea, IEnterCardNumberView enterCardNumberView) : base(new BoolEventArgs(cea.Argument, cea.Card, cea.BaseViewsFunctionality), enterCardNumberView)
        {
            Initialize();
            _charityForm = cea.CharityForm;
        }

        public override event EventHandler Confirm;

        protected override bool CheckNumber(string number)
        {
            double sum;
            try
            {
                sum = Convert.ToDouble(number);
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            double sum = Convert.ToDouble(e.Argument);

            string message = null;
            if (_toCardNumber == _emptyNumber)
                message = _bankomatLocalService.GetMoneyFromCard(CurrentCard.CardNumber, CurrentCard.Pin, sum);
            else
                message = _bankomatLocalService.SendMoneyToOtherCard(CurrentCard.CardNumber, CurrentCard.Pin, sum, _toCardNumber);

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
                if(_charityForm == CharityForm.None)
                    Confirm?.Invoke(this, new BoolEventArgs(e.Result.ToString(), CurrentCard, _baseViewsFunctionality));
                else
                    Confirm?.Invoke(this, new CharityEventArgs(new BoolEventArgs( e.Result.ToString(), CurrentCard, _baseViewsFunctionality), _charityForm));
            }
            _waitForm.Close();
        }

        protected override void _enterNumberView_CheckNumber(object sender, EventArgs e)
        {
            if (_basePersonalAreaView == null)
                return;

            NumberEventArgs sum = e as NumberEventArgs;
            if (sum != null)
            {
                if (CheckNumber(sum.Number))
                    (_basePersonalAreaView as IEnterCardNumberView).ConfirmSending(sum.Number);
                else
                    SendMessage("Вы ввели неправильную сумму для снятия");
            }
        }

        protected override void _enterNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            NumberEventArgs sum = e as NumberEventArgs;
            if (sum != null)
            {
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(sum.Number);
            }
        }
    }
}
