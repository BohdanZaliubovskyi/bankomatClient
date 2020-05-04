using BankomatClient.BankomatLocalService;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// класс для передачи булевых аргументов ( + карта)
    /// </summary>
    public class BoolEventArgs : CardEventArgs
    {       
        BaseViewsFunctionality _baseViewsFunctionality;        
        public BaseViewsFunctionality BaseViewsFunctionality { get => _baseViewsFunctionality;}

        public BoolEventArgs(string argument, Cards card, BaseViewsFunctionality baseViewsFunctionality ) : base(card, argument)
        {
            _baseViewsFunctionality = baseViewsFunctionality;
        }        
    }
}
