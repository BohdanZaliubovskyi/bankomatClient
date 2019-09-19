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
    public class MainPresenter
    {
        IMainForm _mainForm;
        /// <summary>
        /// менеджер первой страницы
        /// </summary>
        ILoginPresenter _loginPresenter = null;
        /// <summary>
        /// представление первой страницы
        /// </summary>
        ILoginView _loginView = null;

        /// <summary>
        /// менеджер страницы ввода номера карты
        /// </summary>
        IEnterCardNumberPresenter enterCardNumberPresenter;

        public MainPresenter(IMainForm mainForm)
        {
            if (mainForm != null)
            {
                _mainForm = mainForm;
                _mainForm.FormLoaded += _mainForm_FormLoaded;
            }            
        }

        private void _mainForm_FormLoaded(object sender, EventArgs e)
        {
            _mainForm.AddView(LoginView as LoginView);
        }

        #region LoginView        
        private ILoginView LoginView
        {
            get
            {
                if (_loginPresenter == null)
                {
                    _loginView = new LoginView();
                    _loginPresenter = new LoginPresenter(_loginView);
                    _loginPresenter.AddCash += _loginView_AddCash;
                    _loginPresenter.InsertCard += _loginView_InsertingCard;
                }
                return _loginView;
            }
        }
        private void _loginView_InsertingCard(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _loginView_AddCash(object sender, EventArgs e)
        {
            IEnterCardNumberView enterCardNumberView = new EnterCardNumberView();
            enterCardNumberPresenter = new EnterCardNumberPresenter(enterCardNumberView);
            enterCardNumberPresenter.Confirm += EnterCardNumberPresenter_Confirm;
            enterCardNumberPresenter.ToStart += EnterCardNumberPresenter_ToStart;

            _mainForm.AddView(enterCardNumberView as EnterCardNumberView);
        }
        #endregion

        #region CardNumberPresenter
        private void EnterCardNumberPresenter_ToStart(object sender, EventArgs e)
        {
            _mainForm.AddView(LoginView as LoginView);
        }

        private void EnterCardNumberPresenter_Confirm(object sender, EventArgs e)
        {    
            CardEventArgs cnea = e as CardEventArgs;
            if(cnea != null)
            {                
                //TODO: переход на страницу верификации по смс                
            }
        }       
        #endregion
    }
}
