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
using Bolnica.Repository;
using Bolnica.Model;
using Bolnica.Controller;


namespace Bolnica
{
    public partial class AppointmentsWindow : Window
    {
        MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
        List<MedicalAppointment> medicalAppointments = new List<MedicalAppointment>();
        MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
        public AppointmentsWindow()
        {
            InitializeComponent();
            medicalAppointments = medicalAppointmentRepository.GetAll();
            lvDataBindingApp.ItemsSource = medicalAppointments;
        }

        private void updateAppointment(object sender, RoutedEventArgs e)
        {
            MedicalAppointment selectedApp = (MedicalAppointment)lvDataBindingApp.SelectedItems[0];
            ChangeAppointmentWindow c = new ChangeAppointmentWindow(selectedApp);
            c.Show();
        }
        private void deleteAppointment(object sender, RoutedEventArgs e)
        {
            MedicalAppointment deletemedical = (MedicalAppointment)lvDataBindingApp.SelectedItems[0];
            
            bool isDeleted;
            isDeleted=medicalAppointmentController.CancelAppointment(deletemedical);
        }
    }
}
