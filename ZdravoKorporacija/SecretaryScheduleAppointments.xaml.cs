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
using Bolnica.Service;
using Bolnica.Controller;

namespace Bolnica
{
    public partial class SecretaryScheduleAppointments : Window
    {
        public DoctorRepository doctorRepository = new DoctorRepository();
        private List<Doctor> doctorss = new List<Doctor>();
        private Doctor doctorForAppointment = new Doctor();
        private List<DateTime> slobodniTermini = new List<DateTime>();
        public Patient selected = new Patient();
        
        private MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
        public SecretaryScheduleAppointments() { }
        
        public SecretaryScheduleAppointments(Patient selectedPatient)
        {
            InitializeComponent();
            dataPatient.Text = selectedPatient.user.firstName + " " + selectedPatient.user.lastName;
            doctorRepository = new DoctorRepository();
            doctorss = doctorRepository.GetAll();

            List<String> allDoctors=new List<String>();
            List<DateTime> slobodniTermini = new List<DateTime>();
            foreach (Doctor d in doctorss)
            {
                allDoctors.Add(d.user.firstName+" "+d.user.lastName+" "+d.type);
            }
            combo.ItemsSource = allDoctors;
            selected = selectedPatient;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime start = (DateTime)startTime.SelectedDate;
            String sati = startTimeHours.Text;
            String n = start.Month + "/" + start.Day + "/" + start.Year + " " + sati;
            DateTime startPoint = Convert.ToDateTime(n);

            String satiend = endTimeHours.Text;
            String m = start.Month + "/" + start.Day + "/" + start.Year + " " + satiend;
            DateTime endPoint = Convert.ToDateTime(m);

            String doctor = combo.Text;
            String selectedRadioButton;

            bool isChecked = (bool)prvi.IsChecked;
            if (isChecked)
                selectedRadioButton = (String)prvi.Content;
            else
                selectedRadioButton = (String)drugi.Content;

            String[] delovi = doctor.Split(' ');
            Doctor nadjenDoctor = doctorRepository.GetOneByFirstNameLastNameAndType(delovi[0], delovi[1], delovi[2]);
            doctorForAppointment = nadjenDoctor;
            slobodniTermini = medicalAppointmentController.FindFreeTerms(startPoint,endPoint, nadjenDoctor);
            if (slobodniTermini.Count==0)
            {
                MessageBox.Show("doctor is not available in required interval");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryScheduleAppointmentSteptwo sas = new SecretaryScheduleAppointmentSteptwo(selected, slobodniTermini, doctorForAppointment);
            sas.Show();
        }
    }
}
