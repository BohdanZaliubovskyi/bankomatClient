using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models
{
    /// <summary>
    /// данные для страницы информации с картинкой
    /// </summary>
    public class MessageViewData
    {
        string _message;
        Image _img;

        public MessageViewData(string message, Image img)
        {
            _message = message;
            _img = img;
        }

        public string Message { get => _message; }
        public Image Img { get => _img; }
    }
}
