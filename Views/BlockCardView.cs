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
    public interface IBlockCardView : IBasePersonalAreaView
    {
        event EventHandler BlockCardClick;
    }
    public partial class BlockCardView : BasePersonalAreaView, IBlockCardView
    {
        public BlockCardView()
        {
            InitializeComponent();
        }

        public event EventHandler BlockCardClick;

        private void buttonBlockCard_Click(object sender, EventArgs e)
        {
            BlockCardClick?.Invoke(this, null);
        }
    }
}
