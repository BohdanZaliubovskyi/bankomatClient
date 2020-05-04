using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи чисел с точкой
    /// </summary>
    class DoubleEventArgs : EventArgs
    {
        double _doubleNumber;
        /// <summary>
        /// число с точкой
        /// </summary>
        public double DoubleNumber { get => _doubleNumber; }

        public DoubleEventArgs(double dbl)
        {
            _doubleNumber = dbl;
        }
    }
}
