using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Repository
{
    public class AppointmentCrudCounterRepository
    {
        private String fileLocation = @"counters.txt";
        private String patientFileLocation = @"patients.txt";

        public List<AppointmentCrudCounter> GetAllCounts()
        {
            throw new NotImplementedException();
        }

        public int GetOneCounter(Patient patient)
        {
            int count = -1;

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int idApp = Convert.ToInt32(fields[0]);
                int idPat = Convert.ToInt32(fields[1]);
                int counter = Convert.ToInt32(fields[2]);

                if (patient.user.id == idPat)
                {
                    count = counter;
                    break;
                }

            }
            return count;
        }

        public void SaveCounter(Patient patient, int counter)
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            int i = 0;
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                int idApp = Convert.ToInt32(fields[0]);
                int idPat = Convert.ToInt32(fields[1]);
                int count = Convert.ToInt32(fields[2]);

                if (idPat == patient.user.id)
                {
                    count = counter;
                    lines[i] = idApp.ToString() + "," + idPat.ToString() + "," + count.ToString();
                    break;
                }
                i++;
            }
            System.IO.File.WriteAllLines(fileLocation, lines);
        }

        public void IncrementCounter(Patient patient)
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            int i = 0;
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                int idApp = Convert.ToInt32(fields[0]);
                int idPat = Convert.ToInt32(fields[1]);
                int count = Convert.ToInt32(fields[2]);

                if (idPat == patient.user.id)
                {
                    count++;
                    lines[i] = idApp.ToString() + "," + idPat.ToString() + "," + count.ToString();
                    break;
                }
                i++;
            }
            System.IO.File.WriteAllLines(fileLocation, lines);
        }

        public void ResetCounter(Patient patient)
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            int i = 0;
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                int idApp = Convert.ToInt32(fields[0]);
                int idPat = Convert.ToInt32(fields[1]);
                int count = Convert.ToInt32(fields[2]);

                if (idPat == patient.user.id)
                {
                    count = 0;
                    lines[i] = idApp.ToString() + "," + idPat.ToString() + "," + count.ToString();
                    break;
                }
                i++;
            }
            System.IO.File.WriteAllLines(fileLocation, lines);
        }
        public void disablePatient(Patient patient)
        {
            List<Patient> patients = new List<Patient>();

            string[] lines = System.IO.File.ReadAllLines(patientFileLocation);
            int i = 0;
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                int id = Convert.ToInt32(fields[1]);

                if (patient.user.id == id)
                {
                    string jmbg = fields[0];
                    string firstName = fields[2];
                    string lastName = fields[3];
                    string phone = fields[4];
                    string address = fields[5];
                    string password = fields[6];
                    string username = fields[7];
                    bool isDisabled = true;
                    lines[i] = jmbg + "," + id.ToString() + "," + firstName + "," + lastName + "," + phone + "," + address + "," + password + "," + username + "," + isDisabled.ToString();
                    break;
                }
                i++;
            }
            System.IO.File.WriteAllLines(patientFileLocation, lines);
        }

        public void DeleteCounter(int id)
        {
            throw new NotImplementedException();
        }

    }
}