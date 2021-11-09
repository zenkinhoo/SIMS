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
using Bolnica.Controller;
using Bolnica.Controller;

namespace Bolnica.ViewsSecretary
{
    public partial class CreateEmergencyAppointment : Page
    {
        PatientController patientController = new PatientController();
        DoctorController doctorController = new DoctorController();
        Patient emergencyPatient = new Patient();
        MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
        String appointmetnType;
        double DURATION_EMERGENCY_APPOINTMNET_IN_HOURS = 1;
        int DEFAULT_ID = 1;//prilikom save metode formira se odgovarajuci id
        int EMERGENCY_ROOM = 4;
        public CreateEmergencyAppointment()
        {
            InitializeComponent();
        }
        private void View_profile(object sender, RoutedEventArgs e)
        {

        }
        private void View_patients(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientsPage());
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new GuestAccountPage());

        }
        private void View_appointments(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentsPage());
            
        }

        private void BulletinBoard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BulletinBoard());
        }
        private void Home_page(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }
        private void Is_patient_exist(object sender, RoutedEventArgs e)
        {
            String searchPatient = firstAndLastName.Text;
            String[] partSearchPatient = searchPatient.Split(' ');
            if (patientController.IsPatientExist(partSearchPatient[0],partSearchPatient[1])==false) {
                this.NavigationService.Navigate(new GuestAccountPage());
            }
            emergencyPatient = patientController.FindByFirstAndLastName(partSearchPatient[0], partSearchPatient[1]);
        }
        private void chooseOperation(object sender, RoutedEventArgs e)
        {
            appointmetnType = "Operation";
        }

        private void chooseExemination(object sender, RoutedEventArgs e)
        {
            appointmetnType = "Examination";
        }
        private void Schedule_appointment(object sender, RoutedEventArgs e)
        {
            Doctor freeDoctor = new Doctor();
            freeDoctor = medicalAppointmentController.findFreeDoctorAccordingType(doctorType.Text);
            if (freeDoctor == null) { MessageBox.Show("nema slobodnih doktora");return; }
            MedicalAppointment newMedicalAppointment;
            if (appointmetnType == "Operation")
            {
                newMedicalAppointment = new MedicalAppointment(DEFAULT_ID, emergencyPatient.user.id, freeDoctor.user.id, DateTime.Now, DURATION_EMERGENCY_APPOINTMNET_IN_HOURS, (AppointmentType)Convert.ToInt32(1), EMERGENCY_ROOM);
            }
            else
            {
                newMedicalAppointment = new MedicalAppointment(DEFAULT_ID, emergencyPatient.user.id, freeDoctor.user.id, DateTime.Now, DURATION_EMERGENCY_APPOINTMNET_IN_HOURS, (AppointmentType)Convert.ToInt32(0), EMERGENCY_ROOM);
            }
            medicalAppointmentController.scheduleEmergencyAppointment(newMedicalAppointment);
            this.NavigationService.Navigate(new AppointmentsPage());
        }
        private void Emergency_appointment(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CreateEmergencyAppointment());
        }
        private void ComboBo_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
