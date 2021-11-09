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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bolnica.Model;

namespace Bolnica.ViewsSecretary
{
    public partial class DetailsPatient : Page
    {
        Patient selected = new Patient();
        public DetailsPatient(Patient p)
        {
            InitializeComponent();
            jmbgPatientchange.Content = p.user.jmbg;
            firstnamePatientchange.Content = p.user.firstName;
            lastnamePatientchange.Content = p.user.lastName;
            usernamePatientchange.Content = p.user.username;
            passPatientchange.Content = p.user.password;
            selected = p;
        }
        private void Make_changes_patient(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChangePatient(selected));
        }
        private void Home_page(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }
        private void View_appointments(object sender, RoutedEventArgs e)
        {

        }
        private void View_profile(object sender, RoutedEventArgs e)
        {

        }
        private void Log_out(object sender, RoutedEventArgs e)
        {

        }
        private void View_graphs(object sender, RoutedEventArgs e)
        {

        }
        private void New_patients(object sender, RoutedEventArgs e)
        {

        }
        private void Emergency_appointment(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CreateEmergencyAppointment());
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = new_patient_register.SelectedValue.ToString();
            if (selected == "System.Windows.Controls.ComboBoxItem: Guest account")
            {
                this.NavigationService.Navigate(new GuestAccountPage());
            }
            else
            {
                this.NavigationService.Navigate(new AddRegularAccount());
            }
        }
        private void View_rooms(object sender, RoutedEventArgs e)
        {

        }
    }
}
