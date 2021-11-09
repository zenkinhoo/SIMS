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

namespace Bolnica
{
    public partial class ChangeAppointmentWindow : Window
    {
        private int idRoom, idDoctor, idPatient;
        private MedicalAppointment globalni = new MedicalAppointment();
        private MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
        public ChangeAppointmentWindow(MedicalAppointment maaa)
        {
            InitializeComponent();
            //changedoctor.Text = maaa.doctor.user.firstName+" "+maaa.doctor.user.lastName+" "+maaa.doctor.type;
            changedoctor.Text = Convert.ToString(maaa.doctor.user.id);
            //changepatient.Text = maaa.patient.user.firstName + " " + maaa.patient.user.lastName;
            changepatient.Text = Convert.ToString(maaa.patient.user.id);
            changeStarttime.Text = Convert.ToString(maaa.startTime);
            changeDuration.Text = Convert.ToString(maaa.durationInHoours);
            changeRoom.Text = Convert.ToString(maaa.room.id);
            globalni = maaa;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            idRoom = Convert.ToInt32(changeRoom.Text);
            idDoctor = Convert.ToInt32(changedoctor.Text);
            idPatient = Convert.ToInt32(changepatient.Text);
            String appointmentStart = changeStarttime.Text;
            DateTime changeappoiStart = Convert.ToDateTime(appointmentStart);
            // MedicalAppointment changed = new MedicalAppointment(globalni.id, idPatient, idDoctor, globalni.startTime,globalni.durationInHoours,"Exemination", idRoom);
            globalni.room.id = idRoom;
            globalni.doctor.user.id = idDoctor;
            globalni.patient.user.id = idPatient;
            globalni.startTime = changeappoiStart;
            MedicalAppointment a = new MedicalAppointment();
            a=medicalAppointmentController.UpdateAppointment(globalni);
        }
    }
}
