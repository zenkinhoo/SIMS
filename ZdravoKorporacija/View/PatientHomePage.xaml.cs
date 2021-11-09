using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for PatientHomePage.xaml
    /// </summary>
    public partial class PatientHomePage : Window
    {
        public class AppointmentString
        {

            public string info { get; set; }

            public AppointmentString(string info)
            {
                this.info = info;
            }
        }
        private Point _dragStartPoint;
        private T FindVisualParent<T>(DependencyObject child)
            where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null)
                return null;
            T parent = parentObject as T;
            if (parent != null)
                return parent;
            return FindVisualParent<T>(parentObject);
        }

        private IList<AppointmentString> appointments = new ObservableCollection<AppointmentString>();
        public PatientHomePage()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
           

            List<String> appointmentInfo = new List<string>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            List<MedicalAppointment> apps = medicalAppointmentRepository.GetAll();
            foreach (MedicalAppointment a in apps)
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
                //  appointmentInfo.Add(info);
                appointments.Add(new AppointmentString(info));
            }
            AppointmentsList.DisplayMemberPath = "info";
            AppointmentsList.ItemsSource = appointments;
            AppointmentsList.PreviewMouseMove += ListBox_PreviewMouseMove;

            var style = new Style(typeof(ListBoxItem));
            style.Setters.Add(new Setter(ListBoxItem.AllowDropProperty, true));
            style.Setters.Add(
                new EventSetter(
                    ListBoxItem.PreviewMouseLeftButtonDownEvent,
                    new MouseButtonEventHandler(ListBoxItem_PreviewMouseLeftButtonDown)));
            style.Setters.Add(
                    new EventSetter(
                        ListBoxItem.DropEvent,
                        new DragEventHandler(ListBoxItem_Drop)));
            AppointmentsList.ItemContainerStyle = style;

            AppointmentHistoryRepository appointmentHistoryRepository = new AppointmentHistoryRepository();
           AppointmentsHistoryList.ItemsSource = ListBoxAdapter.extractForAppointments(appointmentHistoryRepository.GetAllPastAppointments());




        }
        private void ListBox_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(null);
            Vector diff = _dragStartPoint - point;
            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                var lb = sender as ListBox;
                var lbi = FindVisualParent<ListBoxItem>(((DependencyObject)e.OriginalSource));
                if (lbi != null)
                {
                    DragDrop.DoDragDrop(lbi, lbi.DataContext, DragDropEffects.Move);
                }
            }
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dragStartPoint = e.GetPosition(null);
        }

        private void ListBoxItem_Drop(object sender, DragEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                var source = e.Data.GetData(typeof(AppointmentString)) as AppointmentString;
                var target = ((ListBoxItem)(sender)).DataContext as AppointmentString;

                int sourceIndex = AppointmentsList.Items.IndexOf(source);
                int targetIndex = AppointmentsList.Items.IndexOf(target);

                Move(source, sourceIndex, targetIndex);
            }
        }

        private void Move(AppointmentString source, int sourceIndex, int targetIndex)
        {
            if (sourceIndex < targetIndex)
            {
                appointments.Insert(targetIndex + 1, source);
                appointments.RemoveAt(sourceIndex);
            }
            else
            {
                int removeIndex = sourceIndex + 1;
                if (appointments.Count + 1 > removeIndex)
                {
                    appointments.Insert(targetIndex, source);
                    appointments.RemoveAt(removeIndex);
                }
            }
        }

        private void Home_page(object sender, RoutedEventArgs e)
        {

        }

        private void AppointmentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private List<String> extractForAppointments(MedicalAppointmentRepository medicalAppointmentRepository) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> appointmentInfo = new List<string>();
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            appointments = medicalAppointmentRepository.GetAll();
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

        private void appointments_click(object sender, RoutedEventArgs e)
        {
            AppointmentsAndSurgeries a = new AppointmentsAndSurgeries();
            a.Show();
           // this.Close();
        }

        private void manage_appointments_click(object sender, RoutedEventArgs e)
        {
            AppointmentsAndSurgeries a = new AppointmentsAndSurgeries();
            a.Show();
           // this.Close();
        }

        private void reminder_click(object sender, RoutedEventArgs e)
        {
            Reminder r = new Reminder();
            r.Show();
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Tutorial t = new Tutorial();
            t.Show();
            this.Close();
        }
    }
}
