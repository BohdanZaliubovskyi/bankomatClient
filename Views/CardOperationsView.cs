using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankomatClient.Views
{
    public interface ICardOperationView : IBasePersonalAreaView
    {
        event EventHandler ChangePinClick;
        event EventHandler BlockCardClick;
    }
    public partial class CardOperationsView : BasePersonalAreaView, ICardOperationView
    {
        public CardOperationsView()
        {
            InitializeComponent();
            // в этом представлении кнопка "в ЛК" будет видна всегда
        }

        public event EventHandler ChangePinClick;
        public event EventHandler BlockCardClick;

        private void buttonChangePin_Click(object sender, EventArgs e)
        {
            ChangePinClick?.Invoke(this, null);
        }

        private void buttonBlockCard_Click(object sender, EventArgs e)
        {
            BlockCardClick?.Invoke(this, null);
        }
    }
}
