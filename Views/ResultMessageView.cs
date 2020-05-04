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
    public interface IResultMessageView : IBasePersonalAreaView
    {
        /// <summary>
        /// установка результирующего сообщения
        /// </summary>
        /// <param name="message">сообщение, которое будет на представлении</param>
        void SetMessage(string message);
        /// <summary>
        /// сообщение о закрытии представления сообщения
        /// </summary>
        /// <param name="message"></param>
        void SetOffMessage(string message);
    }
    public partial class ResultMessageView : BasePersonalAreaView, IResultMessageView
    {
        public ResultMessageView() 
        {
            InitializeComponent();
            SetOffMessage("");
        }

        public void SetMessage(string message)
        {
            labelRezMessage.Text = message;
        }

        public void SetOffMessage(string message)
        {
            labelOffMessage.Text = message;
        }
    }
}
