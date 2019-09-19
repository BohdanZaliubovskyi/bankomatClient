using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи номера банковской карты
    /// </summary>
    public class CardNumberEventArgs : EventArgs
    {
        string _cardNumber;
        /// <summary>
        /// номер карты
        /// </summary>
        public string CardNumber { get => _cardNumber;  }

        public CardNumberEventArgs(string cardNumber)
        {
            _cardNumber = cardNumber;
        }
    }
}
