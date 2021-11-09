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
using Bolnica.Model;
using Bolnica.Repository;
using Bolnica.Repository;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for proba.xaml
    /// </summary>
    public partial class proba : Window
    {
        public proba()
        {
            InitializeComponent();
        }

        private void alergeni(object sender, RoutedEventArgs e)
        {
            List<Allergen> allergens = new List<Allergen>();
            AllergenRepository allergenRepository = new AllergenRepository();
            allergens = allergenRepository.getAll();
            lvDataBinding.ItemsSource = allergens;
        }
        private void anamneze(object sender, RoutedEventArgs e)
        {
            List<Anamnesis> anamnesis = new List<Anamnesis>();
            AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
            anamnesis = anamnesisRepository.getAll();
            lvDataBindingAnamnesis.ItemsSource = anamnesis;
        }
        private void medicalcard(object sender, RoutedEventArgs e)
        {
            List<MedicalCard> medicalCards= new List<MedicalCard>();
            MedicalCardRepository medicalCardRepository = new MedicalCardRepository();
            medicalCards = medicalCardRepository.getAll();
            lvDataBindingAnamnesis_Copy.ItemsSource = medicalCards;
        }
    }
}
