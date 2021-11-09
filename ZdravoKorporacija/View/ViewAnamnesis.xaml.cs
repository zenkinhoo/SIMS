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
using System.Collections.ObjectModel;
using project;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for ViewAnamnesis.xaml
    /// </summary>
    public partial class ViewAnamnesis : Window , ICloseable
    {
        public ViewAnamnesis()
        {
            InitializeComponent();
            this.DataContext = new ViewAnamnesisViewModel();
          //  LoadAnamnesis();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /*    void OnLoad(object sender, RoutedEventArgs e)
            {
                PatientController patientController = new PatientController();
                Patient p = patientController.GetOne(1);
                MedicalCard medicalCard = new MedicalCard(p.user.id);
                p.medicalCard = medicalCard;
                MedicalCardController medicalCardController = new MedicalCardController();
                ListAnamnesis.ItemsSource = ListBoxAdapter.extractForAnamnesisInListBox(medicalCardController.GetAllAnamnesis());

            }
            private void close_therapy_click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }*/
    }
}
