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
    public interface IGiveOutCardPresenter : IConfirmPresenter, IBaseStart
    {
    }
    public class GiveOutCardPresenter : BaseBackgroundWorker, IGiveOutCardPresenter
    {
        public override event EventHandler Confirm;

        Clients _curClient;

        Dictionary<string, CardsStatuses> _cardsViewsDict;
        Dictionary<CardsStatuses, string> _cardsLimitsDict;

        string GetLimitInString(int limit)
        {
            if (limit == -1)
                return "без лимита";
            else
                return $"{limit} грн./день";
        }

        public GiveOutCardPresenter(BoolEventArgs bea, Clients client, IGiveOutCardView giveOutCardView) :base(bea, giveOutCardView)
        {            
            _curClient = client;

            _cardsViewsDict = new Dictionary<string, CardsStatuses>();
            _cardsViewsDict.Add("Черная карта", CardsStatuses.BlackCard);
            _cardsViewsDict.Add("Синяя карта", CardsStatuses.BlueCard);
            _cardsViewsDict.Add("Золотая карта", CardsStatuses.GoldCard);

            BaseCardsLimits bcl;
            try
            {
                bcl = _bankomatLocalService.GetCardsLimits();
            }
            catch
            {
                bcl = null;
                SendMessage("Ошибка. Нет соединения с сервером...");
            }
            if (bcl != null)
            {
                CardsLimits cl = bcl as CardsLimits;
                if (cl != null)
                {
                    _cardsLimitsDict = new Dictionary<CardsStatuses, string>();
                    _cardsLimitsDict.Add(CardsStatuses.BlackCard, GetLimitInString(cl.BlackCardLimit));
                    _cardsLimitsDict.Add(CardsStatuses.BlueCard, GetLimitInString(cl.BlueCardLimit));
                    _cardsLimitsDict.Add(CardsStatuses.GoldCard, GetLimitInString(cl.GoldCardLimit));
                }
                if (giveOutCardView != null)
                {
                    (_basePersonalAreaView as IGiveOutCardView).GetCardClick += _giveOutCardView_GetCardClick;
                    (_basePersonalAreaView as IGiveOutCardView).SetInitialData(_cardsViewsDict, _cardsLimitsDict);
                }
                SetViewLabels("Страница выдачи новой карты", "Выберите вид карты для выдачи");
            }
        }

        private void _giveOutCardView_GetCardClick(object sender, EventArgs e)
        {
            if(e != null)
            {
                SendMessage("Подождите, идет обработка данных...");

                _waitForm = new WaitForm();
                _waitForm.Show();
                _bw.RunWorkerAsync(e);
            }
        }

        protected override void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                SendMessage("Невозможно установить связь с сервером.");
            else if (e.Result == null)
                SendMessage("Во время обмена данными произошла ошибка.");
            else
            {
                Confirm?.Invoke(this, new BoolEventArgs(e.Result.ToString(), new Cards(), _baseViewsFunctionality));
            }
            _waitForm.Close();
        }

        protected override void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            CardsStatusesEventArgs csea = e.Argument as CardsStatusesEventArgs;
            if (csea != null)
            {
                string message = _bankomatLocalService.GetNewCard(_curClient.Id, csea.CardsStatuses);
                e.Result = message;
            }
            else
                e.Result = null;
        }
    }
}
