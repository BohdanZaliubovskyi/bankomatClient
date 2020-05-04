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
using System.Threading;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    class EnterKeyNumberPresenter : BaseEnterNumberPresenter
    {
        /// <summary>
        /// номер телефона с которого звонит банк
        /// </summary>
        string _bankPhoneNumber;
        /// <summary>
        /// хранение ключа для идентификации клиента
        /// </summary>
        long _phoneKey = 0;
        public EnterKeyNumberPresenter(BoolEventArgs bea, IEnterCardNumberView enterTelephoneNumberView) : base(bea, enterTelephoneNumberView)
        {
            SetViewLabels("Проверка телефона", "Введите последние четыре цифры телефона, с которого вам поступил звонок.");
                
            // звонок на мобильный
            _bankPhoneNumber = _bankomatLocalService.GetBankPhoneNumber(CurrentCard.ClientId);
            if (_bankPhoneNumber != "")
            {
                StartPhoneCall(null);
            }
        }

        /// <summary>
        /// эмуляция телефонного звонка из банка
        /// </summary>
        /// <param name="state"></param>
        void StartPhoneCall(object state)
        {
            MobilePhoneForm mpf = new MobilePhoneForm(_bankPhoneNumber);
            mpf.Show();
        }

        public override event EventHandler Confirm;

        protected override bool CheckNumber(string number)
        {
            if (number == "")
                return false;

            if (!Regex.IsMatch(number, "\\d{4}"))
                return false;

            try
            {
                _phoneKey = Convert.ToInt64(number);
            }
            catch
            {
                _phoneKey = 0;
                return false;
            }

            return true;
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            NumberEventArgs ph = e.Argument as NumberEventArgs;
            if (ph != null)
            {
                // проверить на валидность полученный ключ
                if (CheckNumber(ph.Number))
                {
                    bool isValidKey = _bankomatLocalService.CheckPhoneKey(CurrentCard.ClientId, _phoneKey);
                    e.Result = isValidKey;
                }
                else
                    e.Result = null;
            }
            else
                e.Result = null;
        }

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером");
            else if (e.Result == null)
                SendMessage("Вы указали некорректный ключ");
            else
            {
                string message = GetMessageAboutCurrentPage(MyPresenters.EnterKeyNumberPresenter);
                if ((bool)e.Result)
                    message = $"{message} Верификация пройдена.";
                else
                    message = $"{message} Верификация не пройдена.";
                Confirm?.Invoke(this, new BoolEventArgs(message, CurrentCard, _baseViewsFunctionality));
            }
            _waitForm.Close();
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
                    SendMessage("Вы ввели неправильный проверочный ключ");
            }
        }

        protected override void _enterNumberView_ConfirmNumber(object sender, EventArgs e)
        {
            // здесь номер введенного ключа
            NumberEventArgs number = e as NumberEventArgs;
            if (number != null)
            {
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(new NumberEventArgs(number.Number));
            }
        }
    }
}
