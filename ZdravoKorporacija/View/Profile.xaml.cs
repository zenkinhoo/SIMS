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

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        void OnLoad(object sender, RoutedEventArgs e)
        {
            //dani combo
            List<int> days = new List<int>();
            for(int i=1;i<=31;i++)
            {
                days.Add(i);
            }
            ComboDay.ItemsSource = days;

            //meseci combo

            List<int> months = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(i);
            }
            ComboMonth.ItemsSource = months;

            //godine
            List<int> years = new List<int>();
            for (int i = 2021; i >=1910; i--)
            {
                years.Add(i);
            }
            ComboYear.ItemsSource = years;
            MedicalRecordList.Items.Add("Recipes");
           MedicalRecordList.Items.Add("Hospital treatment referalls");
            MedicalRecordList.Items.Add("Special treatment referalls");
            MedicalRecordList.Items.Add("Anamnesis");


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PatientHomePage ph = new PatientHomePage();
            ph.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientHomePage ph = new PatientHomePage();
            ph.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void view_full_therapy_click(object sender, RoutedEventArgs e)
        {
            Therapy t = new Therapy();
            t.Show();
        }

        private void medical_record_click(object sender, RoutedEventArgs e)
        {
            ViewFullMedicalCard vmc = new ViewFullMedicalCard();
            vmc.Show();
        }
        private void back_to_home(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void notifications(object sender, RoutedEventArgs e)
        {
            Reminder r = new Reminder();
            r.Show();
        }

        private void appointments(object sender, RoutedEventArgs e)
        {
            AppointmentsAndSurgeries a = new AppointmentsAndSurgeries();
            a.Show();
         //   this.Close();
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
