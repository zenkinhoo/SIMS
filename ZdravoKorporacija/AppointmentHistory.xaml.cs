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
using Bolnica.Controller;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for AppointmentHistory.xaml
    /// </summary>
    public partial class AppointmentHistory : Window
    {
        //  Patient p = new Patient("2700123321456", 1, "Lazar", "Mitrovic", "066555333", "Karadjordjeva", "1234", "zenkyff");
        int globSurveyId;
        int globDoctorId;
        public AppointmentHistory()
        {
            InitializeComponent();
        }
       
        void OnLoad(object sender, RoutedEventArgs e)
        {
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            List<MedicalAppointment> appointmentsHistory = medicalAppointmentRepository.GetAppointmentsHistory();
            List<String> appointmentInfo = extractForAppointments(appointmentsHistory);
            AppointmentHistoryList.ItemsSource = appointmentInfo;

            SurveyController surveyController = new SurveyController();
          //  List<Survey> surveys = surveyController.GetAllSurveys();
           // SurveysTest.ItemsSource = extractForSurveys(surveys);

            Survey survey = surveyController.GetHospitalSurvey();
            String surveyInfo = extractHospitalSurvey(survey);
            string[] rateComment = surveyInfo.Split(',');
            tbRateHospital.Text = rateComment[0].ToString();
            tbCommentHospital.Text = rateComment[1].ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) //popunjavanje ankete za doktora   
        {
            if (tbCommentDoctor.Text != "" && tbRateDoctor.Text != "")
            {
                Survey survey = new Survey(1, globDoctorId, tbCommentDoctor.Text.ToString(), Convert.ToInt32(tbRateDoctor.Text), SurveyType.DoctorSurvey);
                SurveyController surveyController = new SurveyController();
                surveyController.SaveSurvey(survey);
                MessageBox.Show("Anketa uspesno popunjena");
                tbCommentDoctor.Text = "";
                tbRateDoctor.Text = "";
            }
            else
            {
                MessageBox.Show("Morate popuniti anketu i dati ocenu");
            }
           

        }

        private void Button_Click(object sender, RoutedEventArgs e) //vidi sve ankete za selektovanog doktora
        {
            DoctorSurveys ds = new DoctorSurveys(globDoctorId);
            ds.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // ocenjivanje bolnice
        {
            if(AppointmentHistoryList.Items.Count>0)
            {
                if (tbCommentHospital.Text != "" && tbRateHospital.Text != "")
                {
                    Survey survey = new Survey(1, 50, tbCommentHospital.Text.ToString(), Convert.ToInt32(tbRateHospital.Text), SurveyType.HospitalSurvey);
                    SurveyController surveyController = new SurveyController();
                    surveyController.SaveSurvey(survey);
                    MessageBox.Show("Anketa uspesno popunjena");
                    tbCommentDoctor.Text = "";
                    tbRateDoctor.Text = "";
                }
                else
                {
                    MessageBox.Show("Morate popuniti anketu i dati ocenu");
                }
            }
            else
            {
                MessageBox.Show("da biste popunili anketu morate imati bar 1 pregled");
            }
           
        }

        private void AppointmentHistoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] app = AppointmentHistoryList.SelectedItem.ToString().Split(' ');
            int id = Convert.ToInt32(app[0]);
            globSurveyId = id;
            int idDoctor = Convert.ToInt32(app[1]);
            globDoctorId = idDoctor;
            Doctor doctor = findDoctor(idDoctor);
            labelDoctorName.Content = doctor.user.firstName.ToString() + " " + doctor.user.lastName.ToString();
        }

        private List<String> extractForAppointments(List<MedicalAppointment> appointments) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> appointmentInfo = new List<string>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach (MedicalAppointment a in appointments)
            {
                String info = "";
                info += a.id.ToString() + " ";
                foreach (Doctor d in doctors)
                {
                    if (d.user.id == a.doctor.user.id)
                    {
                        info += d.user.id + " " + d.user.firstName + " " + d.user.lastName;
                    }
                }
                info += " " + a.startTime.ToString();
                appointmentInfo.Add(info);
            }
            return appointmentInfo;
        }
        private List<String> extractForSurveys(List<Survey> surveys) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> surveyInfo = new List<string>();

            SurveyRepository surveyRepository = new SurveyRepository();
            surveys = surveyRepository.GetAllSurveys();

            foreach(Survey s in surveys)
            {
                string temp = "";
                temp += s.id.ToString() + " " + s.doctorId.ToString() + " " + s.surveyContent.ToString() + " " + s.assessment.ToString();
                surveyInfo.Add(temp);
            }
            return surveyInfo;
        }

        private String extractHospitalSurvey(Survey survey) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            String surveyInfo = "";
            surveyInfo +=survey.assessment.ToString() + "," + survey.surveyContent.ToString();
            return surveyInfo;
        }

        public Doctor findDoctor(int id)
        {
            Doctor doctorFound = new Doctor();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = doctorRepository.GetAll();
            foreach (Doctor d in doctors)
            {
                if (d.user.id == id)
                {
                    doctorFound = d;
                    break;
                }
            }
            return doctorFound;
        }

        
    }
}
