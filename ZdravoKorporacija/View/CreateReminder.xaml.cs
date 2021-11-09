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
using Bolnica.Repository;
using Bolnica.Service;
using Bolnica.HelperClasses;
using System.Windows.Forms;
using Bolnica.ViewModel;
using Bolnica.ViewModels;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for CreateReminder.xaml
    /// </summary>
    public partial class CreateReminder : Window
    {
        public string time { get; set; }
        private CreateReminderViewModel viewModel;

        public CreateReminder()
        {
            viewModel = new CreateReminderViewModel();
            InitializeComponent();
            this.DataContext = viewModel;
        }
        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
