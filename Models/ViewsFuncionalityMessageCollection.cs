using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models
{
    public enum MyPresenters
    {
        //BlockCardPresenter = 1,
        CardOperationsPresenterChangePin = 1,
        CardOperationsPresenterBlockCard,
        ChangePinPresenter,
        EnterCardNumberPresenter,
        EnterKeyNumberPresenter,
        EnterMoneySumNumberPresenter,
        EnterPinNumberPresenter,
        EnterTelephoneNumberPresenter,
        //GetMoneyNumberPresenter,
        PaymentsPresenterOtherCard,
        PaymentsPresenterFillMobile,
        PaymentsPresenterCharity,
        PersonalAreaPresenterCardOperations,
        PersonalAreaPresenterCardPayments,
        PersonalAreaPresenterFillCard,
        PersonalAreaPresenterGetMoney,
        PersonalArea,
        CharityPresenter,
    }
    public static class ViewsFuncionalityMessageCollection
    {
        static Dictionary<MyPresenters, Dictionary<BaseViewsFunctionality, string>> _functionalityMessageCollection;

        static ViewsFuncionalityMessageCollection()
        {
            _functionalityMessageCollection = new Dictionary<MyPresenters, Dictionary<BaseViewsFunctionality, string>>();

            Dictionary<BaseViewsFunctionality, string> _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пополнение номера мобильного телефона.");
            _curInnerDict.Add(BaseViewsFunctionality.StartPageBaseView, "Авторизация по мобильному телефону.");
            _functionalityMessageCollection.Add(MyPresenters.EnterTelephoneNumberPresenter, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Внесение купюр в банкомат.");
            //_curInnerDict.Add(BaseViewsFunctionality.StartPageBaseView, "Внесение купюр в банкомат.");
            _functionalityMessageCollection.Add(MyPresenters.EnterMoneySumNumberPresenter, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.StartPageBaseView, "Верификация по номеру телефона.");
            _functionalityMessageCollection.Add(MyPresenters.EnterKeyNumberPresenter, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пополнение другой карты.");
            //_curInnerDict.Add(BaseViewsFunctionality.StartPageBaseView, "Пополнение вашей карты.");
            _functionalityMessageCollection.Add(MyPresenters.EnterCardNumberPresenter, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пополнение другой карты.");
            _functionalityMessageCollection.Add(MyPresenters.PaymentsPresenterOtherCard, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пополнение номера телефона.");
            _functionalityMessageCollection.Add(MyPresenters.PaymentsPresenterFillMobile, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Благотворительность.");
            _functionalityMessageCollection.Add(MyPresenters.PaymentsPresenterCharity, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Операции с картой.");
            _functionalityMessageCollection.Add(MyPresenters.PersonalAreaPresenterCardOperations, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Платежи.");
            _functionalityMessageCollection.Add(MyPresenters.PersonalAreaPresenterCardPayments, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            //_curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пополнение карты.");
            _functionalityMessageCollection.Add(MyPresenters.PersonalAreaPresenterFillCard, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Снятие денег.");
            _functionalityMessageCollection.Add(MyPresenters.PersonalAreaPresenterGetMoney, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Смена пин-кода карты.");
            _functionalityMessageCollection.Add(MyPresenters.CardOperationsPresenterChangePin, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Блокировка карты.");
            _functionalityMessageCollection.Add(MyPresenters.CardOperationsPresenterBlockCard, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Ввод пин-кода для замены.");
            //_curInnerDict.Add(BaseViewsFunctionality.StartPageBaseView, "Ввод пин-кода.");
            _functionalityMessageCollection.Add(MyPresenters.EnterPinNumberPresenter, _curInnerDict);

            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Личный кабинет.");
            _functionalityMessageCollection.Add(MyPresenters.PersonalArea, _curInnerDict);
            
            _curInnerDict = new Dictionary<BaseViewsFunctionality, string>();
            _curInnerDict.Add(BaseViewsFunctionality.PersonalAreaBaseView, "Пожертвование на благотворительность.");
            _functionalityMessageCollection.Add(MyPresenters.CharityPresenter, _curInnerDict);
        }

        public static Dictionary<MyPresenters, Dictionary<BaseViewsFunctionality, string>> Items { get => _functionalityMessageCollection; }
    }
}
