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
using Bolnica.Service;

namespace project
{
    /// <summary>
    /// Interaction logic for PatientChangeWindow.xaml
    /// </summary>
    public partial class PatientChangeWindow : Window
    {
        private PatientRepository patientRepository = new PatientRepository();
        private PatientService patientService = new PatientService();
        Patient patient = new Patient();
        private String jmbg, firstname, lastname, phone, adress, username, passw;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            jmbg = jmbgPatientchange.Text;
            firstname = firstnamePatientchange.Text;
            lastname = lastnamePatientchange.Text;
            phone = phonePatientchange.Text;
            adress = adrPatientchange.Text;
            username = usernamePatientchange.Text;
            passw = passPatientchange.Text;
            List<Patient> patients = patientRepository.GetAll();
            Patient pr = new Patient();
            foreach (Patient p in patients)
            {
                if (patient.user.id == p.user.id)
                {
                    pr = p;
                }
            }
            pr.user.jmbg = jmbg;
            pr.user.firstName = firstname;
            pr.user.lastName = lastname;
            pr.user.phone = phone;
            pr.user.adress = adress;
            pr.user.username = username;
            pr.user.password = passw;
            patientService.Update(pr);
            MessageBox.Show("Success change patient");
            Close();
        }

        public PatientChangeWindow(Patient p)
        {
            InitializeComponent();
            jmbgPatientchange.Text = p.user.jmbg;
            firstnamePatientchange.Text = p.user.firstName;
            lastnamePatientchange.Text = p.user.lastName;
            phonePatientchange.Text = p.user.phone;
            adrPatientchange.Text = p.user.adress;
            usernamePatientchange.Text = p.user.username;
            passPatientchange.Text = p.user.password;
            patient = p;
        }
    }
}
