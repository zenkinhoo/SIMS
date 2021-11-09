using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using System.IO;

namespace Bolnica.Repository
{
    public class AnnouncementRepository
    {
        private String fileLocation = @"announcements.txt";
        public AnnouncementRepository() { }
        public List<Announcement> GetAll()
        {
            List<Announcement> announcements = new List<Announcement>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                string[] fields = line.Split(',');
                announcements.Add(new Announcement(Convert.ToInt32(fields[0]), fields[1], fields[2], Convert.ToDateTime(fields[3])));
            }
            return announcements;
        }
        public Announcement GetOne(int id)
        {
            Announcement medicalAppointment = new Announcement();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (line == "")
                {
                    continue;
                }
                if (id == Convert.ToInt32(fields[0]))
                {
                    return (new Announcement(id, fields[1], fields[2], Convert.ToDateTime(fields[3])));  
                }
            }
            return null;
        }
        public bool UpdateRowInFile(String oldRow, String newRow) {
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

        public void Save(Announcement newAnnouncement)
        {
            string newRow = this.GenerateId()+ "," + newAnnouncement.Title+ "," + newAnnouncement.Text+ "," + newAnnouncement.Date ;
            StreamWriter write = new StreamWriter(fileLocation, true);
            write.WriteLine(newRow);
            write.Close();
        }
        public int GenerateId() {
            int id = 0 ;
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                id = Convert.ToInt32(fields[0]);
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
    }
}
