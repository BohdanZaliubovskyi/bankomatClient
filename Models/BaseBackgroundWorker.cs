using BankomatClient.BankomatLocalService;
using BankomatClient.Models.MyEventArgs;
using BankomatClient.Presenters;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models
{
    public interface IConfirmPresenter
    {
        event EventHandler Confirm;
    }
    /// <summary>
    /// базовый класс, пердоставляющий функционал обработки данных в фоновом потоке и некоторые общие поля
    /// </summary>
    public abstract class BaseBackgroundWorker : BasePersonalAreaPresenter, IConfirmPresenter
    {       
        /// <summary>
        /// форма ожидания
        /// </summary>
        protected WaitForm _waitForm;

        protected BackgroundWorker _bw;

        /// <summary>
        /// экземпляр веб интерфейса
        /// </summary>
        protected BankomatServiceSoapClient _bankomatLocalService;

        public abstract event EventHandler Confirm;

        public BaseBackgroundWorker(BoolEventArgs bea, IBasePersonalAreaView basePersonalAreaView) : base(bea, basePersonalAreaView)
        {
            _bw = new BackgroundWorker();
            _bw.DoWork += _bw_DoWork;
            _bw.RunWorkerCompleted += _bw_RunWorkerCompleted;
            _bankomatLocalService = new BankomatServiceSoapClient();
        }

        /// <summary>
        /// окончание обработки операций в другом потоке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected abstract void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e);
        /// <summary>
        /// выполнение важных операций в другом потоке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected abstract void _bw_DoWork(object sender, DoWorkEventArgs e);
    }
}
