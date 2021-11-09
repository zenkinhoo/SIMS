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
using Bolnica.Controller;
using Bolnica.Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for ScheduleAppointment.xaml
    /// </summary>
    public partial class ScheduleAppointment : Window
    {
        public string time { get; set; }
        private String fileLocationAppointments = @"medicalAppointments.txt";

        bool timeTriggered = false;
        PatientController patientController = new PatientController();
        Patient p = new Patient();
        public ScheduleAppointment()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            Patient patient = patientController.GetOne(1);
            p = patient;
            DoctorRepository doctorRepository = new DoctorRepository();
            List<String> names = ListBoxAdapter.extractIdNames(doctorRepository);
            ComboChoice.ItemsSource = names;
        }

        private void find_free_terms(object sender, RoutedEventArgs e)
        {
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


            string[] pomDoc = ComboChoice.SelectedItem.ToString().Split(' ');

            int doctorId = Convert.ToInt32(pomDoc[0]);
            String doctorName = pomDoc[1];
            String doctorLastName = pomDoc[2];
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
                foreach (String doc in ComboChoice.Items) //uzecemo slobodne termine od drugog slobodnog doktora
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

        private void schedule_appointment(object sender, RoutedEventArgs e)
        {
            if (ListFreeTerms.SelectedIndex != -1)
            {
                MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
                string[] doc = ListFreeTerms.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(doc[0]);
                Doctor doctor = ObjectFinder.findDoctor(id);
                //    
                DateTime tempDate = (DateTime)DatePick.SelectedDate;
                string[] hoursMins = doc[3].Split(':');
                int hours = Convert.ToInt32(hoursMins[0]);
                string[] minute = hoursMins[1].Split('-');
                int minutes = Convert.ToInt32(minute[0]);

                DateTime fullDate = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, hours, minutes, 0);
                if (!(Duration.Text == "") && ListFreeTerms.SelectedItem != null)
                {
                    if (doctor.type == "opste prakse")
                    {
                        if (!idExists(doctor.user.id))
                        {

                            medicalAppointmentController.ScheduleAppointment(doctor, p, doctor.Room, fullDate, Convert.ToDouble(Duration.Text), AppointmentType.Examination);
                         //   MedicalAppointment app = new MedicalAppointment();
                          //  p.medicalAppointment.Add(app);
                            MessageBox.Show("Appointment successfully scheduled");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Patient has already scheduled appointment with this doctor");
                        }
                    }
                    else if (doctor.type != "opste prakse")
                    {
                        MedicalInstructionController medicalInstructionController = new MedicalInstructionController();
                        int check = medicalInstructionController.doctorExistsInMedicalInstruction(doctor);

                        if (check != -1)
                        {
                            MedicalInstruction mi = ObjectFinder.findMedicalInstruction(check);

                            if (mi.used == false)
                            {
                                medicalAppointmentController.ScheduleAppointment(doctor, p, doctor.Room, fullDate, Convert.ToDouble(Duration.Text), AppointmentType.Examination);
                            //    MedicalAppointment app = new MedicalAppointment();
                             //   p.medicalAppointment.Add(app);
                                MessageBox.Show("Appointment successfully scheduled");
                                //    globalCounter++;
                                //    AppointmentCrudCounterController appointmentCrudCounterController = new AppointmentCrudCounterController();
                                //    appointmentCrudCounterController.SaveCounter(p.user.id, globalCounter);
                                //    Console.WriteLine(globalCounter.ToString());
                                medicalInstructionController.InstructionExpired(mi.id);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Referall can only be used once");
                            }


                        }
                        else
                        {
                            MessageBox.Show("You don't have referall for this type of appointment");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Without referall you can only schedule appointment with OPSTE PRAKSE");
                    }


                }
                else
                {
                    MessageBox.Show("Morate uneti informacije o pregledu");
                }
            }
        }
        public bool idExists(int id)
        {

            string[] lines = System.IO.File.ReadAllLines(fileLocationAppointments);

            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[2]) == id)
                {
                    return true;
                }

            }
            return false;
        }

        private void close_sheduling(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
