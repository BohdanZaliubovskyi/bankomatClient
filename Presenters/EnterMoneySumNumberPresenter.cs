using BankomatClient.BankomatLocalService;
using BankomatClient.Models;
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
    public class EnterMoneySumNumberPresenter : BaseBackgroundWorker
    {
        readonly string _fillCard = "Пополнение карты";
        readonly string _insertBills = "Внесите купюры в банкомат";
        readonly string _insertBadBill = "Купюра плохого качества, внесите другую";
        readonly string _wrongSum = "Вы не внесли деньги";

        private double _currentSumForCard = 0;

        public override event EventHandler Confirm;

        public EnterMoneySumNumberPresenter(BoolEventArgs bea, IInsertMoneyView insertMoneyView) : base(bea, insertMoneyView)
        {
            if (_basePersonalAreaView != null)
            {                
                (_basePersonalAreaView as IInsertMoneyView).InsertBill += _insertMoneyView_InsertBill;
                (_basePersonalAreaView as IInsertMoneyView).PressButtonConfirm += _insertMoneyView_PressButtonConfirm;
                (_basePersonalAreaView as IInsertMoneyView).ChangeLabelResSum("");
            }

            SetViewLabels(_fillCard, _insertBills);
        }

        private void _insertMoneyView_PressButtonConfirm(object sender, EventArgs e)
        {
            if(_currentSumForCard == 0)
            {
                SetViewLabels(_fillCard, _wrongSum);
            }
            else
            {
                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(_currentSumForCard);
            }
        }

        private void _insertMoneyView_InsertBill(object sender, EventArgs e)
        {
            DigitEventArgs nea = e as DigitEventArgs;
            if(nea != null)
            {
                int bill = EmulateBadBill(nea.Digit);
                if(bill == 0)
                    SetViewLabels(_fillCard, _insertBadBill);
                else
                    SetViewLabels(_fillCard, _insertBills);

                _currentSumForCard += bill;
                (_basePersonalAreaView as IInsertMoneyView).ChangeLabelResSum($"На карту будет зачислено {GetSumWithoutPercent(_currentSumForCard)} грн.");
            }
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            double sum;
            try
            {
                sum = Convert.ToInt64(e.Argument);
            }
            catch
            {
                e.Result = null;
                return;
            }

            e.Result = _bankomatLocalService.PutMoneyOnTheCard(CurrentCard.CardNumber, GetSumWithoutPercent(sum));
            
        }

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером");
            else if (e.Result == null)
                SendMessage("Не удалось произвести зачисление средств на карту");
            else
            {
                string message = GetMessageAboutCurrentPage(MyPresenters.EnterMoneySumNumberPresenter);
                if ((bool)e.Result)
                    message = $"{message} Зачисление успешно.";
                else
                    message = $"{message} Зачисление не удалось.";
                Confirm?.Invoke(this, new BoolEventArgs(message, CurrentCard, _baseViewsFunctionality));
            }
            _waitForm.Close();
        }

        /// <summary>
        /// эмуляция внесения плохой купюры
        /// </summary>
        /// <param name="bill">номинал вносимой купюры</param>
        /// <returns>номинал купюры после проверки</returns>
        int EmulateBadBill(int bill)
        {
            int rnd = new Random().Next(1, 10);
            if (rnd == 1)
                bill = 0;

            return bill;
        }

        /// <summary>
        /// калькуляция суммы без процента банка
        /// </summary>
        /// <param name="summ">исходная сумма</param>
        /// <returns>итоговая сумма</returns>
        double GetSumWithoutPercent(double summ)
        {
            double rez = 0;
            if(summ > 0)
            {
                rez = _currentSumForCard - _currentSumForCard * 0.005;
            }

            return rez;
        }
    }
}
