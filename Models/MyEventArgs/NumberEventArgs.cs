using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи номера (банковской карты или номера телефона, пина и т.д.)
    /// </summary>
    public class NumberEventArgs : EventArgs
    {
        string _number;
        /// <summary>
        /// номер карты
        /// </summary>
        public string Number { get => _number;  }

        public NumberEventArgs(string number)
        {
            _number = number;
        }
    }
}
