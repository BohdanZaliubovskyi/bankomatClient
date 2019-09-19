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
    public interface IEnterCardNumberPresenter : IBaseControl
    {
        /// <summary>
        /// подтверждение отправки номера карты на сервер
        /// </summary>
        event EventHandler Confirm;        
    }
    public class EnterCardNumberPresenter : IEnterCardNumberPresenter
    {
        IEnterCardNumberView _enterCardNumberView;

        public event EventHandler Confirm;
        public event EventHandler ToStart;

        WaitForm _waitForm;

        /// <summary>
        /// экземпляр веб интерфейса
        /// </summary>
        BankomatServiceSoapClient _bankomatLocalService;

        public EnterCardNumberPresenter(IEnterCardNumberView enterCardNumberView)
        {
            if (enterCardNumberView != null)
            {
                _enterCardNumberView = enterCardNumberView;
                _enterCardNumberView.CheckCardNumber += _enterCardNumberView_CheckCardNumber;
                _enterCardNumberView.ConfirmNumber += _enterCardNumberView_ConfirmNumber;
                _enterCardNumberView.PressDigit += _enterCardNumberView_PressDigit;
                _enterCardNumberView.ToStart += _enterCardNumberView_ToStart;
                _enterCardNumberView.PressDel += _enterCardNumberView_PressDel;
            }
            _bankomatLocalService = new BankomatServiceSoapClient();
        }

        private void _enterCardNumberView_PressDel(object sender, EventArgs e)
        {
            if (_enterCardNumberView != null)
                _enterCardNumberView.DelDigit();
        }

        private void _enterCardNumberView_ToStart(object sender, EventArgs e)
        {
            ToStart?.Invoke(this, e);
        }

        private void _enterCardNumberView_PressDigit(object sender, EventArgs e)
        {
            DigitEventArgs dea = e as DigitEventArgs;
            if (dea != null)
                _enterCardNumberView.AddDigit(dea.Digit);
        }

        private void _enterCardNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            CardNumberEventArgs card = e as CardNumberEventArgs;
            if (card != null)
            {
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += Bw_DoWork;
                bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                    bw.RunWorkerAsync(card.CardNumber);
               
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером");
            else if (e.Result == null)
                SendMessage("Такого номера карты не существует");
            else
            {
                Confirm?.Invoke(this, new CardEventArgs(e.Result as Cards));
            }
            _waitForm.Close();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {            
            Cards card = _bankomatLocalService.CheckCardNumber(e.Argument.ToString());
            e.Result = card;
        }

        private void _enterCardNumberView_CheckCardNumber(object sender, EventArgs e)
        {
            if (_enterCardNumberView == null)
                return;

            CardNumberEventArgs card = e as CardNumberEventArgs;
            if (card != null)
            {
                if (CheckCardNumber(card.CardNumber))
                    _enterCardNumberView.ConfirmSending(card.CardNumber);
                else
                    _enterCardNumberView.SendMessage("Вы ввели неправильный номер банковской карты");
            }
        }

        /// <summary>
        /// проверка номера карты на правильность записи
        /// </summary>
        /// <param name="number">проверяемый номер карты</param>
        /// <returns>true=все верно false=неправильная запись</returns>
        bool CheckCardNumber(string number)
        {
            if (number == "")
                return false;

            if (!Regex.IsMatch(number, "\\d{16}"))
                return false;

            return true;
        }

        public void SendMessage(string message)
        {
            if (_enterCardNumberView != null)
                _enterCardNumberView.SendMessage(message);
        }
    }
}
