using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankomatClient.BankomatLocalService;
using BankomatClient.Models.MyEventArgs;

namespace BankomatClient.Views
{
    public interface IGiveOutCardView : IBasePersonalAreaView
    {
        event EventHandler GetCardClick;
        void SetInitialData(Dictionary<string, CardsStatuses> cardsViewsDict, Dictionary<CardsStatuses, string> cardsLimitsDict);
    }
   
    public partial class GiveOutCardView : BasePersonalAreaView, IGiveOutCardView
    {
        Dictionary<string, CardsStatuses> _cardsViewsDict;
        Dictionary<CardsStatuses, string> _cardsLimitsDict;

        public GiveOutCardView()
        {
            InitializeComponent();                      
        }

        public event EventHandler GetCardClick;

        public void SetInitialData(Dictionary<string, CardsStatuses> cardsViewsDict, Dictionary<CardsStatuses, string> cardsLimitsDict)
        {
            if (cardsLimitsDict != null)
                _cardsLimitsDict = cardsLimitsDict;
            if (cardsViewsDict != null)
            {
                _cardsViewsDict = cardsViewsDict;
                comboBoxCardStatuses.DataSource = _cardsViewsDict.Keys.ToList();
            }           
        }

        private void buttonGetCard_Click(object sender, EventArgs e)
        {
            CardsStatuses cs;
            if(_cardsViewsDict.TryGetValue(comboBoxCardStatuses.SelectedValue.ToString(), out cs))
                GetCardClick?.Invoke(sender, new CardsStatusesEventArgs(cs));
        }

        private void comboBoxCardStatuses_SelectedValueChanged(object sender, EventArgs e)
        {
            CardsStatuses cs;
            if (_cardsViewsDict.TryGetValue(comboBoxCardStatuses.SelectedValue.ToString(), out cs))
            {
                string limit;
                if (!_cardsLimitsDict.TryGetValue(cs, out limit))
                    limit = "информация отсутствует";

                switch (cs)
                {
                    case CardsStatuses.BlackCard:
                        richTextBoxCardInfo.Text = $"Вы получите стильную черную карту. Лимит по этой карте составляет:{limit}";
                        break;
                    case CardsStatuses.BlueCard:
                        richTextBoxCardInfo.Text = $"Вы получите обычную некрасивую синюю карту. Лимит по ней составляет:{limit}";
                        break;
                    case CardsStatuses.GoldCard:
                        richTextBoxCardInfo.Text = $"Вы получите золотую карту с лучшими условиями и обслуживанием, что у нас есть. Лимит составляет:{limit}";
                        break;
                }
            }
        }
    }
}
