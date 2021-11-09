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
using System.Windows.Forms;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for RateDoctor.xaml
    /// </summary>
    public partial class RateDoctor : Window
    {
        public string rate { get; set; }

        int globDoctorId;
        public RateDoctor()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public RateDoctor(int id)
        {
            InitializeComponent();
            this.globDoctorId = id;
          this.DataContext = this;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            DoctorRepository doctorRepository = new DoctorRepository();
            Doctor doc = doctorRepository.GetOne(globDoctorId);
            labelName.Content = doc.user.firstName.ToString();
            labelSurname.Content = doc.user.lastName.ToString();
            labelSpecialty.Content = doc.type.ToString();
        }

            private void cancel_rating(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void rate_doctor(object sender, RoutedEventArgs e)
        {
            if (tbComment.Text != "" && tbRate.Text != "")
            {
                Survey survey = new Survey(1, globDoctorId, tbComment.Text.ToString(), Convert.ToInt32(tbRate.Text), SurveyType.DoctorSurvey);
                SurveyController surveyController = new SurveyController();
                surveyController.SaveSurvey(survey);
              //  MessageBox.Show("Anketa uspesno popunjena");
                System.Windows.MessageBox.Show("Survey successfully filled", "Survey success", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
                tbComment.Text = "";
                tbRate.Text = "";
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("You must fill all fields!", "Survey fail", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);

            }
        }
    }
}
