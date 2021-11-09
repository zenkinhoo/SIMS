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
    /// Interaction logic for Tutorial.xaml
    /// </summary>
    public partial class Tutorial : Window
    {
        public Tutorial()
        {
            InitializeComponent();
            myMedia.Volume = 0;
          //  myMedia.Play();

        }
        void mediaPlay(Object sender, EventArgs e)
        {
            myMedia.Play();
        }

        void mediaPause(Object sender, EventArgs e)
        {
            myMedia.Pause();
        }

        void mediaMute(Object sender, EventArgs e)
        {

            if (myMedia.Volume == 100)
            {
                myMedia.Volume = 0;
    
            }
            else
            {
                myMedia.Volume = 100;
        
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myMedia.Play();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            myMedia.Pause();
        }

        private void skip_click(object sender, RoutedEventArgs e)
        {
            PatientHomePage php = new PatientHomePage();
            php.Show();
            this.Close();
        }
    }
}
