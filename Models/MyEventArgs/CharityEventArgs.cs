using BankomatClient.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models.MyEventArgs
{
    /// <summary>
    /// аргументы для работы с представлением благотворительности
    /// </summary>
    public class CharityEventArgs : BoolEventArgs
    {
        CharityForm _charityForm;
        public CharityEventArgs(BoolEventArgs bea, CharityForm charityForm) : base(bea.Argument, bea.Card, bea.BaseViewsFunctionality)
        {
            _charityForm = charityForm;
        }

        public CharityForm CharityForm { get => _charityForm; }
    }
}
