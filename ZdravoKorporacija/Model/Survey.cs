// File:    Survey.cs
// Author:  Lenovo T450
// Created: Saturday, May 1, 2021 2:11:43 PM
// Purpose: Definition of Class Survey

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Model
{
   public class Survey
   {
      public int id;
      public int doctorId;
      public String surveyContent;
      public int assessment;
      public SurveyType surveyType;
      
      public Patient patient;

        public Survey()
        {
            
        }

        public Survey(int id, int doctorId, string surveyContent, int assessment, SurveyType surveyType)
        {
            this.id = id;
            this.doctorId = doctorId;
            this.surveyContent = surveyContent;
            this.assessment = assessment;
            this.surveyType = surveyType;
        }

        /// <summary>
        /// Property for Patient
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        /*   public Patient Patient
           {
              get
              {
                 return patient;
              }
              set
              {
                 if (this.patient == null || !this.patient.Equals(value))
                 {
                    if (this.patient != null)
                    {
                       Patient oldPatient = this.patient;
                       this.patient = null;
                       oldPatient.RemoveSurvey(this);
                    }
                    if (value != null)
                    {
                       this.patient = value;
                       this.patient.AddSurvey(this);
                    }
                 }
              }
           }*/

    }
}