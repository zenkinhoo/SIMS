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
    /// Interaction logic for ViewFullMedicalCard.xaml
    /// </summary>
    public partial class ViewFullMedicalCard : Window
    {
        public ViewFullMedicalCard()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
        }

        private void recipes_click(object sender, RoutedEventArgs e)
        {
            ViewAllRecipes vr = new ViewAllRecipes();
            vr.Show();
        }

        private void hospital_treatment_click(object sender, RoutedEventArgs e)
        {
            ViewHospitalTreatments vht = new ViewHospitalTreatments();
            vht.Show();
        }

        private void special_treatment_click(object sender, RoutedEventArgs e)
        {
            ViewSpecialTreatments st = new ViewSpecialTreatments();
            st.Show();
        }

        private void anamnesis_click(object sender, RoutedEventArgs e)
        {
            ViewAnamnesis va = new ViewAnamnesis();
            va.Show();
        }
    }
}
