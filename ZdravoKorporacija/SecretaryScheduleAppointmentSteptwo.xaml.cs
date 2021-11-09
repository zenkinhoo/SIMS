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
using Bolnica;
using Bolnica.Model;
using Bolnica.Repository;
using Bolnica.Controller;

namespace Bolnica
{
    public partial class SecretaryScheduleAppointmentSteptwo : Window
    {
        public DoctorRepository doctorRepository = new DoctorRepository();
        public MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
        public RoomRepository roomRepository = new RoomRepository();
        private List<Doctor> doctorss = new List<Doctor>();
        List<String> allavailableTerms = new List<String>();
        List<String> allRoom = new List<String>();
        String appointmetnType;
        Patient appointmentPatient = new Patient();
        Doctor appointmetnDoctor = new Doctor();
        public SecretaryScheduleAppointmentSteptwo(Patient p,List<DateTime> slobodniTermini,Doctor d)
        {
            InitializeComponent();
            appointmentPatient = p;
            appointmetnDoctor = d;
            infoPatient.Text = p.user.firstName + " " + p.user.lastName;
            doctorss = doctorRepository.GetAll();
            List<String> allDoctors = new List<String>();
            infoDoctor.Text = d.user.firstName + " " + d.user.lastName + " " + d.type;
            foreach (DateTime dt in slobodniTermini)
            {
                allavailableTerms.Add(Convert.ToString(dt));
            }
            slobodnitermini.ItemsSource = allavailableTerms;
            
            List<Room> rooms = roomRepository.GetAllSecretary();
            foreach (Room r in rooms)
            {
                allRoom.Add(r.name);
            }
            comboRoom.ItemsSource = allRoom ;
        }

        private void chooseOperation(object sender, RoutedEventArgs e)
        {
            comboRoom.Visibility = Visibility.Visible;
            labelRoom.Visibility = Visibility.Visible;
            appointmetnType = "Operation";
        }

        private void chooseExemination(object sender, RoutedEventArgs e)
        {
            comboRoom.Visibility = Visibility.Hidden;
            labelRoom.Visibility = Visibility.Hidden;
            appointmetnType = "Examination";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String appointmentStart = (String)slobodnitermini.SelectedValue;
            String nameRoom=(String)comboRoom.SelectedValue;
            Room rooom = new Room();
            rooom=roomRepository.GetOne(nameRoom);
            DateTime appoiStart = Convert.ToDateTime(appointmentStart);
            MedicalAppointment newmedicalAppointment = new MedicalAppointment();
            if (appointmetnType == "Examination")
            {
                newmedicalAppointment = medicalAppointmentController.ScheduleAppointment(appointmetnDoctor, appointmentPatient, appointmetnDoctor.Room, appoiStart, 0.5, 0);
            }
            else
            {
                newmedicalAppointment = medicalAppointmentController.ScheduleAppointment(appointmetnDoctor, appointmentPatient, rooom, appoiStart, 0.5, (AppointmentType)Convert.ToInt32(1));
            }
        }
    }
}
