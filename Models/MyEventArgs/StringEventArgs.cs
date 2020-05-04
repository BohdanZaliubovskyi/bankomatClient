using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    public class StringEventArgs :EventArgs
    {
        string _argument;
        public string Argument { get => _argument; }
        public StringEventArgs(string argument)
        {
            _argument = argument;
        }
        public void SetEmptyArgument()
        {
            _argument = "";
        }
    }
}
