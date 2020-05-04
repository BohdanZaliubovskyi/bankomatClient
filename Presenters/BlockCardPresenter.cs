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
    public interface IBlockCardPresenter : IBasePersonalAreaView, IConfirmPresenter
    {

    }
    public class BlockCardPresenter : BaseBackgroundWorker, IBlockCardPresenter
    {
        public BlockCardPresenter(BoolEventArgs bea, IBlockCardView blockCardView) :base (bea, blockCardView)
        {
            if (blockCardView != null)
            {
                _basePersonalAreaView = blockCardView;
                (_basePersonalAreaView as IBlockCardView).BlockCardClick += _blockCardView_BlockCardClick;
            }

            SetViewLabels("Блокировка банковской карты", "Нажмите для блокировки");
        }

        public override event EventHandler Confirm;

        private void _blockCardView_BlockCardClick(object sender, EventArgs e)
        {
            SendMessage("Подождите, идет обработка данных...");

            _waitForm = new WaitForm();
            _waitForm.Show();
            _bw.RunWorkerAsync();
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string message = _bankomatLocalService.BlockCard(CurrentCard.CardNumber, CurrentCard.Pin);

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
    }
}
