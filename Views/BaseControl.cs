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
    public interface IBaseControl
    {
        /// <summary>
        /// событие нажатия на кнопку "В начало"
        /// </summary>
        event EventHandler ToStart;
    }
    public partial class BaseControl : UserControl, IBaseControl
    {
        public BaseControl()
        {
            InitializeComponent();
        }

        public event EventHandler ToStart;

        private void BaseControl_Load(object sender, EventArgs e)
        {
            labelNotifyMessage.Visible = false;
        }

        private void buttonToStartPage_Click(object sender, EventArgs e)
        {
            ToStart?.Invoke(this, e);
        }

        protected void BaseSendMessage(string message)
        {
            labelNotifyMessage.Text = message;
            labelNotifyMessage.Visible = true;
        }
    }
}
