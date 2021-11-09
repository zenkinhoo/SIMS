using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Model
{
    public class Announcement
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public DateTime Date { get; set; }
        public Announcement() { }
        public Announcement(int id, String title, String text, DateTime date)
        {
            Id = id;
            Title = title;
            Text = text;
            Date = date;
        }
    }
}
