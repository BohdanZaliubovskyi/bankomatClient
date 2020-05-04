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
    public interface ICardOperationsPresenter : ICardOperationView
    {

    }
    public class CardOperationsPresenter : BasePersonalAreaPresenter, ICardOperationsPresenter
    {
        public event EventHandler ChangePinClick;
        public event EventHandler BlockCardClick;

        public CardOperationsPresenter(BoolEventArgs bea, ICardOperationView cardOperationView) : base(bea, cardOperationView)
        {
            if (cardOperationView != null)
            {
                (_basePersonalAreaView as ICardOperationView).BlockCardClick += _cardOperationView_BlockCardClick;
                (_basePersonalAreaView as ICardOperationView).ChangePinClick += _cardOperationView_ChangePinClick;
            }

            SetViewLabels("Операции с картой", "Выберете требуемую операцию");
        }

        private void _cardOperationView_ChangePinClick(object sender, EventArgs e)
        {
            ChangePinClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.CardOperationsPresenterChangePin),CurrentCard, _baseViewsFunctionality));
        }

        private void _cardOperationView_BlockCardClick(object sender, EventArgs e)
        {
            BlockCardClick?.Invoke(this, new BoolEventArgs(GetMessageAboutCurrentPage(MyPresenters.CardOperationsPresenterBlockCard), CurrentCard, _baseViewsFunctionality));
        }
    }
}
