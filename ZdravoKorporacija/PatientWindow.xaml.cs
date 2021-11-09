using Bolnica.Model;
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
using Bolnica;
using Bolnica.Repository;
using Bolnica.Controller;
using Bolnica.Service;
using Bolnica;

namespace project
{
    /// <summary>
    /// Interaction logic for PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        //  private String fileLocation = @"C:\Users\Lenovo T450\Desktop\FileStorage\defaultraspored.txt";
        //  private String fileSuspended = @"C:\Users\Lenovo T450\Desktop\FileStorage\suspended.txt";
        private String fileLocationAppointments = @"medicalAppointments.txt";
        PatientController patientController = new PatientController();
        Patient p = new Patient();
 
        int globalCrudCounter;

        bool timeTriggered = false;
        public PatientWindow()
        {
            InitializeComponent();
        }


        void OnLoad(object sender, RoutedEventArgs e)
        {
            //string[] suspendedFile = System.IO.File.ReadAllLines(fileSuspended);
            // bool suspended = Convert.ToBoolean(suspendedFile[0]);
            Patient patient = patientController.GetOne(1);
            p = patient;
            patientController.setMedicalCard(p);
            Console.WriteLine(p.user.firstName);
            if (p.isDisabled)
            {
                ListaPregleda.IsEnabled = false;
                ListFreeTerms.IsEnabled = false;
                ComboChoice.IsEnabled = false;
                tb_endTime.IsEnabled = false;
                tb_startTime.IsEnabled = false;
                Button1.IsEnabled = false;
                Button2.IsEnabled = false;
                Button3.IsEnabled = false;
                Button4.IsEnabled = false;
                Button5.IsEnabled = false;
                Button6.IsEnabled = false;
                Button7.IsEnabled = false;
                Button8.IsEnabled = false;
                DatePick.IsEnabled = false;
                radioDoctor.IsEnabled = false;
                radioTime.IsChecked = false;
                Duration.IsEnabled = false;
                MessageBox.Show("Vas profil je suspendovan zbog spamovanja");
            }


            DoctorRepository doctorRepository = new DoctorRepository();
            List<String> names = extractIdNames(doctorRepository);
            ComboChoice.ItemsSource = names;
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            p.medicalAppointment = medicalAppointmentRepository.GetAll();
            AppointmentCrudCounterController appointmentCrudCounterController = new AppointmentCrudCounterController();
            int count = appointmentCrudCounterController.GetOneCounter(p);
            globalCrudCounter = count;
            if (appointmentCrudCounterController.resetTimePassed())
            {
                globalCrudCounter = 0;
                appointmentCrudCounterController.ResetCounter(p);
            }

            Console.WriteLine("Trenutno brisanja: " + globalCrudCounter.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientTherapyWindow pt = new PatientTherapyWindow();
            pt.Show();
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            timeTriggered = false;
            if (ComboChoice.SelectedItem != null && tb_startTime.Text != "" && tb_endTime.Text != "" && DatePick.SelectedDate != null && ((bool)radioTime.IsChecked || (bool)radioDoctor.IsChecked))
            {
                //FreeTerms ft = new FreeTerms();
                // ft.Show();
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
            else
            {
                MessageBox.Show("You must fill all fields");
            }

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            List<String> appointmentInfo = extractForAppointments(medicalAppointmentRepository);
            ListaPregleda.ItemsSource = appointmentInfo;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //zakazivanje termina
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
                            MedicalAppointment app = new MedicalAppointment();
                            p.medicalAppointment.Add(app);
                            MessageBox.Show("Pregled je uspesno zakazan");
                            //    globalCounter++;
                            //   AppointmentCrudCounterController appointmentCrudCounterController = new AppointmentCrudCounterController();
                            //   appointmentCrudCounterController.SaveCounter(p.user.id, globalCounter);
                            //   Console.WriteLine(globalCounter.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Pacijent vec ima zakazano kod ovog doktora");
                        }
                    }
                    else if (doctor.type != "opste prakse")
                    {
                        MedicalInstructionController medicalInstructionController = new MedicalInstructionController();
                        int check = medicalInstructionController.doctorExistsInMedicalInstruction(doctor);

                        if (check != -1)
                        {
                            MedicalInstruction mi = findMedicalInstruction(check);

                            if (mi.used == false)
                            {
                                medicalAppointmentController.ScheduleAppointment(doctor, p, doctor.Room, fullDate, Convert.ToDouble(Duration.Text), AppointmentType.Examination);
                                MedicalAppointment app = new MedicalAppointment();
                                p.medicalAppointment.Add(app);
                                MessageBox.Show("Pregled je uspesno zakazan");
                                //    globalCounter++;
                                //    AppointmentCrudCounterController appointmentCrudCounterController = new AppointmentCrudCounterController();
                                //    appointmentCrudCounterController.SaveCounter(p.user.id, globalCounter);
                                //    Console.WriteLine(globalCounter.ToString());
                                medicalInstructionController.InstructionExpired(mi.id);
                            }
                            else
                            {
                                MessageBox.Show("Uput mozete upotrebiti samo jednom");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Nemate uput za ovakvu vrstu pregleda");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bez uputa mozete zakazati samo kod doktora opste prakse");
                    }


                }
                else
                {
                    MessageBox.Show("Morate uneti informacije o pregledu");
                }
            }





        }

        private List<String> extractIdNames(DoctorRepository doctorRepository) //odvaja id,ime i prezime doktora da bismo njima punili combobox
        {
            List<String> names = new List<string>();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach (Doctor d in doctors)
            {
                String comboLine = "";
                comboLine += d.user.id.ToString() + " " + d.user.firstName + " " + d.user.lastName;
                names.Add(comboLine);
            }
            return names;
        }

        private List<String> extractForAppointments(MedicalAppointmentRepository medicalAppointmentRepository) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> appointmentInfo = new List<string>();
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            appointments = medicalAppointmentRepository.GetAll();
            foreach (MedicalAppointment a in appointments)
            {
                String info = "";
                info += a.id.ToString() + " ";
                foreach (Doctor d in doctors)
                {
                    if (d.user.id == a.doctor.user.id)
                    {
                        info += d.user.id + " " + d.user.firstName + " " + d.user.lastName;
                    }
                }
                info += " " + a.startTime.ToString();
                appointmentInfo.Add(info);
            }
            return appointmentInfo;
        }



        public MedicalInstruction findMedicalInstruction(int id)
        {
            MedicalInstruction miFound = new MedicalInstruction();
            MedicalInstructionRepository medicalInstructionRepository = new MedicalInstructionRepository();
            List<MedicalInstruction> medicalInstructions = medicalInstructionRepository.GetAllMedicalInstructions();
            foreach (MedicalInstruction mi in medicalInstructions)
            {
                if (mi.id == id)
                {
                    miFound = mi;
                    break;
                }
            }
            return miFound;
        }

        public MedicalAppointment findAppointment(int id)
        {
            MedicalAppointment appointmentFound = new MedicalAppointment();
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            List<MedicalAppointment> appointments = medicalAppointmentRepository.GetAll();
            foreach (MedicalAppointment a in appointments)
            {
                if (a.id == id)
                {
                    appointmentFound = a;
                    break;
                }
            }
            return appointmentFound;
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

        List<String> getAllBooked(int id)
        {
            List<String> booked = new List<String>();
            return booked;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //brisanje
        {
            MedicalAppointmentController medicalAppointmentController = new MedicalAppointmentController();
            int index = ListaPregleda.SelectedIndex;
            medicalAppointmentController.CancelAppointmentByIndex(index);
            globalCrudCounter++;
            AppointmentCrudCounterController appointmentCrudCounterController = new AppointmentCrudCounterController();
            appointmentCrudCounterController.IncrementCounter(p);
            Console.WriteLine("Trenutno brisanja: " + globalCrudCounter.ToString());
            if (globalCrudCounter >= 10)
            {
                appointmentCrudCounterController.disablePatient(p);
            }
        }

        private void ListaPregleda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexSelected = ListaPregleda.SelectedIndex;
            if (indexSelected != -1)
            {
                string[] app = ListaPregleda.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(app[0]);
                int idDoctor = Convert.ToInt32(app[1]);
                MedicalAppointment appointment = findAppointment(id);

                ComboChoice.SelectedIndex = ComboChoice.Items.IndexOf(appointment.doctor.user.id.ToString() + " " + appointment.doctor.user.firstName.ToString() + " " + appointment.doctor.user.lastName.ToString());
                DatePick.SelectedDate = appointment.startTime;
                Duration.Text = appointment.durationInHoours.ToString();
            }



        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //pomeranje termina
        {
            int indexSelected = ListaPregleda.SelectedIndex;
            if (indexSelected != -1)
            {
                string[] app = ListaPregleda.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(app[0]);
                int idDoctor = Convert.ToInt32(app[1]);
                MedicalAppointment appointment = findAppointment(id);
                Doctor doctor = ObjectFinder.findDoctor(idDoctor);
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

                MedicalAppointment ma = new MedicalAppointment(id, p.user.id, idDoctor, fullDate, Convert.ToDouble(Duration.Text), AppointmentType.Examination, doctor.room.id);

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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AppointmentHistory ah = new AppointmentHistory();
            ah.Show();
        }

        private void ComboChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] pomDoc = ComboChoice.SelectedItem.ToString().Split(' ');
            int doctorId = Convert.ToInt32(pomDoc[0]);
            Doctor doc = ObjectFinder.findDoctor(doctorId);
            labelDoctorSpecialty.Content = doc.type.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PersonalReminders prs = new PersonalReminders();
            prs.Show();
        }

        private void view_medicalCard_click(object sender, RoutedEventArgs e)
        {
            ViewMedicalCard vmc = new ViewMedicalCard();
            vmc.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CreatePersonalReminder cpr = new CreatePersonalReminder();
            cpr.Show();
        }
    }
}