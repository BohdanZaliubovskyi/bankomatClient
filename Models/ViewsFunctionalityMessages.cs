using BankomatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatClient.Models
{
    /// <summary>
    /// класс для передачи сообщений о предыдущих страницах банкомата
    /// </summary>
    public class ViewsFunctionalityMessages
    {
        Dictionary<BaseViewsFunctionality, string> _viewsMessages;

        public ViewsFunctionalityMessages(string basePageMessage, string personalAreaMessage)
        {
            _viewsMessages = new Dictionary<BaseViewsFunctionality, string>();
            _viewsMessages.Add(BaseViewsFunctionality.StartPageBaseView, basePageMessage);
            _viewsMessages.Add(BaseViewsFunctionality.PersonalAreaBaseView, personalAreaMessage);
        }

        public Dictionary<BaseViewsFunctionality, string> ViewsMessages { get => _viewsMessages; }
    }
}
