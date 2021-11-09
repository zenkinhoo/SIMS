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
using Bolnica.Repository;
using Bolnica.Controller;
using Bolnica.Model;
using Bolnica;
using Bolnica.ViewsSecretary;

namespace project
{
    public partial class SecretaryWindow : Window
    {
        private PatientRepository patientRepository;
        private PatientController patientController;
        List<Patient> patients = new List<Patient>();
        public SecretaryWindow()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            patientRepository = new PatientRepository();
            patients = patientRepository.GetAll();
            lvDataBinding.ItemsSource = patients;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Patient deletePatient = (Patient)lvDataBinding.SelectedItems[0];
            patients.Remove(deletePatient);
            lvDataBinding.Items.Refresh();
            bool isDeleted;
            patientController = new PatientController();
            isDeleted = patientController.Delete(deletePatient);
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            RegisterPatientWindow r = new RegisterPatientWindow();
            r.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            PatientChangeWindow pcw = new PatientChangeWindow(selectedPatient);
            pcw.Show();
        }
        private void guest_account(object sender, RoutedEventArgs e)
        {
            MakeGuestAccount mga = new MakeGuestAccount();
            mga.Show();
        }
        private void fill_informations(object sender, RoutedEventArgs e)
        {
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            PatientChangeWindow pcw = new PatientChangeWindow(selectedPatient);
            pcw.Show();
        }
        private void check_allergens(object sender, RoutedEventArgs e)
        {/*
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            AllergensWindow aw = new AllergensWindow(selectedPatient);
            aw.Show();*/
        }
        private void check_appointments(object sender, RoutedEventArgs e)
        {
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            SecretaryScheduleAppointments csa = new SecretaryScheduleAppointments(selectedPatient);
            csa.Show();
        }
        private void allAppointments(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow aw = new AppointmentsWindow();
            aw.Show();
        }
        private void proba(object sender, RoutedEventArgs e)
        {
            Page homePage = new HomePage();
            this.frame.NavigationService.Navigate(homePage);
            /*proba p = new proba();
            p.Show();*/
        }
    }
}
