using Bolnica.Controller;
using Bolnica.HelperClasses;
using Bolnica.Model;
using Bolnica.View;
using MenuNavigation.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Bolnica.ViewModels;
using Bolnica.ViewModel;
using System.Text.RegularExpressions;

namespace Bolnica.ViewModels 
{
    class CreateReminderViewModel : ZdravoKorporacija.View.Validation.ValidationsBase
    {

        
       
        #region Polja
        private InjectorPatient injector;

        public InjectorPatient Injector
        {
            get { return injector; }
            set { injector = value; }
        }
        private String name;
        private String description;
        private int period;
        private DateTime selDate;
        private String time;

        public String Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(name)); }
        }

        public String Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(nameof(description)); }
        }

        public String Time
        {
            get { return time; }
            set { time = value; OnPropertyChanged(nameof(time)); }
        }

        public int Period
        {
            get { return period; }
            set { period = value; OnPropertyChanged(nameof(period)); }
        }

        public DateTime SelDate
        {
            get { return selDate; }
            set { selDate = value; OnPropertyChanged(nameof(selDate)); }
        }

        #endregion

        #region Komande
        private RelayCommand createReminderCommand;
        public RelayCommand CreateReminderCommand
        {
            get { return createReminderCommand; }
            set
            {
                createReminderCommand = value;
            }
        }

        #endregion

        #region Akcije

        public void Executed_CreateReminderCommand(object obj)
        {

            this.Validate();
            if(this.IsValid)
            {
                string[] hoursAndMinutes = time.Split(':');
                int hours = Convert.ToInt32(hoursAndMinutes[0]);
                int mins = Convert.ToInt32(hoursAndMinutes[1]);
                DateTime reminderTime = selDate + new TimeSpan(hours, mins, 0);
                PersonalReminder p = new PersonalReminder(1, name, description, reminderTime, period, false);
                injector.PersonalReminderService.SavePersonalReminder(p);
                System.Windows.MessageBox.Show("Personal reminder successfully created!");
            }
            else
            {
                System.Windows.MessageBox.Show("You must fill all fields", "Error while creating reminder",
    (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);

            }

            //   this.Close();

        }
        public bool CanExecute_CreateReminderCommand(object obj)
        {
            return true;
        }
        #endregion
        #region Validacija
        protected override void ValidateSelf()
        {
            if(this.description==null)
            {
                this.ValidationErrors["Description"] = "you must fill all fields";
            }
            if (this.name == null)
            {
                this.ValidationErrors["Name"] = "you must fill all fields";
            }
            if (this.selDate == null)
            {
                this.ValidationErrors["SelDate"] = "you must fill all fields";
            }
            if (this.time == null)
            {
                this.ValidationErrors["Time"] = "you must fill all fields";
            }



        }

        #endregion


        #region Konstruktor
        public CreateReminderViewModel()
        {
            Injector = new InjectorPatient();
            CreateReminderCommand = new RelayCommand(Executed_CreateReminderCommand, CanExecute_CreateReminderCommand);
        }
        #endregion

    }
}
