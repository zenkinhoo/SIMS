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

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for DoctorRatings.xaml
    /// </summary>
    public partial class DoctorRatings : Window
    {
        public int doctorId;
        public DoctorRatings()
        {
            InitializeComponent();
        }
        public DoctorRatings(int doctorId)
        {
            InitializeComponent();
            this.doctorId = doctorId;

        }

        void OnLoad(object sender, RoutedEventArgs e)
        {
           
            DoctorRepository doctorRepository = new DoctorRepository();
            Doctor doc = doctorRepository.GetOne(doctorId);
            labelName.Content = doc.user.firstName.ToString();
            labelSurname.Content = doc.user.lastName.ToString();
            labelSpecialty.Content = doc.type.ToString();
            labelNameComments.Content = doc.user.firstName.ToString() + "'s comments";
            labelNameRatings.Content = doc.user.firstName.ToString() + "'s ratings";
            labelNameOverall.Content = doc.user.firstName.ToString() + "'s overall ratings";
            SurveyRepository surveyRepository = new SurveyRepository();
            DoctorRatingsList.ItemsSource = ListBoxAdapter.extractDoctorSurveysRatings(surveyRepository.GetDoctorsSurveys(doctorId));
            DoctorCommentList.ItemsSource = ListBoxAdapter.extractDoctorSurveysComments(surveyRepository.GetDoctorsSurveys(doctorId));

        }

        private void close_doctor_ratings(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rate_doctor(object sender, RoutedEventArgs e)
        {
            RateDoctor rd = new RateDoctor(doctorId);
            rd.Show();
        }
    }
}
