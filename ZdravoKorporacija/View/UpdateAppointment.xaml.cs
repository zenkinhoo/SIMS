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
using Bolnica.Service;
using Bolnica.Repository;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for UpdateAppointment.xaml
    /// </summary>
    public partial class UpdateAppointment : Window
    {
        int appointmentId;
        int doctorId;
        bool timeTriggered;
       
        public UpdateAppointment()
        {
            InitializeComponent();
        }
        public UpdateAppointment(int appointmentId,int doctorId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.doctorId = doctorId;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {

        }

        private void find_free_terms(object sender, RoutedEventArgs e)
        {
            timeTriggered = false;
            MedicalAppointmentService medicalAppointmentService = new MedicalAppointmentService();
            DoctorSchedulesRepository doctorSchedulesRepository = new DoctorSchedulesRepository();
            List<DoctorSchedules> doctorSchedules = doctorSchedulesRepository.GetAll();
            List<String> bookedTerms = new List<string>(); //zauzeti termini doktora u zadatom vremenskom intervalu
            List<String> allBookedTerms = new List<String>(); //pronalazi sve zauzete termine za doktora
            string[] startHoursMinutes = tb_startTime.Text.Split(':');
            int startHours = Convert.ToInt32(startHoursMinutes[0]);
            int startMinutes = Convert.ToInt32(startHoursMinutes[1]);

            if (startHours > 12)
            {
                startHours -= 12;
            }

            string[] endHoursMinutes = tb_endTime.Text.Split(':');
            int endHours = Convert.ToInt32(endHoursMinutes[0]);
            int endMinutes = Convert.ToInt32(endHoursMinutes[1]);

            if (endHours > 12)
            {
                endHours -= 12;
            }

            //racunamo vreme u sekundama

            double startSeconds = Convert.ToDouble((startHours * 3600) + startMinutes * 60);
            double endSeconds = Convert.ToDouble(endHours * 3600 + endMinutes * 60);


            //  string[] pomDoc = ComboChoice.SelectedItem.ToString().Split(' ');
            DoctorRepository doctorRepository = new DoctorRepository();
            Doctor doctor = doctorRepository.GetOne(doctorId);

            //   int doctorId = Convert.ToInt32(pomDoc[0]);
            String doctorName = doctor.user.firstName;
            String doctorLastName = doctor.user.lastName;
            DateTime selectedDate = (DateTime)DatePick.SelectedDate;

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("You cant select day earlier than today");
                return;
            }



            foreach (DoctorSchedules ds in doctorSchedules)
            {
                string bookedTerm = "";
                string[] dateTime = ds.startTime.ToString().Split(' ');
                DateTime currentDate = Convert.ToDateTime(dateTime[0]).Date;



                if (doctorId == ds.idDoctor && selectedDate.Equals(currentDate)) //ukoliko se poklapaju doktori i datumi nastavicemo da uporedjujemo vremena
                {
                    //sada trazimo vvreme pocetka

                    string[] currentStartTime = dateTime[1].Split(':');
                    int currentStartHours = Convert.ToInt32(currentStartTime[0]);
                    int currentStartMinutes = Convert.ToInt32(currentStartTime[1]);


                    //vreme kraja pregleda
                    string[] endDateTime = ds.endTime.ToString().Split(' ');
                    string[] currentEndTime = endDateTime[1].Split(':');
                    int currentEndHours = Convert.ToInt32(currentEndTime[0]);
                    int currentEndMinutes = Convert.ToInt32(currentEndTime[1]);

                    //konvertujemo vreme iz liste u sekunde

                    double currentStartSeconds = Convert.ToDouble((currentStartHours * 3600) + currentStartMinutes * 60);
                    double currentEndSeconds = Convert.ToDouble(currentEndHours * 3600 + currentEndMinutes * 60);

                    if (startSeconds <= currentStartSeconds && endSeconds >= currentEndSeconds)
                    {
                        // Doctor doc = findDoctor(doctorId);
                        bookedTerm += currentStartHours.ToString() + ":" + currentStartMinutes.ToString() + "," + currentEndHours.ToString() + ":" + currentEndMinutes.ToString();
                    }
                    if (bookedTerm != "")
                    {
                        bookedTerms.Add(bookedTerm);
                    }

                }
            }
            List<String> freeTerms = medicalAppointmentService.FindFreeTerms(tb_startTime.Text, tb_endTime.Text, bookedTerms, timeTriggered);
            List<String> finalFreeTerms = new List<String>();

            foreach (String ft in freeTerms.ToList())
            {
                String additionalData = "";
                additionalData += doctorId.ToString() + " " + doctorName.ToString() + " " + doctorLastName.ToString() + " ";
                additionalData += ft.ToString();
                finalFreeTerms.Add(additionalData);
            }

            ListFreeTerms.ItemsSource = finalFreeTerms;

            List<String> freeTermsDoctorPriority = new List<String>();
            List<String> finalFreeTermsDoctorPriority = new List<String>();

            //ako je lista termina prazna na scenu stupaju prioriteti

            if (!finalFreeTerms.Any() && (bool)radioDoctor.IsChecked)
            {
                // ListFreeTerms.ItemsSource = null;
                //MessageBox.Show("Sada bi trebalo da prioritet stupi na scenu");
                foreach (DoctorSchedules ds in doctorSchedules)
                {
                    string bookedTerm = "";
                    string[] dateTime = ds.startTime.ToString().Split(' ');
                    DateTime currentDate = Convert.ToDateTime(dateTime[0]).Date;
                    if (doctorId == ds.idDoctor && selectedDate.Equals(currentDate)) //ukoliko se poklapaju doktori i datumi nastavicemo da uporedjujemo vremena
                    {
                        //sada trazimo vvreme pocetka

                        string[] currentStartTime = dateTime[1].Split(':');
                        int currentStartHours = Convert.ToInt32(currentStartTime[0]);
                        int currentStartMinutes = Convert.ToInt32(currentStartTime[1]);


                        //vreme kraja pregleda
                        string[] endDateTime = ds.endTime.ToString().Split(' ');
                        string[] currentEndTime = endDateTime[1].Split(':');
                        int currentEndHours = Convert.ToInt32(currentEndTime[0]);
                        int currentEndMinutes = Convert.ToInt32(currentEndTime[1]);

                        //konvertujemo vreme iz liste u sekunde

                        double currentStartSeconds = Convert.ToDouble((currentStartHours * 3600) + currentStartMinutes * 60);
                        double currentEndSeconds = Convert.ToDouble(currentEndHours * 3600 + currentEndMinutes * 60);

                        bookedTerm += currentStartHours.ToString() + ":" + currentStartMinutes.ToString() + "," + currentEndHours.ToString() + ":" + currentEndMinutes.ToString();

                        if (bookedTerm != "")
                        {
                            allBookedTerms.Add(bookedTerm);
                        }

                    }
                }
                freeTermsDoctorPriority = medicalAppointmentService.generateIfDoctorPriority(tb_startTime.Text, tb_endTime.Text, allBookedTerms);
                foreach (String ft in freeTermsDoctorPriority.ToList())
                {
                    String additionalData = "";
                    additionalData += doctorId.ToString() + " " + doctorName.ToString() + " " + doctorLastName.ToString() + " ";
                    additionalData += ft.ToString();
                    if (!allBookedTerms.Contains(ft))
                    {
                        finalFreeTermsDoctorPriority.Add(additionalData);
                    }

                }

                ListFreeTerms.ItemsSource = finalFreeTermsDoctorPriority;
            }
            else if (!finalFreeTerms.Any() && (bool)radioTime.IsChecked)
            {
                List<String> freeTermsTimePriority = new List<String>();
                List<String> finalFreeTermsTimePriority = new List<String>();
                //vreme je prioritet
                List<String> doctorNames = generateDoctorNames();
                foreach (String doc in doctorNames) //uzecemo slobodne termine od drugog slobodnog doktora
                {
                    string[] pomDoctor = doc.Split(' ');
                    int docId = Convert.ToInt32(pomDoctor[0]);
                    String docName = pomDoctor[1];
                    String docLastName = pomDoctor[2];

                    if (doctorId != docId) //da ne uzmemo prethodnog doktora
                    {

                        foreach (DoctorSchedules ds in doctorSchedules) //na kraju ce pronaci sve zauzete termine za zadatog doktora
                        {
                            string bookedTerm = "";
                            string[] dateTime = ds.startTime.ToString().Split(' ');
                            DateTime currentDate = Convert.ToDateTime(dateTime[0]).Date;
                        }

                        timeTriggered = true;
                        freeTermsTimePriority = medicalAppointmentService.FindFreeTerms(tb_startTime.Text, tb_endTime.Text, bookedTerms, timeTriggered);

                        foreach (String ft in freeTermsTimePriority.ToList())
                        {
                            String additionalData = "";
                            additionalData += docId.ToString() + " " + docName.ToString() + " " + docLastName.ToString() + " ";
                            additionalData += ft.ToString();
                            finalFreeTermsTimePriority.Add(additionalData);
                        }

                        ListFreeTerms.ItemsSource = finalFreeTermsTimePriority;
                        if (finalFreeTermsTimePriority.Any()) //ako je pronasao za jednog doktora,ne trazi dalje
                        {
                            break;
                        }
                    }
                }
            }
        }
        public List<String> generateDoctorNames()
        {
            List<String> doctorNames = new List<String>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = doctorRepository.GetAll();
            foreach (Doctor doc in doctors)
            {
                doctorNames.Add(doc.user.firstName);
            }
            return doctorNames;
        }

        private void close_update(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void update_term(object sender, RoutedEventArgs e)
        {
            PatientController patientController = new PatientController();
            Patient p = patientController.GetOne(1);
            int indexSelected = ListFreeTerms.SelectedIndex;
            if (indexSelected != -1)
            {
                string[] app = ListFreeTerms.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(app[0]);
                MedicalAppointment appointment = ObjectFinder.findAppointment(id);
                Doctor doctor = ObjectFinder.findDoctor(doctorId);
                //     DateTime tempDate = (DateTime)DatePick.SelectedDate;
                //sada trazimo podatke za vreme
                string[] doc = ListFreeTerms.SelectedItem.ToString().Split(' ');
                //   int id = Convert.ToInt32(doc[0]);
                //    Doctor doctor = findDoctor(id);
                //    
                DateTime tempDate = (DateTime)DatePick.SelectedDate;
                string[] hoursMins = doc[3].Split(':');
                int hours = Convert.ToInt32(hoursMins[0]);
                string[] minute = hoursMins[1].Split('-');
                int minutes = Convert.ToInt32(minute[0]);

                DateTime fullDate = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, hours, minutes, 0);

                MedicalAppointment ma = new MedicalAppointment(id, p.user.id, doctorId, fullDate, Convert.ToDouble(Duration.Text), AppointmentType.Examination, doctor.room.id);

                MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();



                if (fullDate < DateTime.Today)
                {
                    MessageBox.Show("You can't select an earlier day than today!");
                    return;
                }
                if ((fullDate - appointment.startTime).Days > 2)
                {
                    MessageBox.Show("Mozete pomeriti za najvise 2 dana");
                    return;
                }
                if ((appointment.startTime - DateTime.Today).Days <= 1)
                {
                    MessageBox.Show("You can move examination only 24h before!");
                    return;
                }

                medicalAppointmentController.UpdateAppointment(ma);
                MessageBox.Show("Pregled je uspesno pomeren");
            }
        }
    }
}
