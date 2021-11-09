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
using Bolnica.Repository;
using Bolnica.Controller;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for MakeGuestAccount.xaml
    /// </summary>
    public partial class MakeGuestAccount : Window
    {
        private PatientRepository patientRepository = new PatientRepository();
        String jmbg, firstname, lastname;
        private PatientController patientController = new PatientController();
        public MakeGuestAccount()
        {
            InitializeComponent();
        }

        private void make_guest_account(object sender, RoutedEventArgs e)
        {
            jmbg = jmbgPatient.Text;
            firstname = firstnamePatient.Text;
            lastname = lastnamePatient.Text;
            patientController.MakeGuestAccount(firstname,lastname,jmbg);
            Close();
        }
    }
}
