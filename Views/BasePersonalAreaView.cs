using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankomatClient.Views
{
    /// <summary>
    /// функциональность отображений для пользователя
    /// </summary>
    public enum BaseViewsFunctionality
    {
        /// <summary>
        /// включает только кнопку "в начало"
        /// </summary>
        StartPageBaseView = 1,
        /// <summary>
        /// включает кнопку "в начало" и "в кабинет"
        /// </summary>
        PersonalAreaBaseView,
    }
    public interface IBasePersonalAreaView : IBaseControl
    {
        /// <summary>
        /// нажатие на кнопку "Вернуться в личный кабинет"
        /// </summary>
        event EventHandler ToPersonalArea;
        /// <summary>
        /// установить видимость доп. элементов( кнопки "в ЛК" )
        /// </summary>
        /// <param name="bvf"></param>
        void SetViewFunctionality(BaseViewsFunctionality bvf);

        /// <summary>
        /// показать текущий баланс карты
        /// </summary>
        /// <param name="balanceText"></param>
        void SetBalance(string balanceText);
    }
    public partial class BasePersonalAreaView : BaseControl, IBasePersonalAreaView
    {
        public BasePersonalAreaView()
        {
            InitializeComponent(); 
        }

        public event EventHandler ToPersonalArea;

        public void SetBalance(string balanceText)
        {
            labelBalance.Text = balanceText;
        }

        public void SetViewFunctionality(BaseViewsFunctionality bvf)
        {
            if (bvf == BaseViewsFunctionality.StartPageBaseView)
            {
                buttonPersonalArea.Visible = false;
                labelBalance.Visible = false;
            }
        }

        private void buttonPersonalArea_Click(object sender, EventArgs e)
        {
            ToPersonalArea?.Invoke(this, e);
        }        
    }
}
