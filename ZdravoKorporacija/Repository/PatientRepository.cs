using System;
using System.Collections.Generic;
using Bolnica.Model;
using System.IO;
using System.Windows;
using System.Linq;

namespace Bolnica.Repository
{

    public class PatientRepository
    {
        private String fileLocation = @"patients.txt";



        public List<Patient> GetAll()
        {
            List<Patient> patients = new List<Patient>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                patients.Add(new Patient(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], Convert.ToBoolean(fields[8])));
            }
            return patients;
        }


        public Patient GetOne(int idPatient)
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                if (Convert.ToInt32(fields[1]) == idPatient)
                {

                    return new Patient(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], Convert.ToBoolean(fields[8]));
                }
            }
            return null;
        }

        public void Save(Patient newPatient)
        {
            String newRow = newPatient.user.jmbg + "," + GenerateId() + "," +newPatient.user.firstName + "," + newPatient.user.lastName + "," + newPatient.user.phone + "," + newPatient.user.adress + "," + newPatient.user.password+","+ newPatient.user.username + "," +newPatient.isDisabled;
            StreamWriter write = new StreamWriter(fileLocation, true);
            write.WriteLine(newRow);
            write.Close();
        }
        public int GenerateId()
        {
            int id = 0;
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                id = Convert.ToInt32(fields[1]);
            }
            return ++id;
        }
        public bool DeleteRowInFile(String deleteRow)
        {
            String text = File.ReadAllText(fileLocation);
            if (text.Contains(deleteRow))
            {
                text = text.Replace(deleteRow, "");
                File.WriteAllText(fileLocation, text);
                return true;
            }
            return false;
        }
        public bool UpdateRowInFile(String oldRow, String newRow)
        {
            bool isChanged = false;
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == oldRow)
                {
                    lines[i] = newRow;
                    isChanged = true;
                    break;
                }
            }
            File.WriteAllLines(fileLocation, lines.ToArray());
            return isChanged;
        }

    }


}