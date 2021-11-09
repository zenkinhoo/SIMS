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
using System.Windows.Shapes;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.ViewModel;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for ViewSpecialTreatments.xaml
    /// </summary>
    public partial class ViewSpecialTreatments : Window
    {
        public ViewSpecialTreatments()
        {
            InitializeComponent();
            this.DataContext = new ViewSpecialTreatmentsViewModel();
        }
   

        private void close_therapy_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
