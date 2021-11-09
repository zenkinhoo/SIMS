using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.Repository;
using Bolnica.Service;

namespace Bolnica.Model
{
    public class ListBoxAdapter
    {
        public static List<String> extractForMedicalInstructionsInListBox(List<MedicalInstruction> instructions) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> instructionsInfo = new List<string>();
            foreach (MedicalInstruction mi in instructions)
            {
                string temp = "";
                Doctor doc = ObjectFinder.findDoctor(mi.idDoctor);
                temp += doc.user.firstName.ToString() + " " + doc.user.lastName.ToString() + " " + mi.instruction.ToString();
                instructionsInfo.Add(temp);
            }
            return instructionsInfo;
        }

        public static List<String> extractForRecipesInListBox(List<Recipe> recipes) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> recipeInfo = new List<string>();
            foreach (Recipe r in recipes)
            {              
                recipeInfo.Add(r.ToString());
            }
            return recipeInfo;
        }
        public static List<String> extractForAnamnesisInListBox(List<Anamnesis> anamnesiss) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> anamnesisInfo = new List<string>();
            foreach (Anamnesis a in anamnesiss)
            {
                anamnesisInfo.Add(a.ToString());
            }
            return anamnesisInfo;
        }
        public static List<String> extractForPersonalReminderInListBox(List<PersonalReminder> personalReminders) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> personalRemindersInfo = new List<string>();
            foreach (PersonalReminder p in personalReminders)
            {
                personalRemindersInfo.Add(p.ToString());
            }
            return personalRemindersInfo;
        }
        public static List<String> extractForAppointments(List<MedicalAppointment> appointments) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> appointmentInfo = new List<string>();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach (MedicalAppointment a in appointments)
            {
                String info = "";
                info += a.id.ToString() + " ";
                foreach (Doctor d in doctors)
                {
                    if (d.user.id == a.doctor.user.id)
                    {
                        info += d.user.id + " " + d.user.firstName + " " + d.user.lastName;
                    }
                }
                info += " " + a.startTime.ToString();
                appointmentInfo.Add(info);
            }
            return appointmentInfo;
        }
     
        public static List<String> extractForSurveys(List<Survey> surveys) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> surveyInfo = new List<string>();

            SurveyRepository surveyRepository = new SurveyRepository();
            surveys = surveyRepository.GetAllSurveys();

            foreach (Survey s in surveys)
            {
                string temp = "";
                temp += s.id.ToString() + " " + s.doctorId.ToString() + " " + s.surveyContent.ToString() + " " + s.assessment.ToString();
                surveyInfo.Add(temp);
            }
            return surveyInfo;
        }

        public static String extractHospitalSurvey(Survey survey) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            String surveyInfo = "";
            surveyInfo += survey.assessment.ToString() + "," + survey.surveyContent.ToString();
            return surveyInfo;
        }
        public static List<String> extractDoctorSurveysRatings(List<Survey> surveys) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> surveyInfo = new List<string>();
            foreach (Survey s in surveys)
            {
                String temp = "";
                temp += "Rate: " + s.assessment.ToString();
                surveyInfo.Add(temp);
            }
            return surveyInfo;
        }
        public static List<String> extractDoctorSurveysComments(List<Survey> surveys) //odvaja id pregleda,id doktora,ime i prezime doktora
        {
            List<String> surveyInfo = new List<string>();
            foreach (Survey s in surveys)
            {
                String temp = "";
                temp += "Comment: " + s.surveyContent.ToString();
                surveyInfo.Add(temp);
            }
            return surveyInfo;
        }
        public static List<String> extractIdNames(DoctorRepository doctorRepository) //odvaja id,ime i prezime doktora da bismo njima punili combobox
        {
            List<String> names = new List<string>();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach (Doctor d in doctors)
            {
                String comboLine = "";
                comboLine += d.user.id.ToString() + " " + d.user.firstName + " " + d.user.lastName;
                names.Add(comboLine);
            }
            return names;
        }

    }
}
