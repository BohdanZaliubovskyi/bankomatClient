using BankomatClient.Views;
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
    public interface IMainForm
    {
        /// <summary>
        /// форма закончила базовую загрузку
        /// </summary>
        event EventHandler FormLoaded;
        /// <summary>
        /// добавление на форму контрола, с которым предстоит работать
        /// </summary>
        /// <param name="control"></param>
        void AddView(BaseControl control);
    }
    public partial class MainForm : Form, IMainForm
    {
        /// <summary>
        /// текущее представление для клиента
        /// </summary>
        BaseControl _currentView;

        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler FormLoaded;

        public void AddView(BaseControl control)
        {
            if(control != null)
            {
                _currentView = control;
                _currentView.Location = new Point(0, 0);
                if (Controls.Count == 0)
                    Controls.Add(_currentView);
                else
                {
                    Controls.Clear();
                    Controls.Add(_currentView);
                }
                Controls.Add(buttonClose);
                buttonClose.BringToFront();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke(this, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
