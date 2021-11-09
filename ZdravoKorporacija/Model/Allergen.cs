
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Model
{
    public class Allergen
    {
        public int Id { get; set; }
        public int medicalCard { get; set; }
        public String Description { get; set; }
        private MedicalCardRepository medicalCardRepository = new MedicalCardRepository();

        public Allergen() { }
        public Allergen(int id, int idMedicalCard, String description)
        {
            Id = id;
            Description = description;
            medicalCard = idMedicalCard;
        }
    }
}


