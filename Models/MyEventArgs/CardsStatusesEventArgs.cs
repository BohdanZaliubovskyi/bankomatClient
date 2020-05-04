using BankomatClient.BankomatLocalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для передачи вида карт
    /// </summary>
    public class CardsStatusesEventArgs : EventArgs
    {
        CardsStatuses _cardsStatuses;
        public CardsStatusesEventArgs(CardsStatuses cardsStatuses)
        {
            _cardsStatuses = cardsStatuses;
        }

        public CardsStatuses CardsStatuses { get => _cardsStatuses; }
    }
}
