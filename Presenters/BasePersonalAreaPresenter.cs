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
    public abstract class BasePersonalAreaPresenter : BaseViewData, IBasePersonalAreaView
    {
        public event EventHandler ToPersonalArea;
        public event EventHandler ToStart;

        protected IBasePersonalAreaView _basePersonalAreaView;
        protected BaseViewsFunctionality _baseViewsFunctionality;

        public BasePersonalAreaPresenter(BoolEventArgs bea, IBasePersonalAreaView basePersonalAreaView)
        {
            if (bea != null)
            {
                if (basePersonalAreaView != null)
                {
                    _basePersonalAreaView = basePersonalAreaView;
                    _basePersonalAreaView.ToPersonalArea += _basePersonalAreaView_ToPersonalArea;
                    _basePersonalAreaView.ToStart += _basePersonalAreaView_ToStart;
                }

                if (bea.Card != null)
                {
                    CurrentCard = bea.Card;
                    SetBalance($"Ваш баланс: {bea.Card.Balance} грн.");
                }
                else
                {
                    SetViewLabels("Ошибка", "Ошибка работы с картой");
                    return;
                }

                SetViewFunctionality(bea.BaseViewsFunctionality);
                SetDetailsLabel(bea.Argument);
            }
            else
                SetViewLabels("Ошибка", "Ошибка инициализации данных");
        }

        /// <summary>
        /// получить сообщение о текущей странице для следующей
        /// </summary>
        /// <returns></returns>
        protected string GetMessageAboutCurrentPage(MyPresenters presenter)
        {            
            Dictionary<BaseViewsFunctionality, string> innerDict;
            if(ViewsFuncionalityMessageCollection.Items.TryGetValue(presenter, out innerDict))
            {
                string rez = "";
                if (innerDict.TryGetValue(_baseViewsFunctionality, out rez))
                    return rez;
            }

            return "";
        }

        /// <summary>
        /// нажатие на кнопку "на стартовую страницу/в начало"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void _basePersonalAreaView_ToStart(object sender, EventArgs e)
        {
            ToStart?.Invoke(sender, e);
        }

        /// <summary>
        /// нажатие на кнопку "назад в личный кабинет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void _basePersonalAreaView_ToPersonalArea(object sender, EventArgs e)
        {
            ToPersonalArea?.Invoke(this, new NumberEventArgs(CurrentCard.CardNumber));
        }

        /// <summary>
        /// индикация дополнительного сообщения на базовом контроле
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            if (_basePersonalAreaView != null)
                _basePersonalAreaView.SendMessage(message);
        }

        /// <summary>
        /// настройка элементов контрола для отображения
        /// </summary>
        /// <param name="bvf"></param>
        public void SetViewFunctionality(BaseViewsFunctionality bvf)
        {
            _baseViewsFunctionality = bvf;
            if (_basePersonalAreaView != null)
                _basePersonalAreaView.SetViewFunctionality(bvf);
        }

        /// <summary>
        /// заполнение заголовков базового контрола
        /// </summary>
        /// <param name="pageName">первый заголовок</param>
        /// <param name="instructions">второй, уточняющий заголовок</param>
        public void SetViewLabels(string pageName, string instructions)
        {
            if (_basePersonalAreaView != null)
                _basePersonalAreaView.SetViewLabels(pageName, instructions);
        }

        /// <summary>
        /// отобразить текущий баланс карты
        /// </summary>
        /// <param name="balanceText"></param>
        public void SetBalance(string balanceText)
        {
            if (_basePersonalAreaView != null)
                _basePersonalAreaView.SetBalance(balanceText);
        }

        /// <summary>
        /// отобразить детали о предыдущей странице банкомата
        /// </summary>
        /// <param name="text"></param>
        public void SetDetailsLabel(string text)
        {
            if (_basePersonalAreaView != null)
                _basePersonalAreaView.SetDetailsLabel(text);
        }
    }
}
