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
using Bolnica.Controller;
using Bolnica.Repository;
using Bolnica.Model;

namespace Bolnica.ViewsSecretary
{
    public partial class AddRegularAccount : Page
    {
        private PatientController patientController = new PatientController();
        private PatientRepository patientRepository = new PatientRepository();
        String jmbg, firstname, lastname, phone, adress, username, password;
        public AddRegularAccount()
        {
            InitializeComponent();
        }
        private void View_patients(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientsPage());
        }

        private void Home_page(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }
        private void View_appointments(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentsPage());
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
        private void View_rooms(object sender, RoutedEventArgs e)
        {

        }

        private void Add_regular_account(object sender, RoutedEventArgs e)
        {
            
        }
        private void Emergency_appointment(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CreateEmergencyAppointment());
        }
        private void BulletinBoard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BulletinBoard());
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
        private void Click_add_regular_account(object sender, RoutedEventArgs e)
        {
            jmbg = jmbgPatient.Text;
            firstname = firstnamePatient.Text;
            lastname = lastnamePatient.Text;
            phone = phonePatient.Text;
            adress = adrPatient.Text;
            username = usernamePatient.Text;
            password = passPatient.Text;
            Patient np = new Patient(jmbg, 1, firstname, lastname, phone, adress, password,username,false);
            patientRepository.Save(np);
            this.NavigationService.Navigate(new PatientsPage());
        }

    }
}
