using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    public interface ILoginPresenter
    {
        /// <summary>
        /// вставить банковскую карту в банкомат
        /// </summary>
        event EventHandler InsertCard;
        /// <summary>
        /// пополнить карту наличкой
        /// </summary>
        event EventHandler AddCash;
    }
    class LoginPresenter : ILoginPresenter
    {
        ILoginView _loginView;

        public event EventHandler InsertCard;
        public event EventHandler AddCash;

        public LoginPresenter(ILoginView loginView)
        {
            if(loginView != null)
            {
                _loginView = loginView;
                _loginView.AddCash += _loginView_AddCash;
                _loginView.InsertingCard += _loginView_InsertingCard;
                _loginView.GetCard += _loginView_GetCard;
            }
        }

        private void _loginView_GetCard(object sender, EventArgs e)
        {
            //TODO: тут выдать карту в отдельной форме(эмуляция получения по ФИО)
            throw new NotImplementedException();
        }

        private void _loginView_InsertingCard(object sender, EventArgs e)
        {
            InsertCard?.Invoke(this, null);
        }

        private void _loginView_AddCash(object sender, EventArgs e)
        {
            AddCash?.Invoke(this, null);
        }
    }
}
