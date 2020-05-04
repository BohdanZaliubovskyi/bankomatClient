using BankomatClient.BankomatLocalService;
using BankomatClient.Models;
using BankomatClient.Models.MyEventArgs;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    public interface IPersonalAreaPresenter : IBaseControl
    {
        event EventHandler CardOperationsClick;
        event EventHandler CardPaymentsClick;
        event EventHandler FillCardClick;
        event EventHandler GetMoneyClick;
    }
    class PersonalAreaPresenter : BasePersonalAreaPresenter, IPersonalAreaPresenter
    {
        public event EventHandler CardOperationsClick;
        public event EventHandler CardPaymentsClick;
        public event EventHandler FillCardClick;
        public event EventHandler GetMoneyClick;

        public PersonalAreaPresenter(BoolEventArgs bea, IPersonalAreaView personalAreaView) : base(bea, personalAreaView)
        {
            if (personalAreaView != null)
            {
                (_basePersonalAreaView as IPersonalAreaView).CardOperationsClick += _personalAreaView_CardOperationsClick;
                (_basePersonalAreaView as IPersonalAreaView).CardPaymentsClick += _personalAreaView_CardPaymentsClick;
                (_basePersonalAreaView as IPersonalAreaView).FillCardClick += _personalAreaView_FillCardClick;
                (_basePersonalAreaView as IPersonalAreaView).GetMoneyClick += _personalAreaView_GetMoneyClick;
            }

            SetViewLabels("Личный кабинет", "Выберете следующее действие");
        }

        private void _personalAreaView_GetMoneyClick(object sender, EventArgs e)
        {
            GetMoneyClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PersonalArea), CurrentCard, _baseViewsFunctionality));
        }

        private void _personalAreaView_FillCardClick(object sender, EventArgs e)
        {
            FillCardClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PersonalArea), CurrentCard, _baseViewsFunctionality));
        }

        private void _personalAreaView_CardPaymentsClick(object sender, EventArgs e)
        {
            CardPaymentsClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PersonalArea), CurrentCard, _baseViewsFunctionality));
        }

        private void _personalAreaView_CardOperationsClick(object sender, EventArgs e)
        {
            CardOperationsClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PersonalArea), CurrentCard, _baseViewsFunctionality));
        }

    }
}
