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
using Bolnica.Controller;
using Bolnica.Model;
using Bolnica;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for PersonalReminders.xaml
    /// </summary>
    public partial class PersonalReminders : Window
    {
        public PersonalReminders()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            ListPersonalReminders.ItemsSource = ListBoxAdapter.extractForPersonalReminderInListBox(personalReminderController.GetAllPersonalReminders());
            personalReminderController.remindAllPatients();
        }

        private void delete_personalReminder(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            personalReminderController.DeletePersonalReminderByIndex(ListPersonalReminders.SelectedIndex);
        }

        private void update_personalReminder(object sender, RoutedEventArgs e)
        {
            UpdatePersonalReminder upr = new UpdatePersonalReminder(calculateIdFromListBox(ListPersonalReminders));
            upr.Show();
        }


        private int calculateIdFromListBox(ListBox listBox)
        {
            string [] listBoxElements = listBox.SelectedItem.ToString().Split(',');
            return Convert.ToInt32(listBoxElements[0]);
        }

       
    }
}
