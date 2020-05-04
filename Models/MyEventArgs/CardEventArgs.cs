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
    public class CardEventArgs : StringEventArgs
    {
        Cards _card = null;
        /// <summary>
        /// объект банковской карты
        /// </summary>
        public Cards Card { get => _card; }

        public CardEventArgs(Cards card, string argument) : base(argument)
        {
            _card = card;
        }
        public CardEventArgs(Cards card) : base("")
        {
            _card = card;
        }
    }
}
