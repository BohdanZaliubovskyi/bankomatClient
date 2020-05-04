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
        IEnterNumberPresenter _enterCardNumberPresenter;
        /// <summary>
        /// менеджер главной страницы личного кабинета
        /// </summary>
        IPersonalAreaPresenter _personalAreaPresenter;
        BankomatServiceSoapClient _bankomatLocalService;

        Clients _currentClient;

        public MainPresenter(IMainForm mainForm)
        {
            if (mainForm != null)
            {
                _mainForm = mainForm;
                _mainForm.FormLoaded += _mainForm_FormLoaded;
            }

            // эмуляция единственного пользователя
            _bankomatLocalService = new BankomatServiceSoapClient();
            try
            {
                _currentClient = _bankomatLocalService.GetClientById(1);
            }
            catch { }
        }

        private void _mainForm_FormLoaded(object sender, EventArgs e)
        {
            _mainForm.AddView(LoginView as LoginView);
        }

        /// <summary>
        /// установка базовых событий для представления
        /// </summary>
        /// <param name="item">интерфейс представления</param>
        void SetPersonalAreaEvents(IBasePersonalAreaView item)
        {
            item.ToStart += Presenter_ToStart;
            item.ToPersonalArea += Presenter_ToPersonalArea;
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
                    _loginPresenter.GetCard += _loginPresenter_GetCard;
                }
                return _loginView;
            }
        }

        private void _loginPresenter_GetCard(object sender, EventArgs e)
        {
            IGiveOutCardView giveOutCardView = new GiveOutCardView();
            IGiveOutCardPresenter giveOutCardPresenter = new GiveOutCardPresenter(new BoolEventArgs("", new Cards(), BaseViewsFunctionality.StartPageBaseView), _currentClient, giveOutCardView);
            giveOutCardPresenter.ToStart += Presenter_ToStart;
            giveOutCardPresenter.Confirm += ToResultMessageView_Confirm;

            _mainForm.AddView(giveOutCardView as GiveOutCardView);
        }

        private void _loginView_InsertingCard(object sender, EventArgs e)
        {
            if (_currentClient != null)
            {
                List<Cards> cardsL = _bankomatLocalService.GetCardsByClientId(_currentClient.Id).ToList().Select(c => c as Cards).ToList();
                IWalletForm wfv = new WalletFormView(_currentClient, cardsL);
                wfv.InsertCard += Wfv_InsertCard;
                wfv.ShowForm();
            }
        }

        #region InsertCardButton
        private void Wfv_InsertCard(object sender, EventArgs e)
        {
            NumberEventArgs nea = e as NumberEventArgs;
            if (nea != null)
            {
                IEnterCardNumberView enterCardNumberView = new EnterCardNumberView();
                _enterCardNumberPresenter = new EnterPinNumberPresenter(new BoolEventArgs("Вставка карты.", new Cards() { CardNumber = nea.Number}, BaseViewsFunctionality.StartPageBaseView)  , enterCardNumberView);
                _enterCardNumberPresenter.Confirm += _enterPinNumberPresenter_Confirm;
                _enterCardNumberPresenter.ToStart += Presenter_ToStart;

                _mainForm.AddView(enterCardNumberView as EnterCardNumberView);
            }
        }

        /// <summary>
        /// вход в личный кабинет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _enterPinNumberPresenter_Confirm(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if(bea != null)
            {
                IPersonalAreaView personalAreaView = new PersonalAreaView();
                _personalAreaPresenter = new PersonalAreaPresenter(bea, personalAreaView);
                _personalAreaPresenter.ToStart += Presenter_ToStart;
                _personalAreaPresenter.GetMoneyClick += _personalAreaPresenter_GetMoneyClick;
                _personalAreaPresenter.FillCardClick += _personalAreaPresenter_FillCardClick;
                _personalAreaPresenter.CardPaymentsClick += _personalAreaPresenter_CardPaymentsClick;
                _personalAreaPresenter.CardOperationsClick += _personalAreaPresenter_CardOperationsClick;

                _mainForm.AddView(personalAreaView as PersonalAreaView);
            }
        }

        /// <summary>
        /// кнопка в ЛК "операции с картой"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _personalAreaPresenter_CardOperationsClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                ICardOperationView cardOperationView = new CardOperationsView();
                ICardOperationsPresenter cardOperationsPresenter = new CardOperationsPresenter(bea, cardOperationView);
                //cardOperationsPresenter.ToStart += Presenter_ToStart;
                //cardOperationsPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(cardOperationsPresenter);
                cardOperationsPresenter.BlockCardClick += CardOperationsPresenter_BlockCardClick;
                cardOperationsPresenter.ChangePinClick += CardOperationsPresenter_ChangePinClick;
                
                _mainForm.AddView(cardOperationView as CardOperationsView);
            }
        }
        #region CardOperations button
        private void CardOperationsPresenter_ChangePinClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                IEnterCardNumberView enterCardNumberView = new EnterCardNumberView();
                IChangePinPresenter changePinPresenter = new ChangePinPresenter(bea, enterCardNumberView);
                //changePinPresenter.ToStart += Presenter_ToStart;
                //changePinPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(changePinPresenter);
                changePinPresenter.Confirm += ToResultMessageView_Confirm;

                _mainForm.AddView(enterCardNumberView as EnterCardNumberView);
            }
        }

        private void CardOperationsPresenter_BlockCardClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                IBlockCardView blockCardView = new BlockCardView();
                IBlockCardPresenter blockCardPresenter = new BlockCardPresenter(bea, blockCardView);
                //blockCardPresenter.ToStart += Presenter_ToStart;
                //blockCardPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(blockCardPresenter);
                blockCardPresenter.Confirm += ToResultMessageView_Confirm;

                _mainForm.AddView(blockCardView as BlockCardView);
            }
        }
        #endregion

        private void _personalAreaPresenter_CardPaymentsClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                IPaymentsView paymentsView = new PaymentsView();
                IPaymentsPresenter paymentsPresenter = new PaymentsPresenter(bea, paymentsView);
                //paymentsPresenter.ToStart += Presenter_ToStart;
                //paymentsPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(paymentsPresenter);
                paymentsPresenter.ButtonCharityClick += PaymentsPresenter_ButtonCharityClick;
                paymentsPresenter.ButtonFillMobileClick += PaymentsPresenter_ButtonFillMobileClick;
                paymentsPresenter.ButtonSendToOtherCardClick += PaymentsPresenter_ButtonSendToOtherCardClick;

                _mainForm.AddView(paymentsView as PaymentsView);
            }
        }

        #region PaymentsButtons
        /// <summary>
        /// отправка денег на другую карту, ввод номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentsPresenter_ButtonSendToOtherCardClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                IEnterCardNumberView enterCardNumberView = new EnterCardNumberView();
                IEnterCardNumberPresenter sendToOtherCardPresenter = new EnterCardNumberPresenter(bea, enterCardNumberView);
                sendToOtherCardPresenter.Confirm += SendToOtherCardPresenter_Confirm;
                //sendToOtherCardPresenter.ToStart += Presenter_ToStart;
                //sendToOtherCardPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(sendToOtherCardPresenter);

                _mainForm.AddView(enterCardNumberView as EnterCardNumberView);
            }
        }
        /// <summary>
        /// отправка денег на другую карту, ввод суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendToOtherCardPresenter_Confirm(object sender, EventArgs e)
        {
            ToMoneyViewPage(e);
        }


        /// <summary>
        /// пополнение мобильго, ввод номера телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentsPresenter_ButtonFillMobileClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            { 
                IEnterCardNumberView enterPhoneNumberView = new EnterCardNumberView();
                IEnterTelephoneNumberPresenter phoneNumberPresenter = new EnterTelephoneNumberPresenter(bea, enterPhoneNumberView);
                phoneNumberPresenter.Confirm += PhoneNumberPresenter_Confirm;
                //phoneNumberPresenter.ToStart += Presenter_ToStart;
                //phoneNumberPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(phoneNumberPresenter);

                _mainForm.AddView(enterPhoneNumberView as EnterCardNumberView);
            }
        }
        /// <summary>
        /// пополнение мобильго, ввод суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberPresenter_Confirm(object sender, EventArgs e)
        {
            ToMoneyViewPage(e);
        }

        /// <summary>
        /// переход на страницу ввода суммы/внесения денег
        /// </summary>
        /// <param name="card">текущая карта</param>
        /// <param name="bvf">опции функционала окна</param>
        void ToMoneyViewPage(EventArgs e)
        {
            IEnterCardNumberView getMoneyView = new EnterCardNumberView();
            IGetMoneyNumberPresenter getMoneySumNumberPresenter = null;
            bool wasInitialized = false;

            CharityEventArgs cea = e as CharityEventArgs;
            if (cea != null)
            {
                getMoneySumNumberPresenter = new GetMoneyNumberPresenter(cea, getMoneyView);
                wasInitialized = true;
            }
            else
            {
                SendingMoneyEventArgs sea = e as SendingMoneyEventArgs;
                if (sea != null)
                {
                    getMoneySumNumberPresenter = new GetMoneyNumberPresenter(sea, getMoneyView);
                    wasInitialized = true;
                }
                else
                {
                    BoolEventArgs bea = e as BoolEventArgs;
                    if (bea != null)
                    {
                        getMoneySumNumberPresenter = new GetMoneyNumberPresenter(bea, getMoneyView);
                        wasInitialized = true;
                    }
                }
            }
            if(wasInitialized)
            {
                //getMoneySumNumberPresenter.ToStart += Presenter_ToStart;
                getMoneySumNumberPresenter.Confirm += ToResultMessageView_Confirm;
                SetPersonalAreaEvents(getMoneySumNumberPresenter);
                //getMoneySumNumberPresenter.ToPersonalArea += Presenter_ToPersonalArea;

                _mainForm.AddView(getMoneyView as EnterCardNumberView);
            }
        }

        private void PaymentsPresenter_ButtonCharityClick(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                ICharityView charityView = new CharityView();
                ICharityPresenter charityPresenter = new CharityPresenter(bea, charityView);
                //charityPresenter.ToStart += Presenter_ToStart;
                //charityPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(charityPresenter);
                charityPresenter.AIClick += CharityPresenter_CharityClick;
                charityPresenter.PenguinsClick += CharityPresenter_CharityClick;
                charityPresenter.SquirrelClick += CharityPresenter_CharityClick;

                _mainForm.AddView(charityView as CharityView);
            }
        }

        private void CharityPresenter_CharityClick(object sender, EventArgs e)
        {
            ToMoneyViewPage(e);
        }
        #endregion

        private void _personalAreaPresenter_FillCardClick(object sender, EventArgs e)
        {
            ShowInsertMoneyView(e);
        }

        /// <summary>
        /// общая функция для перехода в личный кабинет через ввод пина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Presenter_ToPersonalArea(object sender, EventArgs e)
        {
            Wfv_InsertCard(sender, e);
        }

        private void _personalAreaPresenter_GetMoneyClick(object sender, EventArgs e)
        {
            ToMoneyViewPage(e);
        }
        #endregion

        private void _loginView_AddCash(object sender, EventArgs e)
        {
            IEnterCardNumberView enterCardNumberView = new EnterCardNumberView();
            _enterCardNumberPresenter = new EnterCardNumberPresenter(new BoolEventArgs("Пополнение карты.", new Cards(), BaseViewsFunctionality.StartPageBaseView),enterCardNumberView);
            _enterCardNumberPresenter.Confirm += EnterCardNumberPresenter_Confirm;
            _enterCardNumberPresenter.ToStart += Presenter_ToStart;            

            _mainForm.AddView(enterCardNumberView as EnterCardNumberView);
        }
        #endregion

        #region AddCash button
        private void Presenter_ToStart(object sender, EventArgs e)
        {
            _mainForm.AddView(LoginView as LoginView);
        }

        private void EnterCardNumberPresenter_Confirm(object sender, EventArgs e)
        {    
            BoolEventArgs bea = e as BoolEventArgs;
            if(bea != null)
            {
                //переход на страницу верификации по звонку   
                IEnterCardNumberView enterPhoneNumberView = new EnterCardNumberView();
                _enterCardNumberPresenter = new EnterTelephoneNumberPresenter(bea, enterPhoneNumberView);
                _enterCardNumberPresenter.Confirm += _enterTelephoneNumberPresenter_Confirm;
                _enterCardNumberPresenter.ToStart += Presenter_ToStart;

                _mainForm.AddView(enterPhoneNumberView as EnterCardNumberView);
            }
        }

        private void _enterTelephoneNumberPresenter_Confirm(object sender, EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                // переход на страницу ввода ключа(последних цифр телефона, с которых поступает звонок)  
                IEnterCardNumberView enterPhoneNumberView = new EnterCardNumberView();
                _enterCardNumberPresenter = new EnterKeyNumberPresenter(bea, enterPhoneNumberView);
                _enterCardNumberPresenter.Confirm += _enterKeyNumberPresenter_Confirm;
                _enterCardNumberPresenter.ToStart += Presenter_ToStart;

                _mainForm.AddView(enterPhoneNumberView as EnterCardNumberView);
            }
        }

        private void _enterKeyNumberPresenter_Confirm(object sender, EventArgs e)
        {
            ShowInsertMoneyView(e);
        }

        /// <summary>
        /// представление внесения денег в банкомат
        /// </summary>
        /// <param name="bvf"></param>
        /// <param name="e"></param>
        private void ShowInsertMoneyView(EventArgs e)
        {
            BoolEventArgs bea = e as BoolEventArgs;
            if (bea != null)
            {
                // переход на страницу ввода суммы/внесения денег
                IInsertMoneyView insertMoneyView = new InsertMoneyView();
                EnterMoneySumNumberPresenter enterMoneySumNumberPresenter = new EnterMoneySumNumberPresenter(bea, insertMoneyView);
                //enterMoneySumNumberPresenter.ToStart += Presenter_ToStart;
                enterMoneySumNumberPresenter.Confirm += ToResultMessageView_Confirm;
                //if(bea.BaseViewsFunctionality == BaseViewsFunctionality.PersonalAreaBaseView)
                //    enterMoneySumNumberPresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(enterMoneySumNumberPresenter);

                _mainForm.AddView(insertMoneyView as InsertMoneyView);
            }
        }

        private void ToResultMessageView_Confirm(object sender, EventArgs e)
        {
            CharityEventArgs cea = e as CharityEventArgs;
            if (cea != null)
            {
                IImageMessageView resultMessageView = new ImageMessageView();
                string message = cea.Argument;
                cea.SetEmptyArgument();
                ResultMessagePresenter resultMessagePresenter = new ResultMessagePresenter(cea, resultMessageView);
                //resultMessagePresenter.ToStart += Presenter_ToStart;
                //resultMessagePresenter.ToPersonalArea += Presenter_ToPersonalArea;
                SetPersonalAreaEvents(resultMessagePresenter);

                _mainForm.AddView(resultMessageView as ImageMessageView);
            }
            else
            {
                BoolEventArgs bea = e as BoolEventArgs;
                if (bea != null)
                {
                    IResultMessageView resultMessageView = new ResultMessageView();
                    string message = bea.Argument;
                    bea.SetEmptyArgument();
                    ResultMessagePresenter resultMessagePresenter = new ResultMessagePresenter(bea, resultMessageView, message);
                    //resultMessagePresenter.ToStart += Presenter_ToStart;
                    //if (bea.BaseViewsFunctionality == BaseViewsFunctionality.PersonalAreaBaseView)
                    //    resultMessagePresenter.ToPersonalArea += Presenter_ToPersonalArea;
                    SetPersonalAreaEvents(resultMessagePresenter);

                    _mainForm.AddView(resultMessageView as ResultMessageView);
                }
            }
        }
        #endregion
    }
}
