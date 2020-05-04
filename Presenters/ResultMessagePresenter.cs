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
using System.Windows.Forms;

namespace BankomatClient.Presenters
{
    public class ResultMessagePresenter : BasePersonalAreaPresenter, IBasePersonalAreaView
    {
        Timer _offTimer;
        int _secCount = 10;

        void InitializeData()
        {
            SetViewLabels("Страница информации", "Ознакомьтесь с информацией");
        }

        public ResultMessagePresenter(BoolEventArgs bea, IResultMessageView resultMessageView, string message) : base(bea, resultMessageView)
        {
            if (resultMessageView != null)
            {      
                if(bea != null)
                    if (bea.BaseViewsFunctionality == BaseViewsFunctionality.StartPageBaseView)
                    {
                        _offTimer = new Timer();
                        _offTimer.Tick += _offTimer_Tick;
                        _offTimer.Interval = 1000;
                        _offTimer.Start();
                    }

                (_basePersonalAreaView as IResultMessageView).SetMessage(message);
                InitializeData();
            }
        }

        Dictionary<CharityForm, MessageViewData> _messages;

        public ResultMessagePresenter(CharityEventArgs cea, IImageMessageView imageMessageView) :base (new BoolEventArgs(cea.Argument, cea.Card, cea.BaseViewsFunctionality), imageMessageView)
        {
            _messages = new Dictionary<CharityForm, MessageViewData>();
            _messages.Add(CharityForm.AI, new MessageViewData("Возможно благодаря вашему пожертвованию ИИ захватит мир немного позже.", Properties.Resources.AI));
            _messages.Add(CharityForm.Penguins, new MessageViewData("Возможно ваше пожертвование поможет спасти пингвинов с льдины.", Properties.Resources.penguins));
            _messages.Add(CharityForm.Squirrel, new MessageViewData("Возможно ваше пожертвование поможет найти белкам свою половинку.", Properties.Resources.squirrel));

            if (cea != null)
            {
                MessageViewData message;
                if (_messages.TryGetValue(cea.CharityForm, out message))
                {
                    (_basePersonalAreaView as IImageMessageView).SetMessage(message.Message);
                    (_basePersonalAreaView as IImageMessageView).SetMainPicture(message.Img);
                }
            }
            else
            {
                (_basePersonalAreaView as IImageMessageView).SetMessage("Нет данных.");
            }
            InitializeData();
        }

        private void _offTimer_Tick(object sender, EventArgs e)
        {
            _secCount -= 1;
            if(_secCount == 0)
            {
                _offTimer.Stop();
                _basePersonalAreaView_ToStart(this, null);
            }

            (_basePersonalAreaView as IResultMessageView).SetOffMessage($"Страница закроется через {_secCount} секунд(ы)");
        }

    }
}
