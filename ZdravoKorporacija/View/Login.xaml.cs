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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        public string FirstName


        {

            get { return _FirstName; }


            set

            {

                if (_FirstName == value) return;

                _FirstName = value;


            }

        }



        private string _FirstName;
        public void ChangeText(object sender, RoutedEventArgs e)

        {
            FirstName = "test-second";
        }




        private void LoginUser(object sender, RoutedEventArgs e)

        {

            if (tbUser.Text.Equals("lazar") && tbPass.Password.Equals("123123"))

            {
               //  PatientHomePage ph = new PatientHomePage();
               //  ph.Show();
               Tutorial t = new Tutorial();
                t.Show();
                this.Close();
                TestText.Text = ("");
            }
            else

            {
                TestText.Text = ("Username or password is not correct!");
            }

        }

      
    }
}
