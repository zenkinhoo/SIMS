using Bolnica.Model;
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
using Bolnica.ViewsSecretary;
using Bolnica.View;



namespace project
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            DirectorWindow dir = new DirectorWindow();
            dir.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            // PatientWindow p = new PatientWindow();
           // p.Show();
            Login l = new Login();
           l.Show();
           this.Close();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            DoctorWindow d = new DoctorWindow();
            d.Show();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Page homePage = new HomePage();
            this.frame.NavigationService.Navigate(homePage);
               
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
