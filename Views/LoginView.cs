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
    public interface ILoginView
    {
        /// <summary>
        /// вставить банковскую карту в банкомат
        /// </summary>
        event EventHandler InsertingCard;
        /// <summary>
        /// пополнить карту наличкой
        /// </summary>
        event EventHandler AddCash;
        /// <summary>
        /// получить новую карту
        /// </summary>
        event EventHandler GetCard;
    }
    public partial class LoginView : BaseControl, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public event EventHandler InsertingCard;
        public event EventHandler AddCash;
        public event EventHandler GetCard;

        private void LoginView_Load(object sender, EventArgs e)
        {
            labelPageName.Text = "Страница приветствия";
            labelInstructions.Text = "Вы може совершать операции с картой и без карты.";
        }

        private void buttonInsertCard_Click(object sender, EventArgs e)
        {
            InsertingCard?.Invoke(this, e);
        }

        private void buttonAddCash_Click(object sender, EventArgs e)
        {
            AddCash?.Invoke(this, e);
        }

        private void buttonGetCard_Click(object sender, EventArgs e)
        {
            GetCard?.Invoke(this, e);
        }
    }
}
