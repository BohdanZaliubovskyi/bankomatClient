using BankomatClient.BankomatLocalService;
using BankomatClient.Models;
using BankomatClient.Models.MyEventArgs;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    public interface IEnterNumberPresenter : IBasePersonalAreaView, IConfirmPresenter
    {
        /// <summary>
        /// подтверждение отправки номера карты/телефона на сервер
        /// </summary>
        //event EventHandler Confirm;
    }
    public abstract class BaseEnterNumberPresenter : BaseBackgroundWorker, IEnterNumberPresenter
    {
        public BaseEnterNumberPresenter(BoolEventArgs bea, IEnterCardNumberView enterCardNumberView) : base(bea, enterCardNumberView)
        {
            if (enterCardNumberView != null)
            {
                //_enterNumberView = enterCardNumberView;
                (_basePersonalAreaView as IEnterCardNumberView).CheckCardNumber += _enterNumberView_CheckNumber;
                (_basePersonalAreaView as IEnterCardNumberView).ConfirmNumber += _enterNumberView_ConfirmNumber;
                (_basePersonalAreaView as IEnterCardNumberView).PressDigit += _enterCardNumberView_PressDigit;
                (_basePersonalAreaView as IEnterCardNumberView).PressDel += _enterCardNumberView_PressDel;
            }
        }

        private void _enterCardNumberView_PressDel(object sender, EventArgs e)
        {
            if (_basePersonalAreaView != null)
                (_basePersonalAreaView as IEnterCardNumberView).DelDigit();
        }

        private void _enterCardNumberView_PressDigit(object sender, EventArgs e)
        {
            DigitEventArgs dea = e as DigitEventArgs;
            if (dea != null)
                (_basePersonalAreaView as IEnterCardNumberView).AddDigit(dea.Digit);
        }

        protected abstract void _enterNumberView_ConfirmNumber(object sender, EventArgs e);

        protected abstract void _enterNumberView_CheckNumber(object sender, EventArgs e);

        /// <summary>
        /// проверка номера на правильность записи
        /// </summary>
        /// <param name="number">проверяемый номер</param>
        /// <returns>true=все верно false=неправильная запись</returns>
        protected abstract bool CheckNumber(string number);

    }
}
