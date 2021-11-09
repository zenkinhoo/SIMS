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
using Bolnica.Repository;
using Bolnica.Controller;
using System.Windows.Forms;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for Reminder.xaml
    /// </summary>
    public partial class Reminder : Window
    {
        public Reminder()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            PersonalReminderList.ItemsSource = ListBoxAdapter.extractForPersonalReminderInListBox(personalReminderController.GetAllPersonalReminders());
            personalReminderController.remindAllPatients();
        }

        private void update_reminder(object sender, RoutedEventArgs e)
        {
            UpdateReminder ur = new UpdateReminder(calculateIdFromListBox(PersonalReminderList));
            ur.Show();
        }

        private void back_to_home(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void delete_reminder(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            personalReminderController.DeletePersonalReminderByIndex(PersonalReminderList.SelectedIndex);
            System.Windows.MessageBox.Show("Reminder successfully deleted", "Reminder success", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);

        }

        private void create_reminder(object sender, RoutedEventArgs e)
        {
            CreateReminder cr = new CreateReminder();
            cr.Show();
        }
        private int calculateIdFromListBox(System.Windows.Controls.ListBox listBox)
        {
            string[] listBoxElements = listBox.SelectedItem.ToString().Split(',');
            return Convert.ToInt32(listBoxElements[0]);
        }

    }
}
