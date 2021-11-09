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

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for ViewMedicalCard.xaml
    /// </summary>
    public partial class ViewMedicalCard : Window
    {
        public ViewMedicalCard()
        {
            InitializeComponent();
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            PatientController patientController = new PatientController();
            Patient p = patientController.GetOne(1);
            MedicalCard medicalCard = new MedicalCard(p.user.id);
            p.medicalCard = medicalCard;
            MedicalCardController medicalCardController = new MedicalCardController();
            ListRecipes.ItemsSource = ListBoxAdapter.extractForRecipesInListBox(medicalCardController.GetAllRecipes());
            ListHospitalTreatmentRefferals.ItemsSource = ListBoxAdapter.extractForMedicalInstructionsInListBox(medicalCardController.GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType.HospitalTreatment));
            ListAnamnesis.ItemsSource = ListBoxAdapter.extractForAnamnesisInListBox(medicalCardController.GetAllAnamnesis());
            ListSpecialTreatmentRefferals.ItemsSource = ListBoxAdapter.extractForMedicalInstructionsInListBox(medicalCardController.GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType.SpecialTreatment));
            Console.WriteLine(medicalCard.Id);
        }
    }
}
