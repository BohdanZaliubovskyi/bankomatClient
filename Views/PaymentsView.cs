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
    public interface IPaymentsView : IBasePersonalAreaView
    {
        event EventHandler ButtonCharityClick;
        event EventHandler ButtonFillMobileClick;
        event EventHandler ButtonSendToOtherCardClick;
    }
    public partial class PaymentsView : BasePersonalAreaView, IPaymentsView
    {
        public PaymentsView()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonCharityClick;
        public event EventHandler ButtonFillMobileClick;
        public event EventHandler ButtonSendToOtherCardClick;

        private void buttonCharity_Click(object sender, EventArgs e)
        {
            ButtonCharityClick?.Invoke(sender, e);
        }

        private void buttonFillMobile_Click(object sender, EventArgs e)
        {
            ButtonFillMobileClick?.Invoke(sender, e);
        }

        private void buttonSendToOtherCard_Click(object sender, EventArgs e)
        {
            ButtonSendToOtherCardClick?.Invoke(sender, e);
        }
    }
}
