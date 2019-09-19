using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи цифры, нажатой на банкомате
    /// </summary>
    public class DigitEventArgs : EventArgs
    {
        int _digit;
        /// <summary>
        /// цифра, нажатая на клавиатуре банкомата
        /// </summary>
        public int Digit { get => _digit;  }
        public DigitEventArgs(int digit)
        {
            _digit = digit;
        }
    }
}
