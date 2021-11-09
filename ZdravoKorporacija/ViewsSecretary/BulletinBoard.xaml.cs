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
using Bolnica.Repository;
using Bolnica.Model;
using Bolnica.Controller;

namespace Bolnica.ViewsSecretary
{
    public partial class BulletinBoard : Page
    {
        AnnouncementRepository announcementRepository = new AnnouncementRepository();
        AnnouncementController announcementController = new AnnouncementController();
        List<Announcement> announcements = new List<Announcement>();
        public BulletinBoard()
        {
            InitializeComponent();
            announcements = announcementRepository.GetAll();
            lvAnnouncement.ItemsSource = announcements;
        }
        private void view_details_announcement(object sender, RoutedEventArgs e)
        {
            Announcement announcement = (Announcement)lvAnnouncement.SelectedItems[0];
            this.NavigationService.Navigate(new DetailsAnnouncement(announcement));
        }
        private void add_announcement(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddAnnouncement());
        }
        private void delete_announcement(object sender, RoutedEventArgs e)
        {
            Announcement announcement = (Announcement)lvAnnouncement.SelectedItems[0];
            announcementController.Delete(announcement);
            this.NavigationService.Navigate(new BulletinBoard());
        }
        private void Home_page(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }
        private void View_appointments(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentsPage());
        }
        private void View_profile(object sender, RoutedEventArgs e)
        {

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
        private void Emergency_appointment(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CreateEmergencyAppointment());
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        private void View_BulletinBoard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BulletinBoard());
        }
        public void View_patients(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new PatientsPage());
        }
    }

}
