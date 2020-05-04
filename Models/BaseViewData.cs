using BankomatClient.BankomatLocalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models
{
    /// <summary>
    /// базовые поля для менеджеров представлений
    /// </summary>
    public abstract class BaseViewData
    {
        private Cards _currentCard;
        /// <summary>
        /// текущая карта, с которой работает банкомат
        /// </summary>
        protected Cards CurrentCard { get => _currentCard; set => _currentCard = value; }        
    }
}
