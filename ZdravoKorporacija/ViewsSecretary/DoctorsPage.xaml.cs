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
    public partial class DoctorsPage : Page
    {
        DoctorRepository doctorRepository = new DoctorRepository();
        DoctorController doctorController = new DoctorController();


        public DoctorsPage()
        {
            InitializeComponent();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            lvUsers.ItemsSource = doctors;
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
        private void delete_doctor(object sender, RoutedEventArgs e)
        {
            doctorController.Delete((Doctor)lvUsers.SelectedItems[0]);
            this.NavigationService.Navigate(new DoctorsPage());
        }
        private void details_doctor(object sender, RoutedEventArgs e)
        {
            
        }
        private void Search_doctor(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
