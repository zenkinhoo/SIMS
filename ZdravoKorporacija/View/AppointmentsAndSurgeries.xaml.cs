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
using Bolnica.Controller;
using Bolnica.Repository;
using Bolnica.Model;
using System.Collections.ObjectModel;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for AppointmentsAndSurgeries.xaml
    /// </summary>
    public partial class AppointmentsAndSurgeries : Window
    {

        public AppointmentsAndSurgeries()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            AppointmentsList.ItemsSource = ListBoxAdapter.extractForAppointments(medicalAppointmentRepository.GetAll());

        }

        private void back_to_home_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Home_page(object sender, RoutedEventArgs e)
        {
            PatientHomePage php = new PatientHomePage();
            php.Show();
            this.Close();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e) //profile 
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
        }

        private void past_appointments_click(object sender, RoutedEventArgs e)
        {
            MedicalHistory mh = new MedicalHistory();
            mh.Show();
        }

        private void schedule_appointment(object sender, RoutedEventArgs e)
        {
            ScheduleAppointment scheduleAppointment = new ScheduleAppointment();
            scheduleAppointment.Show();
        }

        private void update_appointment(object sender, RoutedEventArgs e)
        {

            int indexSelected = AppointmentsList.SelectedIndex;
            int id = 0;
            int doctorId = 0;
           
            if (indexSelected != -1)
            {
                string[] app = AppointmentsList.SelectedItem.ToString().Split(' ');
                Console.WriteLine(app[0].ToString());
                id = Convert.ToInt32(app[0]);
                doctorId = Convert.ToInt32(app[1]);
                UpdateAppointment ua = new UpdateAppointment(id, doctorId);
                ua.Show();
            }
            else
            {
                MessageBox.Show("You must select an appointment to update!");

            }

        }

        private void print_click(object sender, RoutedEventArgs e)
        {
            ReportPdf r = new ReportPdf();
            r.Show();
        }

        private void delete_appointment(object sender, RoutedEventArgs e)
        {
            MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
            int index = AppointmentsList.SelectedIndex;
            if (index != -1)
            {
                medicalAppointmentController.CancelAppointmentByIndex(index);
                MessageBox.Show("Appointment successfully deleted!");
            }
            else
            {
                MessageBox.Show("You must select appointment to delete!");

            }


        }
    }
}
