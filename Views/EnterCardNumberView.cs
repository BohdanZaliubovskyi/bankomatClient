using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankomatClient.Models.MyEventArgs;

namespace BankomatClient.Views
{
    public interface IEnterCardNumberView : IBaseControl
    {
        /// <summary>
        /// отправка номера карты на сервер
        /// </summary>
        event EventHandler ConfirmNumber;
        /// <summary>
        /// нажать цифру
        /// </summary>
        event EventHandler PressDigit;
        /// <summary>
        /// подтвердить правильность написания номера карты
        /// </summary>
        event EventHandler CheckCardNumber;
        /// <summary>
        /// подтвердить отправку номера карты на сервер
        /// </summary>
        /// <param name="cardNumber">номер карты</param>
        void ConfirmSending(string cardNumber);
        /// <summary>
        /// уведомление клиента о том, что он ввел неправильный номер карты
        /// </summary>
        /// <param name="message"></param>
        void SendMessage(string message);
        /// <summary>
        /// нажатие на кнопку удалить
        /// </summary>
        event EventHandler PressDel;
        /// <summary>
        /// добавление цифры в номер карты
        /// </summary>
        /// <param name="digit">цифра</param>
        void AddDigit(int digit);
        /// <summary>
        /// удаление последней цифры из номера карты
        /// </summary>
        void DelDigit();
        
    }
    public partial class EnterCardNumberView : BaseControl, IEnterCardNumberView
    {
        public EnterCardNumberView()
        {
            InitializeComponent();
        }

        public event EventHandler CheckCardNumber;
        public event EventHandler ConfirmNumber;
        public event EventHandler PressDigit;
        public event EventHandler PressDel;

        private void EnterCardNumberView_Load(object sender, EventArgs e)
        {
            labelPageName.Text = "Пополнение карты";
            labelInstructions.Text = "Введите номер карты";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            CheckCardNumber?.Invoke(this, new CardNumberEventArgs(textBoxCardNumber.Text));
        }

        public void ConfirmSending(string cardNumber)
        {
            ConfirmNumber?.Invoke(this, new CardNumberEventArgs(cardNumber));
        }

        public void SendMessage(string message)
        {
            BaseSendMessage(message);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(4));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(5));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(6));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(7));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(8));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PressDigit?.Invoke(this, new DigitEventArgs(9));
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            PressDel?.Invoke(this, e);
        }

        public void AddDigit(int digit)
        {
            textBoxCardNumber.Text = string.Format("{0}{1}", textBoxCardNumber.Text, digit);
        }

        public void DelDigit()
        {
            textBoxCardNumber.Text = textBoxCardNumber.Text.Remove(textBoxCardNumber.Text.Length - 1);
        }
    }
}
