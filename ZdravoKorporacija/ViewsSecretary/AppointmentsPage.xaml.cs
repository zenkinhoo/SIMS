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

namespace Bolnica.ViewsSecretary
{
    public partial class AppointmentsPage : Page
    {
        MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
        List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();
        public AppointmentsPage()
        {
            InitializeComponent();
            medicalAppointments = medicalAppointmentRepository.GetAll();
            medicalAppointments = medicalAppointmentRepository.GetAll();
            List<TableWrite> appointmentForTableWrite = new List<TableWrite>();
            foreach (MedicalAppointment m in medicalAppointments)
            {
                appointmentForTableWrite.Add(new TableWrite(m.id, m.doctor.user.firstName +" "+ m.doctor.user.lastName, m.patient.user.firstName + " " + m.patient.user.lastName,m.startTime));
            }
            lvAppointmnets.ItemsSource = appointmentForTableWrite;

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
        private void View_rooms(object sender, RoutedEventArgs e)
        {

        }
        public void View_patients(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientsPage());
        }
        private class TableWrite
        {
            public int Id { get; set; }
            public String firstAndLastNameDoctor { get; set; }
            public String firstAndLastNamePatient { get; set; }
            public DateTime startTime { get; set; }
            public TableWrite(int id, String doctor, String patient, DateTime date)
            {
                Id = id;
                firstAndLastNameDoctor = doctor;
                firstAndLastNamePatient = patient;
                startTime = date;
            }
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
    }
}
