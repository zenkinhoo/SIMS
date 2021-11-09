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
using System.Windows.Forms;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for UpdateReminder.xaml
    /// </summary>
    public partial class UpdateReminder : Window
    {
        int reminderId;
        public string time { get; set; }
        public UpdateReminder()
        {
            InitializeComponent();
        }
        public UpdateReminder(int id)
        {
            InitializeComponent();
            this.reminderId = id;
            this.DataContext = this;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            PersonalReminder personalReminder = personalReminderController.GetOnePersonalReminder(reminderId);

            tbReminderName.Text = personalReminder.personalReminderName.ToString();
            tbReminderDescription.Text = personalReminder.personalReminderDescription.ToString();
            dpReminderDate.SelectedDate = Convert.ToDateTime(personalReminder.remindingTime);
            tbPeriod.Text = personalReminder.remindingPeriod.ToString();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void update_reminder(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            PersonalReminder personalReminder = personalReminderController.GetOnePersonalReminder(reminderId);
            try
            {
                int[] hoursAndMinutes = TextSplitter.TextBoxTimeSplitter(tbReminderTime);

                DateTime reminderTime = new DateTime(dpReminderDate.SelectedDate.Value.Year, dpReminderDate.SelectedDate.Value.Month, dpReminderDate.SelectedDate.Value.Day, hoursAndMinutes[0], hoursAndMinutes[1], 0);
                PersonalReminder p = new PersonalReminder(personalReminder.id, tbReminderName.Text.ToString(), tbReminderDescription.Text.ToString(), reminderTime, Convert.ToInt32(tbPeriod.Text), false);
                personalReminderController.UpdatePersonalReminder(p);
                this.Close();
            }
            catch (FormatException f)
            {
                System.Windows.MessageBox.Show("You must fill all fields", "Error", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }
    }
}
