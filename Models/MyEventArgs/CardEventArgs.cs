using BankomatClient.BankomatLocalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи объекта карты
    /// </summary>
    public class CardEventArgs : EventArgs
    {
        Cards _card = null;
        /// <summary>
        /// объект банковской карты
        /// </summary>
        public Cards Card { get => _card; }

        public CardEventArgs(Cards card)
        {
            _card = card;
        }
    }
}
