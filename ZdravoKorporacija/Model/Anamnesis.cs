using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;


namespace Bolnica.Model
{
   public class Anamnesis
   {

        public int Id { get; set; }
        // public int medicalCard { get; set; }

        public MedicalCard medicalCard;
        public String Description { get; set; }
        public int IdAppointment { get; set; }
        public DateTime Date { get; set; }

        public Anamnesis() { }
        public Anamnesis(int id, int idAppointment, String description, DateTime date)
        {
            this.Id = id;
            this.Description = description;
            this.IdAppointment = idAppointment;
            this.Date = date;
        }
        public override string ToString()
        {
            return this.Description + " " + this.Date.ToString();
        }

    }
}

