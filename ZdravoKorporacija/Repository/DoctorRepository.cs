using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bolnica.Model;
namespace Bolnica.Repository
{
   public class DoctorRepository
   {
        private String fileLocation = @"doctors.txt";
        private List<Doctor> doctors = new List<Doctor>();
        public List<Doctor> GetAll()
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                Doctor doctor = new Doctor(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], Convert.ToInt32(fields[9]));
                doctors.Add(doctor);
            }
            return doctors;
        }
   
      public Bolnica.Model.Doctor GetOneByFirstNameLastNameAndType(String fname, String lname,String type)

      {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                if (fields[2] == fname && fields[3]==lname && fields[8]==type)
                {
                    return new Doctor(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], Convert.ToInt32(fields[9]));
                }
            }
            return null;
        }
        
        
        public void Save(Bolnica.Model.Doctor newDoctor)
      {
            String newRow = newDoctor.user.jmbg+","+newDoctor.user.id+","+newDoctor.user.firstName+","+newDoctor.user.lastName+","+newDoctor.user.phone+","+newDoctor.user.adress+","+newDoctor.user.password+","+newDoctor.user.username+","+newDoctor.type+","+newDoctor.room.id;
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
                id = Convert.ToInt32(fields[9]);
            }
            return ++id;
        }

        public bool Delete(String deleteRow)
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
        public bool Update(String oldRow, String newRow)
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
        public Doctor GetOne(int id)
        {
            Doctor medicalAppointment = new Doctor();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (line == "")
                {
                    continue;
                }
                if (id == Convert.ToInt32(fields[1]))
                {
                    return (new Doctor(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], Convert.ToInt32(fields[9])));
                }
            }
            return null;
        }

    }
}