using Bolnica.Model;
using Bolnica.Repository;
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
using Bolnica.ViewModel;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for MedicalHistory.xaml
    /// </summary>
    public partial class MedicalHistory : Window
    {
        int globDoctorId;
        public MedicalHistory()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
           this.DataContext = new MedicalHistoryViewModel();
        }

        private void rate_doctor_click(object sender, RoutedEventArgs e)
        {

        }

        private void rate_hospital_click(object sender, RoutedEventArgs e)
        {
            RateHospital rh = new RateHospital();
            rh.Show();
        }

        private void close_pastappointments_click_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      

        private void doctor_ratings_click(object sender, RoutedEventArgs e)
        {
            DoctorRatings dr = new DoctorRatings(globDoctorId);
            dr.Show();
        }

        private void PastAppointmentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("asd");
            string[] app = PastAppointmentsList.SelectedItem.ToString().Split(' ');
            int id = Convert.ToInt32(app[0]);
          //  globSurveyId = id;
            int idDoctor = Convert.ToInt32(app[1]);
            globDoctorId = idDoctor;
            Console.WriteLine(globDoctorId.ToString());
         //   Doctor doctor =ObjectFinder.findDoctor(idDoctor);
          //  labelDoctorName.Content = doctor.user.firstName.ToString() + " " + doctor.user.lastName.ToString();
        }
    }
}
