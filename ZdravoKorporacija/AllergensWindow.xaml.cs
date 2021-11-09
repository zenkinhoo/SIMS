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
using Bolnica.Model;
using System.Windows.Shapes;
using Bolnica.Repository;
using Bolnica.Controller;

namespace Bolnica
{/*
    public partial class AllergensWindow : Window
    {
        MedicalCardController medicalCardController = new MedicalCardController();
        MedicalCardRepository medicalCardRepository = new MedicalCardRepository();
        List<MedicalCard> medicalCards = new List<MedicalCard>();
        Patient selectedPatient = new Patient();
        public AllergensWindow(Patient p)
        {
            InitializeComponent();
            selectedPatient = p;
            patient.Text = p.user.firstName +" "+ p.user.lastName;
            medicalCards = medicalCardRepository.GetAll();

            lvDataBinding.ItemsSource = medicalCards;
            foreach(MedicalCard m in medicalCards)
            {
                if (m.patient.user.id == p.user.id)
                {
                    AllAlergens.Text = m.alergens;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String changedAllergens="";
            changedAllergens= AllAlergens.Text;
            medicalCardController.changeAlergens(selectedPatient,changedAllergens,"");
        }
    }*/
}
