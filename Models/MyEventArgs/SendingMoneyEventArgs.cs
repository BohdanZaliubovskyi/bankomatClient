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
    /// аргументы для передачи данных при отправки денег с карты на карту
    /// </summary>
    public class SendingMoneyEventArgs : BoolEventArgs
    {
        string _toCardNumber;
        public SendingMoneyEventArgs(string toCardNumber, string argument, Cards card, BaseViewsFunctionality baseViewsFunctionality) :base(argument, card, baseViewsFunctionality)
        {
            _toCardNumber = toCardNumber;
        }

        public string ToCardNumber { get => _toCardNumber; }
    }
}
