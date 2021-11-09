// File:    SurveyController.cs
// Author:  Lenovo T450
// Created: Saturday, May 1, 2021 5:31:04 PM
// Purpose: Definition of Class SurveyController

using System;
using Bolnica.Model;
using Bolnica.Service;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class SurveyController
   {
      public List<Survey> GetAllSurveys()
      {
            return surveyService.GetAllSurveys();
      }
      
      public Survey SaveSurvey(Survey newSurvey)
      {
            return surveyService.SaveSurvey(newSurvey);
      }
        public List<Survey> GetDoctorsSurveys(int idDoc)
        {
            return surveyService.GetDoctorsSurveys(idDoc);
        }
        public Survey GetHospitalSurvey()
        {
            return surveyService.GetHospitalSurvey();
        }
        public SurveyService surveyService = new SurveyService();
   
   }
}