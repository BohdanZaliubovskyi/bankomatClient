using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankomatClient
{
    public partial class MobilePhoneForm : Form
    {
        Timer _closeTimer;
        public MobilePhoneForm(string bankNumber)
        {
            InitializeComponent();
            label1.Text = bankNumber;

            _closeTimer = new Timer();
            _closeTimer.Interval = 1000 * 10;
            _closeTimer.Tick += _closeTimer_Tick;
            _closeTimer.Start();
        }

        private void _closeTimer_Tick(object sender, EventArgs e)
        {
            _closeTimer.Stop();
            Close();
        }
    }
}
