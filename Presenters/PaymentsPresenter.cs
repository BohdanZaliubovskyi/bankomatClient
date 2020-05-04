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
    public interface IPaymentsPresenter : IPaymentsView
    {

    }
    public class PaymentsPresenter : BasePersonalAreaPresenter, IPaymentsPresenter
    {
        public event EventHandler ButtonCharityClick;
        public event EventHandler ButtonFillMobileClick;
        public event EventHandler ButtonSendToOtherCardClick;

        public PaymentsPresenter(BoolEventArgs bea, IPaymentsView paymentsView) : base (bea, paymentsView)
        {
            if(paymentsView != null)
            {
                (_basePersonalAreaView as IPaymentsView).ButtonCharityClick += PaymentsPresenter_ButtonCharityClick;
                (_basePersonalAreaView as IPaymentsView).ButtonFillMobileClick += PaymentsPresenter_ButtonFillMobileClick;
                (_basePersonalAreaView as IPaymentsView).ButtonSendToOtherCardClick += PaymentsPresenter_ButtonSendToOtherCardClick;
            }

            SetViewLabels("Платежи по карте", "Выберете требуемую операцию");
        }

        private void PaymentsPresenter_ButtonSendToOtherCardClick(object sender, EventArgs e)
        {
            ButtonSendToOtherCardClick?.Invoke(sender, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PaymentsPresenterOtherCard),CurrentCard, _baseViewsFunctionality));
        }

        private void PaymentsPresenter_ButtonFillMobileClick(object sender, EventArgs e)
        {
            ButtonFillMobileClick?.Invoke(sender, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PaymentsPresenterFillMobile), CurrentCard, _baseViewsFunctionality));
        }

        private void PaymentsPresenter_ButtonCharityClick(object sender, EventArgs e)
        {
            ButtonCharityClick?.Invoke(sender, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.PaymentsPresenterCharity), CurrentCard, _baseViewsFunctionality));
        }
    }
}
