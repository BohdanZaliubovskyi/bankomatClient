using BankomatClient.BankomatLocalService;
using BankomatClient.Models.MyEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankomatClient.Views
{
    public interface IWalletForm
    {
        /// <summary>
        /// событие вставки карты в банкомат
        /// </summary>
        event EventHandler InsertCard;

        void ShowForm();
    }
    public partial class WalletFormView : Form, IWalletForm
    {
        Clients _client;
        List<Cards> _cards;
        //Dictionary<CardsStatuses, Cards> _cardsDict;
        Cards _curCard;
        /// <summary>
        /// словарь для хранения карт в связке с именем контрола, в котором будет отображаться верх этой карты
        /// </summary>
        Dictionary<string, Cards> _cardsDict;

        readonly string _buttonPutCardStartText = "Вставить в банкомат эту карту";

        public event EventHandler InsertCard;

        /// <summary>
        /// размер контрола PictureBox с верхом карты для кошелька
        /// </summary>
        Size _controlSize = new Size(263, 37);

        /// <summary>
        /// словарь для хранения верхник полосок карт для отображения в кошельке
        /// </summary>
        Dictionary<CardsStatuses, Image> _topCardsImgsDict;

        public WalletFormView(Clients client, List<Cards> cards)
        {
            InitializeComponent();

            if (cards != null && cards.Count > 0)
            {
                _client = client;

                _topCardsImgsDict = new Dictionary<CardsStatuses, Image>();
                _topCardsImgsDict.Add(CardsStatuses.BlackCard, Properties.Resources.blackCardTop);
                _topCardsImgsDict.Add(CardsStatuses.BlueCard, Properties.Resources.blueCardTop);
                _topCardsImgsDict.Add(CardsStatuses.GoldCard, Properties.Resources.goldCardTop);

                if (cards.Count <= 4)
                {
                    panelCardsItems.Height = cards.Count * _controlSize.Height;
                    panelCardsItems.Width = _controlSize.Width;
                }
                else
                {
                    panelCardsItems.Height = 4 * _controlSize.Height;
                    panelCardsItems.Width = _controlSize.Width + 17;
                }

                _cardsDict = new Dictionary<string, Cards>();
                for (int i = 0; i < cards.Count; ++i)
                {
                    string controlName = $"pictureBox{i}";
                    _cardsDict.Add(controlName, cards[i]);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = controlName;
                    pictureBox.Size = _controlSize;
                    pictureBox.Location = new Point(0, i * _controlSize.Height);
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.BackgroundImage = _topCardsImgsDict[(CardsStatuses)cards[i].CardStatus];
                    pictureBox.Click += PictureBox_Click;
                    panelCardsItems.Controls.Add(pictureBox);
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            SetCard(((PictureBox)sender).Name);
        }

        private void SetCard(string controlName)
        {
            Cards card = null;
            if (_cardsDict.TryGetValue(controlName, out card))
            {
                SetCurrentCard(card);
            }
        }

        void SetVisibilityToCardElements(bool isVisible)
        {
            labelBank.Visible = isVisible;
            labelHolderName.Visible = isVisible;
            labelTime.Visible = isVisible;
            labelCardNumber.Visible = isVisible;
            pictureBoxFullCard.Visible = isVisible;
            buttonPutCard.Visible = isVisible;
        }

        void SetCurrentCard(Cards card)
        {
            labelCardNumber.Text = $"{card.CardNumber.Substring(0,4)}  {card.CardNumber.Substring(4, 4)}  {card.CardNumber.Substring(8, 4)}  {card.CardNumber.Substring(12, 4)}";
            labelHolderName.Text = _client.Name;
            labelTime.Text = $"{card.DateOfEndUsing.Month}/{card.DateOfEndUsing.Year}";
            CardsStatuses curStat;
            try
            {
                curStat = (CardsStatuses)card.CardStatus;
            }
            catch
            {
                curStat = CardsStatuses.BlackCard;
            }

            switch(curStat)
            {
                case CardsStatuses.BlackCard:
                    pictureBoxFullCard.BackgroundImage = Properties.Resources.BlackCard;
                    break;
                case CardsStatuses.BlueCard:
                    pictureBoxFullCard.BackgroundImage = Properties.Resources.BlueCard;
                    break;
                case CardsStatuses.GoldCard:
                    pictureBoxFullCard.BackgroundImage = Properties.Resources.GoldCard;
                    break;
            }
            buttonPutCard.Text = $"{_buttonPutCardStartText} PIN({card.Pin})";
            SetVisibilityToCardElements(true);
            _curCard = card;
        }

        private void WalletFormView_Load(object sender, EventArgs e)
        {
            SetVisibilityToCardElements(false);
        }

        private void buttonCloseWallet_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPutCard_Click(object sender, EventArgs e)
        {
            InsertCard?.Invoke(this, new NumberEventArgs(_curCard.CardNumber));
            Close();
        }

        public void ShowForm()
        {
            Show();
        }
    }
}
