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
using Bolnica.Controller;

namespace Bolnica.ViewsSecretary
{
    public partial class ChangePatient : Page
    {
        PatientController patientController = new PatientController();
        Patient patient = new Patient();
        public ChangePatient(Patient p)
        {
            InitializeComponent();
            jmbgPatientchange.Text = p.user.jmbg;
            firstnamePatientchange.Text = p.user.firstName;
            lastnamePatientchange.Text = p.user.lastName;
            usernamePatientchange.Text = p.user.username;
            passPatientchange.Text = p.user.password;
            patient = p;
        }
        private void Submit_changes(object sender, RoutedEventArgs e)
        {
            patient.user.firstName = firstnamePatientchange.Text;
            patient.user.lastName = lastnamePatientchange.Text;
            patient.user.username = usernamePatientchange.Text;
            patient.user.password = passPatientchange.Text;
            patient.user.jmbg = jmbgPatientchange.Text;
            patientController.UpdatePatient(patient);
            this.NavigationService.Navigate(new PatientsPage());
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
