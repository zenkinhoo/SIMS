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
using Bolnica.Repository;
using Bolnica.Controller;

namespace Bolnica.ViewsSecretary
{
    public partial class PatientsPage : Page
    {
        private PatientRepository patientRepository = new PatientRepository();
        private PatientController patientController = new PatientController();
        public PatientsPage()
        {
            InitializeComponent();
            List<Patient> patients = new List<Patient>();
            patients = patientRepository.GetAll();
            lvUsers.ItemsSource = patients;
        }
        private void Search_patient(object sender, RoutedEventArgs e)
        {
            String patientInput = firstAndLastName.Text;
            String[] splitedInput = patientInput.Split(' ');
            String findFirstName = splitedInput[0];
            String findLastName = splitedInput[1];
            Patient patientFound = patientController.FindByFirstAndLastName(findFirstName, findLastName);
            List<Patient> patients = new List<Patient>();
            patients.Add(patientFound);
            lvUsers.ItemsSource = patients;
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
        private void BulletinBoard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BulletinBoard());
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

        private void delete_patient(object sender, RoutedEventArgs e)
        {
            Patient patient= (Patient)lvUsers.SelectedItems[0];
            bool b=patientController.Delete(patient);
            this.NavigationService.Navigate(new PatientsPage());
        }
        private void details_patient(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DetailsPatient((Patient)lvUsers.SelectedItems[0]));
        }
    }
}
