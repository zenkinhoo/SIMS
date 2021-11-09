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
using Bolnica.Repository;
namespace project
{
    /// <summary>
    /// Interaction logic for RegisterPatientWindow.xaml
    /// </summary>
    public partial class RegisterPatientWindow : Window
    {
        private PatientRepository patientRepository = new PatientRepository();
        String jmbg, firstname, lastname, phone, adress, username, password;
        public RegisterPatientWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            jmbg = jmbgPatient.Text;
            firstname = firstnamePatient.Text;
            lastname = lastnamePatient.Text;
            phone = phonePatient.Text;
            adress = adrPatient.Text;
            username = usernamePatient.Text;
            password = passPatient.Text;
            Patient np = new Patient(jmbg, 1, firstname, lastname, phone, adress, username, password,false);
            patientRepository.Save(np);
            Close();
        }
    }
}
