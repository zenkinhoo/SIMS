// File:    SurveyService.cs
// Author:  Lenovo T450
// Created: Saturday, May 1, 2021 5:27:28 PM
// Purpose: Definition of Class SurveyService

using System;
using Bolnica.Model;
using Bolnica.Repository;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class SurveyService
   {
      public List<Survey> GetAllSurveys()
      {
         return surveyRepository.GetAllSurveys();
      }
        public List<Survey> GetDoctorsSurveys(int idDoc)
        {
            return surveyRepository.GetDoctorsSurveys(idDoc);
        }

        public Survey GetHospitalSurvey()
        {
            return surveyRepository.GetHospitalSurvey();
        }
      public Survey SaveSurvey(Survey newSurvey)
      {
            int newID = surveyRepository.GetAllSurveys().Count + 1;
            newSurvey.id = newID;
            return surveyRepository.SaveSurvey(newSurvey);
      }
      
      public SurveyRepository surveyRepository = new SurveyRepository();
   
   }
}