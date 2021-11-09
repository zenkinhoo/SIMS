using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Bolnica.Model;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Bolnica.Repository
{
   public class MedicalAppointmentRepository
   {
        private String fileLocation = @"medicalAppointments.txt";

        public List<MedicalAppointment> GetAll()
        {
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line == "") continue;
                string[] fields = line.Split(',');
                appointments.Add(new MedicalAppointment(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), Convert.ToInt32(fields[2]), Convert.ToDateTime(fields[3]), Convert.ToDouble(fields[4]), (AppointmentType)Enum.Parse(typeof(AppointmentType), fields[5]), Convert.ToInt32(fields[6])));
            }
            return appointments;
        }

        public List<MedicalAppointment> GetAppointmentsHistory()
        {
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int id = Convert.ToInt32(fields[0]);
                int idPatient = Convert.ToInt32(fields[1]);
                int idDoctor = Convert.ToInt32(fields[2]);
                DateTime startTime = Convert.ToDateTime(fields[3]);
                double duration = Convert.ToDouble(fields[4]);

                AppointmentType type = (AppointmentType)Enum.Parse(typeof(AppointmentType), fields[5]);

                int idRoom = Convert.ToInt32(fields[6]);

                MedicalAppointment medicalAppointment = new MedicalAppointment(id, idPatient, idDoctor, startTime, duration, type, idRoom);
                    if((medicalAppointment.startTime < DateTime.Today))
                   {
                            appointments.Add(medicalAppointment);
                   }

            }
            return appointments;
        }

        public MedicalAppointment GetOne(int id)
        {
            MedicalAppointment medicalAppointment = new MedicalAppointment();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
               if(line=="")
                {
                    continue;
                }

                if (id == Convert.ToInt32(fields[0]))
                {
                    medicalAppointment = new MedicalAppointment(id, Convert.ToInt32(fields[1]), Convert.ToInt32(fields[2]), Convert.ToDateTime(fields[3]), Convert.ToDouble(fields[4]), (AppointmentType)Convert.ToInt32(fields[5]), Convert.ToInt32(fields[6]));

                    return medicalAppointment;
                }
            }
            return null;
        }

        public MedicalAppointment Save(MedicalAppointment newAppointment)
        {
            string noviRed = "\n" + newAppointment.id + "," + newAppointment.patient.user.id + "," + newAppointment.doctor.user.id + "," + newAppointment.startTime + "," + newAppointment.durationInHoours + "," + newAppointment.type + "," + newAppointment.room.id;
            fileLocation = Regex.Replace(fileLocation, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline); //uklanja prazne redove u stringu
            System.IO.File.AppendAllText(fileLocation, noviRed);
            return newAppointment;
        }
        public int GenerateId()
        {
            int id = 0;
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "") continue;
                id = Convert.ToInt32(fields[0]);
            }
            return ++id;
        }

        public bool Delete(MedicalAppointment del)
        {
            String deleteRow = del.id + "," + del.patient.user.id + "," + del.doctor.user.id + "," + del.startTime + "," + del.durationInHoours + "," + del.type + "," + del.room.id;
            String text = File.ReadAllText(fileLocation);
            if (text.Contains(deleteRow))
            {
                text = text.Replace(deleteRow, "");
                File.WriteAllText(fileLocation, text);
                return true;
            }
            return false;
        }

        public bool DeleteAppointmentByIndex(int index) //index predstavlja index listviewa u kom je selektovan pregled koji treba biti obrisan
        {
            List<string> linije = File.ReadAllLines(fileLocation).ToList();
            linije.RemoveAt(index);
            linije = linije.Where(s => s != "").ToList(); //uklanja prazne redove u listi stringova
            File.WriteAllLines(fileLocation, linije.ToList());
            return true;
        }
     

        public MedicalAppointment Update(MedicalAppointment newAppointment)
        {
            MedicalAppointment oldAppointment = this.GetOne(newAppointment.id);
            String oldRow = oldAppointment.id + "," + oldAppointment.patient.user.id + "," + oldAppointment.doctor.user.id + "," + oldAppointment.startTime + "," + oldAppointment.durationInHoours + "," + oldAppointment.type + "," + oldAppointment.room.id;
            String newRow = newAppointment.id + "," + newAppointment.patient.user.id + "," + newAppointment.doctor.user.id + "," + newAppointment.startTime + "," + newAppointment.durationInHoours + "," + newAppointment.type + "," + newAppointment.room.id;
            string[] lines = System.IO.File.ReadAllLines(fileLocation);

            for (int i=0;i<lines.Length;i++)
            {
                if(lines[i]==oldRow)
                {
                    lines[i] = newRow;
                    break;
                }
            }
            File.WriteAllLines(fileLocation, lines.ToArray());

            return oldAppointment;



        }


    }
}