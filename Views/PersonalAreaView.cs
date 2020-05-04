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
    public interface IPersonalAreaView : IBasePersonalAreaView
    {
        event EventHandler CardOperationsClick;
        event EventHandler GetMoneyClick;
        event EventHandler FillCardClick;
        event EventHandler CardPaymentsClick;
    }
    public partial class PersonalAreaView : BasePersonalAreaView, IPersonalAreaView
    {
        public PersonalAreaView()
        {
            InitializeComponent();          
        }

        public event EventHandler CardOperationsClick;
        public event EventHandler GetMoneyClick;
        public event EventHandler FillCardClick;
        public event EventHandler CardPaymentsClick;

        private void buttonCardOperations_Click(object sender, EventArgs e)
        {
            CardOperationsClick?.Invoke(this, e);
        }

        private void buttonGetMoney_Click(object sender, EventArgs e)
        {
            GetMoneyClick?.Invoke(this, e);
        }

        private void buttonFillCard_Click(object sender, EventArgs e)
        {
            FillCardClick?.Invoke(this, e);
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            CardPaymentsClick?.Invoke(this, e);
        }
    }
}
