using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

using System.Windows;
using Bolnica.Service;

namespace Bolnica.Service
{
   public class MedicalAppointmentService
   {

        
        public Bolnica.Repository.MedicalAppointmentRepository medicalAppointmentRepository=new MedicalAppointmentRepository();
        public Bolnica.Repository.DoctorSchedulesRepository doctorSchedulesRepository = new DoctorSchedulesRepository();
        // FindFreeTerms nije vezano za zakazivanje hitnog pregleda
        public List<DateTime> FindFreeTermsSecretary(DateTime startPoint, DateTime endPoint, Bolnica.Model.Doctor doctor, String priority)
      {
            List<String> slobodniTermini=new List<String>();
            doctorSchedulesRepository = new DoctorSchedulesRepository();
            List<DoctorSchedules> ds = new List<DoctorSchedules>();
            ds=doctorSchedulesRepository.GetAll();//lista svih rezervisanih vremenski intervala
            List<DoctorSchedules> doctorsBusyTerms = new List<DoctorSchedules>();
            List<DoctorSchedules> BusyTermsInInterval = new List<DoctorSchedules>();
            List<DateTime> availableTerms = new List<DateTime>();//povratna vrednost metode
            List<DateTime> listaObrisanih = new List<DateTime>();
            


            //ako doktor ima neke zauzete termine u zadatom intervalu
            List<DateTime> listTermForOneDay = new List<DateTime>();
            for (int i = 0; i < 15; i++)
            {
                if (listTermForOneDay.Count == 12)
                {
                    break;
                }
                listTermForOneDay.Add(startPoint.AddHours(0.5 * i));
            }

            foreach (DoctorSchedules docshe in ds)
            {
                if (docshe.idDoctor == doctor.user.id)
                {
                    doctorsBusyTerms.Add(docshe);//svi zauzzeti termini vezani za tog doktora
                }
            }
            foreach(DoctorSchedules s in doctorsBusyTerms)
            {
                if(s.startTime>=startPoint && s.endTime <= endPoint)//gledamo da li je neki zauzet termin doktora unutar datog intervala
                {
                    BusyTermsInInterval.Add(s);
                }
            }

            if (BusyTermsInInterval.Count == 0)//ako nema zauzetih termina u zadatom intervalu
            {
                MessageBox.Show("doktor je slobodan u bilo koje vreme u zadatom intervalu");
                
                for(int jj = 0; jj < listTermForOneDay.Count; jj++)
                {
                    if (listTermForOneDay[jj].Hour < endPoint.Hour )
                    {
                        listaObrisanih.Add(listTermForOneDay[jj]);
                    }
                    if (listTermForOneDay[jj].Hour == endPoint.Hour && listTermForOneDay[jj].Minute < endPoint.Minute)
                    {
                        listaObrisanih.Add(listTermForOneDay[jj]);
                    }

                }
                return listaObrisanih;
            } 
            
            foreach(DoctorSchedules d in BusyTermsInInterval)
            {
                for(int i = 0; i < listTermForOneDay.Count; i++)
                {
                    if(d.startTime==listTermForOneDay[i] )
                    {
                        listTermForOneDay.Remove(listTermForOneDay[i]);
                    }
                }
            }
            for (int jj = 0; jj < listTermForOneDay.Count; jj++)
            {
                if (listTermForOneDay[jj].Hour < endPoint.Hour)
                {
                    listaObrisanih.Add(listTermForOneDay[jj]);
                }
                if (listTermForOneDay[jj].Hour == endPoint.Hour && listTermForOneDay[jj].Minute < endPoint.Minute)
                {
                    listaObrisanih.Add(listTermForOneDay[jj]);
                }
            }
            return listaObrisanih;
      }
      
      public List<String> DoctorPriority()
      {
         throw new NotImplementedException();
      }
      
      

        private String fileLocation = @"defaultraspored.txt";
        public List<String> FindFreeTerms(String startPoint, String endPoint, List<String> bookedTerms, bool timeTriggered)
        {

            List<String> freeTerms = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);

            string[] startHoursMinutes = startPoint.Split(':');
            int startHours = Convert.ToInt32(startHoursMinutes[0]);
            int startMinutes = Convert.ToInt32(startHoursMinutes[1]);

            if (startHours > 12)
            {
                startHours -= 12;
            }

            string[] endHoursMinutes = endPoint.Split(':');
            int endHours = Convert.ToInt32(endHoursMinutes[0]);
            int endMinutes = Convert.ToInt32(endHoursMinutes[1]);

            if (endHours > 12)
            {
                endHours -= 12;
            }

            //racunamo vreme u sekundama

            double startSeconds = Convert.ToDouble((startHours * 3600) + startMinutes * 60);
            double endSeconds = Convert.ToDouble(endHours * 3600 + endMinutes * 60);

            foreach (string line in lines)
            {

                bool flag = true;
                //logika za otpakivanje u sekunde u defaultnom rasporedu
                string[] startEnd = line.Split(',');

                string[] defStart = startEnd[0].Split(':');
                string[] defEnd = startEnd[1].Split(':');

                int defStartHours = Convert.ToInt32(defStart[0]);
                int defStartMinutes = Convert.ToInt32(defStart[1]);
                if (defStartHours > 12)
                {
                    defStartHours -= 12;
                }
                int defEndHours = Convert.ToInt32(defEnd[0]);
                int defEndMinutes = Convert.ToInt32(defEnd[1]);

                if (defEndHours > 12)
                {
                    defEndHours -= 12;
                }

                double defStartSeconds = Convert.ToDouble((defStartHours * 3600) + defStartMinutes * 60);
                double defEndSeconds = Convert.ToDouble((defEndHours * 3600) + defEndMinutes * 60);

                if (defStartSeconds >= startSeconds && defEndSeconds <= endSeconds) //ukoliko se nalazi unutar zadatog vremenskog intervala
                {
                    string freeTerm = "";
                    if (timeTriggered)
                    {
                        if (defStartMinutes < 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes < 10 && defEndMinutes >= 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes >= 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }

                        if (freeTerm != "" && !freeTerms.Contains(freeTerm))
                        {

                            freeTerms.Add(freeTerm);
                        }
                    }

                    foreach (String bt in bookedTerms)
                    {


                        string[] bookedStartEnd = bt.Split(',');

                        string[] bookedStart = bookedStartEnd[0].Split(':');
                        string[] bookedEnd = bookedStartEnd[1].Split(':');

                        int bookedStartHours = Convert.ToInt32(bookedStart[0]);
                        int bookedStartMinutes = Convert.ToInt32(bookedStart[1]);
                        if (bookedStartHours > 12)
                        {
                            bookedStartHours -= 12;
                        }

                        int bookedEndHours = Convert.ToInt32(bookedEnd[0]);
                        int bookedEndMinutes = Convert.ToInt32(bookedEnd[1]);

                        if (bookedStartHours > 12)
                        {
                            bookedEndHours -= 12;
                        }

                        double bookedStartSeconds = Convert.ToDouble((bookedStartHours * 3600) + bookedStartMinutes * 60);
                        double bookedEndSeconds = Convert.ToDouble((bookedEndHours * 3600) + bookedEndMinutes * 60);


                        if (!(bookedStartSeconds >= defEndSeconds || bookedEndSeconds <= defStartSeconds))
                        {
                            flag = false;
                        }
                        if (freeTerm != "" && !freeTerms.Contains(freeTerm))
                        {
                            freeTerms.Add(freeTerm);
                        }

                    }
                    if (flag == true)
                    {
                        if (defStartMinutes < 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes < 10 && defEndMinutes >= 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes >= 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }

                        if (freeTerm != "" && !freeTerms.Contains(freeTerm))
                        {

                            freeTerms.Add(freeTerm);
                        }
                    }
                }
            }
            return freeTerms;

        }

        public List<String> generateIfDoctorPriority(String startPoint, String endPoint, List<String> bookedTerms)
        {
            List<String> freeTerms = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);

            string[] startHoursMinutes = startPoint.Split(':');
            int startHours = Convert.ToInt32(startHoursMinutes[0]);
            int startMinutes = Convert.ToInt32(startHoursMinutes[1]);

            if (startHours > 12)
            {
                startHours -= 12;
            }

            string[] endHoursMinutes = endPoint.Split(':');
            int endHours = Convert.ToInt32(endHoursMinutes[0]);
            int endMinutes = Convert.ToInt32(endHoursMinutes[1]);

            if (endHours > 12)
            {
                endHours -= 12;
            }

            //racunamo vreme u sekundama

            double startSeconds = Convert.ToDouble((startHours * 3600) + startMinutes * 60);
            double endSeconds = Convert.ToDouble(endHours * 3600 + endMinutes * 60);

            foreach (string line in lines)
            {

                bool flag = true;
                //logika za otpakivanje u sekunde u defaultnom rasporedu
                string[] startEnd = line.Split(',');

                string[] defStart = startEnd[0].Split(':');
                string[] defEnd = startEnd[1].Split(':');

                int defStartHours = Convert.ToInt32(defStart[0]);
                int defStartMinutes = Convert.ToInt32(defStart[1]);
                if (defStartHours > 12)
                {
                    defStartHours -= 12;
                }
                int defEndHours = Convert.ToInt32(defEnd[0]);
                int defEndMinutes = Convert.ToInt32(defEnd[1]);

                if (defEndHours > 12)
                {
                    defEndHours -= 12;
                }

                double defStartSeconds = Convert.ToDouble((defStartHours * 3600) + defStartMinutes * 60);
                double defEndSeconds = Convert.ToDouble((defEndHours * 3600) + defEndMinutes * 60);

                if (!(defStartSeconds >= startSeconds && defEndSeconds <= endSeconds)) //ukoliko se nalazi unutar zadatog vremenskog intervala
                {
                    string freeTerm = "";
                    foreach (String bt in bookedTerms)
                    {

                        string[] bookedStartEnd = bt.Split(',');

                        string[] bookedStart = bookedStartEnd[0].Split(':');
                        string[] bookedEnd = bookedStartEnd[1].Split(':');

                        int bookedStartHours = Convert.ToInt32(bookedStart[0]);
                        int bookedStartMinutes = Convert.ToInt32(bookedStart[1]);
                        if (bookedStartHours > 12)
                        {
                            bookedStartHours -= 12;
                        }

                        int bookedEndHours = Convert.ToInt32(bookedEnd[0]);
                        int bookedEndMinutes = Convert.ToInt32(bookedEnd[1]);

                        if (bookedStartHours > 12)
                        {
                            bookedEndHours -= 12;
                        }

                        double bookedStartSeconds = Convert.ToDouble((bookedStartHours * 3600) + bookedStartMinutes * 60);
                        double bookedEndSeconds = Convert.ToDouble((bookedEndHours * 3600) + bookedEndMinutes * 60);

                        if (!(bookedStartSeconds >= defEndSeconds || bookedEndSeconds <= defStartSeconds))
                        {
                            flag = false;
                        }
                        if (freeTerm != "" && !freeTerms.Contains(freeTerm))
                        {
                            freeTerms.Add(freeTerm);
                        }

                    }
                    if (flag == true)
                    {
                        if (defStartMinutes < 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes < 10 && defEndMinutes >= 10)
                        {
                            freeTerm += defStartHours.ToString() + ":0" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }
                        else if (defStartMinutes >= 10 && defEndMinutes < 10)
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":0" + defEndMinutes.ToString();
                        }
                        else
                        {
                            freeTerm += defStartHours.ToString() + ":" + defStartMinutes.ToString() + "-" + defEndHours.ToString() + ":" + defEndMinutes.ToString();
                        }

                        if (freeTerm != "" && !freeTerms.Contains(freeTerm))
                        {

                            freeTerms.Add(freeTerm);
                        }
                    }
                }

            }
            return freeTerms;
        }

        public List<Doctor> TimePriority()
      {
         throw new NotImplementedException();
      }
      
      public MedicalAppointment ScheduleAppointment(Bolnica.Model.Doctor doctor, Bolnica.Model.Patient patient, Bolnica.Model.Room room, DateTime startTime, double duration, Bolnica.Model.AppointmentType type)
      {
            int newID = medicalAppointmentRepository.GetAll().Count + 1;
            MedicalAppointment ma = new MedicalAppointment(newID, patient.user.id, doctor.user.id, startTime, duration, type, room.id);
            DoctorSchedules ds = new DoctorSchedules(doctor.user.id,ma.startTime,ma.startTime.AddHours(duration));
            doctorSchedulesRepository.Save(ds);
            return medicalAppointmentRepository.Save(ma);
        }

       

        public bool CancelAppointment(MedicalAppointment appointment)
      {
            return medicalAppointmentRepository.Delete(appointment);

        }
      public List<MedicalAppointment> getAllPastAppointments()
        {
            return appointmentHistoryRepository.GetAllPastAppointments();
        }
      public MedicalAppointment UpdateAppointment(MedicalAppointment appointment)
      {
            return medicalAppointmentRepository.Update(appointment);
      }
      
      public bool CancelAppointmentByIndex(int index)
      {
            return medicalAppointmentRepository.DeleteAppointmentByIndex(index);

      }

      
      public bool IsRoomAvailable(Bolnica.Model.Room room, DateTime startTime)
      {
         throw new NotImplementedException();
      }
      
      public bool IdExists(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalAppointment> ReadAll()
      {
         throw new NotImplementedException();
      }

        public AppointmentHistoryRepository appointmentHistoryRepository = new AppointmentHistoryRepository();

      public Bolnica.Repository.DoctorRepository doctorRepository;
      public Bolnica.Repository.RoomRepository roomRepository;
      public Bolnica.Repository.PatientRepository patientRepository;
      public PatientService patientService;
        public DoctorService doctorService = new DoctorService();

        public void findFreeTermsForEmergencyAppointment(String doctorType) {
            
        }
        public Doctor findFreeDoctorAccordingType(String doctorType) {
            List<Doctor> foundDoctors = new List<Doctor>();
            foundDoctors = doctorService.findDoctorsByType(doctorType);
            foreach (Doctor d in foundDoctors)
            {
                if (isDoctorFree(d) == true) return d;
            }
            return null;
        }
        public bool isDoctorFree(Doctor doctor)
        {
            List<DoctorSchedules> busyTermsForDoctor = new List<DoctorSchedules>();
            busyTermsForDoctor = this.findBusyTermsForDoctor(doctor);
            DateTime now = DateTime.Now;
            foreach (DoctorSchedules ds in busyTermsForDoctor) { 
                if(ds.startTime<=now && ds.endTime >= now)//if now is between start and end doctor is busy
                {
                    return false;
                }
            }
            return true;
        }
        public List<DoctorSchedules> findBusyTermsForDoctor(Doctor doctor) {
            List<DoctorSchedules> doctorSchedulesForAllDoctors = new List<DoctorSchedules>();
            List<DoctorSchedules> doctorSchedulesForDoctor = new List<DoctorSchedules>();
            doctorSchedulesForAllDoctors = doctorSchedulesRepository.GetAll();
            foreach (DoctorSchedules ds in doctorSchedulesForAllDoctors)
            {
                if (ds.idDoctor == doctor.user.id)
                {
                    doctorSchedulesForDoctor.Add(new DoctorSchedules(doctor.user.id, ds.startTime, ds.endTime));
                }
            }
            return doctorSchedulesForDoctor;
        }
        public void scheduleEmergencyAppointment(MedicalAppointment newMedicalAppointment) {
            DoctorSchedules ds = new DoctorSchedules(newMedicalAppointment.doctor.user.id,newMedicalAppointment.startTime, newMedicalAppointment.startTime.AddHours(newMedicalAppointment.durationInHoours));
            doctorSchedulesRepository.Save(ds);
            medicalAppointmentRepository.Save(newMedicalAppointment);
        }
   }
}