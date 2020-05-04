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
    public interface IImageMessageView : IResultMessageView
    {
        /// <summary>
        /// установка главной картинки на представлении
        /// </summary>
        /// <param name="img"></param>
        void SetMainPicture(Image img);
    }
    public partial class ImageMessageView : ResultMessageView, IImageMessageView
    {
        public ImageMessageView()
        {
            InitializeComponent();
        }

        public void SetMainPicture(Image img)
        {
            pictureBoxMainImage.BackgroundImage = img;
        }
    }
}
