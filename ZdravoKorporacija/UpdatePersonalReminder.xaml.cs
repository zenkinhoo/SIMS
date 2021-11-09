using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.HelperClasses;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for UpdatePersonalReminder.xaml
    /// </summary>
    public partial class UpdatePersonalReminder : Window
    {
        int reminderId;
        public UpdatePersonalReminder()
        {
            InitializeComponent();
        }
        public UpdatePersonalReminder(int id)
        {
           
            InitializeComponent();
            this.reminderId = id;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            PersonalReminder personalReminder = personalReminderController.GetOnePersonalReminder(reminderId);
        
            tbReminderName.Text = personalReminder.personalReminderName.ToString();
            tbDescription.Text = personalReminder.personalReminderDescription.ToString();
            dpReminderDate.SelectedDate = Convert.ToDateTime(personalReminder.remindingTime);
            tbPeriod.Text = personalReminder.remindingPeriod.ToString();
        }
         
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            PersonalReminder personalReminder = personalReminderController.GetOnePersonalReminder(reminderId);
            try
            {
                int[] hoursAndMinutes =TextSplitter.TextBoxTimeSplitter(tbReminderTime);

                DateTime reminderTime = new DateTime(dpReminderDate.SelectedDate.Value.Year, dpReminderDate.SelectedDate.Value.Month, dpReminderDate.SelectedDate.Value.Day, hoursAndMinutes[0], hoursAndMinutes[1], 0);
                PersonalReminder p = new PersonalReminder(personalReminder.id, tbReminderName.Text.ToString(), tbDescription.Text.ToString(), reminderTime, Convert.ToInt32(tbPeriod.Text),false);
                personalReminderController.UpdatePersonalReminder(p);
                this.Close();
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
        }
      
    }
}
