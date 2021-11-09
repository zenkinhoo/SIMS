/***********************************************************************
 * Module:  ExaminationFileStorage.cs
 * Author:  Acer
 * Purpose: Definition of the Class ExaminationFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using Bolnica.Model;

namespace Bolnica.Repository
{
   public class SurveyRepository
   {
        private String fileLocation = @"surveys.txt";


        public List<Survey> GetAllSurveys()
      {
            List<Survey> surveys = new List<Survey>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int id = Convert.ToInt32(fields[0]);
                int idDoctor = Convert.ToInt32(fields[1]);
                String surveyContent = fields[2];
                int assessment = Convert.ToInt32(fields[3]);
                SurveyType type = (SurveyType)Enum.Parse(typeof(SurveyType), fields[4]);

                Survey survey = new Survey(id, idDoctor, surveyContent, assessment, type);
                surveys.Add(survey);
            }
            return surveys;
        }
        public List<Survey> GetDoctorsSurveys(int idDoc) //dobavlja sve ankete za konkretnog doktora
        {
            List<Survey> surveys = new List<Survey>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int id = Convert.ToInt32(fields[0]);
                int idDoctor = Convert.ToInt32(fields[1]);
                String surveyContent = fields[2];
                int assessment = Convert.ToInt32(fields[3]);
                SurveyType type = (SurveyType)Enum.Parse(typeof(SurveyType), fields[4]);

                if(idDoc==idDoctor)
                {
                    Survey survey = new Survey(id, idDoctor, surveyContent, assessment, type);
                    surveys.Add(survey);
                }
                
            }
            return surveys;
        }
        public Survey GetHospitalSurvey() //dobavlja sve ankete za konkretnog doktora
        {
            Survey retSurvey = new Survey();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int id = Convert.ToInt32(fields[0]);
                int idDoctor = Convert.ToInt32(fields[1]);
                String surveyContent = fields[2];
                int assessment = Convert.ToInt32(fields[3]);
                SurveyType type = (SurveyType)Enum.Parse(typeof(SurveyType), fields[4]);

                if (type == SurveyType.HospitalSurvey)
                {
                    Survey survey = new Survey(id, idDoctor, surveyContent, assessment, type);
                    retSurvey = survey;
                }
            }
            return retSurvey;
        }

        public Survey GetOneSurvey(int id)
      {
         throw new NotImplementedException();
      }
      
      public Survey SaveSurvey(Survey newSurvey)
      {
            string text = "\n" + newSurvey.id + "," + newSurvey.doctorId + "," + newSurvey.surveyContent + "," + newSurvey.assessment + "," + newSurvey.surveyType;
            File.AppendAllText(fileLocation, text);
            return newSurvey;
        }
      
      public bool DeleteSurvey(int id)
      {
         throw new NotImplementedException();
      }
   
   }
}