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
    public interface IInsertMoneyView : IBasePersonalAreaView
    {
        /// <summary>
        /// вставка купюры
        /// </summary>
        event EventHandler InsertBill;
        /// <summary>
        /// нажатие на кнопку подтвердить
        /// </summary>
        event EventHandler PressButtonConfirm;
        /// <summary>
        /// изменение сообщения с итоговой суммой
        /// </summary>
        /// <param name="message">сообщение, которое будет отображено</param>
        void ChangeLabelResSum(string message);
    }
    public partial class InsertMoneyView : BasePersonalAreaView, IInsertMoneyView
    {
        public InsertMoneyView()
        {
            InitializeComponent();
        }

        public event EventHandler InsertBill;
        public event EventHandler PressButtonConfirm;

        public void ChangeLabelResSum(string message)
        {
            labelRezSum.Text = message;
        }

        private void button10grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(10));
        }

        private void button20grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(20));
        }

        private void button50grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(50));
        }

        private void button100grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(100));
        }

        private void button200grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(200));
        }

        private void button500grn_Click(object sender, EventArgs e)
        {
            InsertBill?.Invoke(this, new DigitEventArgs(500));
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            PressButtonConfirm?.Invoke(this, null);
        }
    }
}
