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
    public interface IBaseStart
    {
        /// <summary>
        /// событие нажатия на кнопку "В начало"
        /// </summary>
        event EventHandler ToStart;
    }
    public interface IBaseControl : IBaseStart
    {        
        /// <summary>
        /// установка заголовков для базового представления
        /// </summary>
        /// <param name="pageName">имя страницы</param>
        /// <param name="instructions">инструкции для пользователя</param>
        void SetViewLabels(string pageName, string instructions);
        /// <summary>
        /// дополнительное уведомление
        /// </summary>
        /// <param name="message">сообщение</param>
        void SendMessage(string message);
        /// <summary>
        /// информация о прошлой странице банкомата
        /// </summary>
        /// <param name="text"></param>
        void SetDetailsLabel(string text);
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

        public void SetViewLabels(string pageName, string instructions)
        {
            labelPageName.Text = pageName;
            labelInstructions.Text = instructions;
        }

        public void SendMessage(string message)
        {
            labelNotifyMessage.Text = message;
            labelNotifyMessage.Visible = true;
        }

        public void SetDetailsLabel(string text)
        {
            labelDetails.Text = text;
        }
    }
}
