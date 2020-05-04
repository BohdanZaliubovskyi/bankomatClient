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
    public interface ICharityView : IBasePersonalAreaView
    {
        event EventHandler PenguinsClick;
        event EventHandler SquirrelClick;
        event EventHandler AIClick;
    }
    public partial class CharityView : BasePersonalAreaView, ICharityView
    {
        public CharityView()
        {
            InitializeComponent();
        }

        public event EventHandler PenguinsClick;
        public event EventHandler SquirrelClick;
        public event EventHandler AIClick;

        private void buttonPenguins_Click(object sender, EventArgs e)
        {
            PenguinsClick?.Invoke(sender,e);
        }

        private void buttonSquirrel_Click(object sender, EventArgs e)
        {
            SquirrelClick?.Invoke(sender, e);
        }

        private void buttonAI_Click(object sender, EventArgs e)
        {
            AIClick?.Invoke(sender, e);
        }
    }
}
