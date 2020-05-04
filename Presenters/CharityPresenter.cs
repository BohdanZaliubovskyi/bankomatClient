using BankomatClient.Models.MyEventArgs;
using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Presenters
{
    /// <summary>
    /// перечисление благотворительностей, которые могут быть
    /// </summary>
    public enum CharityForm
    {
        /// <summary>
        /// ИИ
        /// </summary>
        AI = 1,
        /// <summary>
        /// пингвины
        /// </summary>
        Penguins,
        /// <summary>
        /// белки
        /// </summary>
        Squirrel,
        /// <summary>
        /// без благотворительности
        /// </summary>
        None,
    }
    public interface ICharityPresenter : ICharityView
    { }

    class CharityPresenter : BasePersonalAreaPresenter, ICharityPresenter
    {
        public event EventHandler PenguinsClick;
        public event EventHandler SquirrelClick;
        public event EventHandler AIClick;

        public CharityPresenter(BoolEventArgs bea, ICharityView charityView) : base(bea, charityView)
        {
            if(charityView != null)
            {
                (_basePersonalAreaView as ICharityView).AIClick += CharityPresenter_AIClick;
                (_basePersonalAreaView as ICharityView).PenguinsClick += CharityPresenter_PenguinsClick;
                (_basePersonalAreaView as ICharityView).SquirrelClick += CharityPresenter_SquirrelClick;
            }
            SetViewLabels("Страница благотворительности","Выберите, на что вы хотите пожертвовать");
        }

        private void CharityPresenter_SquirrelClick(object sender, EventArgs e)
        {
            SquirrelClick?.Invoke(sender, new CharityEventArgs(new BoolEventArgs(GetMessageAboutCurrentPage(Models.MyPresenters.CharityPresenter), CurrentCard, _baseViewsFunctionality), CharityForm.Squirrel));
        }

        private void CharityPresenter_PenguinsClick(object sender, EventArgs e)
        {
            PenguinsClick?.Invoke(sender, new CharityEventArgs(new BoolEventArgs(GetMessageAboutCurrentPage(Models.MyPresenters.CharityPresenter), CurrentCard, _baseViewsFunctionality), CharityForm.Penguins));
        }

        private void CharityPresenter_AIClick(object sender, EventArgs e)
        {
            AIClick?.Invoke(sender, new CharityEventArgs(new BoolEventArgs(GetMessageAboutCurrentPage(Models.MyPresenters.CharityPresenter), CurrentCard, _baseViewsFunctionality), CharityForm.AI));
        }
    }
}
