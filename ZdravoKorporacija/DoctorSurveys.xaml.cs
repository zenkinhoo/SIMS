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
    /// Interaction logic for Doctor_Surveys.xaml
    /// </summary>
    public partial class DoctorSurveys : Window
    {
        public int doctorId;
        public DoctorSurveys()
        {
            InitializeComponent();
        }
        public DoctorSurveys(int id)
        {
            InitializeComponent();
            this.doctorId = id;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            Doctor doctor = findDoctor(doctorId);
            labelDoctorName.Content = doctor.user.firstName.ToString() + " " + doctor.user.lastName.ToString();
            SurveyController surveyController = new SurveyController();
            List<Survey> surveys = surveyController.GetDoctorsSurveys(doctorId);
            String surveyInfo = extractDoctorSurveys(surveys);
            tbDoctorSurveys.Text = surveyInfo;

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
        private String extractDoctorSurveys(List<Survey> surveys) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            String surveyInfo = "";
            foreach (Survey s in surveys)
            {
                String temp = "";
                temp += "Rate: " + s.assessment.ToString() + "\n" + s.surveyContent.ToString() + "\n\n\n";
                surveyInfo+= temp;
            }
            return surveyInfo;
        }
    }
}
