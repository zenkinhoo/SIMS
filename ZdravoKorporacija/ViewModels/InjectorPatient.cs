using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.ViewModels
{
    class InjectorPatient
    {
        #region Services
        private PersonalReminderService personalReminderService = new PersonalReminderService();

        public PersonalReminderService PersonalReminderService
        {
            get { return personalReminderService; }
        }

        #endregion

        #region Converter
        //nakon kreiranja klase ReminderViewmodel popunjavamo ovde
     

        #endregion

    }
}
