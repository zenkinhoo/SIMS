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
    public class ObjectFinder
    {

        public static Patient p;
        public static Doctor findDoctor(int id)
        {
            Doctor doctorFound = new Doctor();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = doctorRepository.GetAll();
            foreach (Doctor d in doctors)
            {
                if (d.user.id == id)
                {
                    doctorFound = d;
                    break;
                }
            }
            return doctorFound;
        }
        public static Room findRoom(int id)
        {
            Room roomFound = new Room();
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.GetAllRooms();
            foreach (Room r in rooms)
            {
                if (r.id == id)
                {
                    roomFound = r;
                    break;
                }
            }
            return roomFound;
        }
        public Patient findPatient(int id)
        {
            Patient patientFound = new Patient();
            PatientRepository patientRepository = new PatientRepository();
            List<Patient> patients = patientRepository.GetAll();
            foreach (Patient p in patients)
            {
                if (p.user.id == id)
                {
                    patientFound = p;
                    break;
                }
            }
            return patientFound;
        }
        public static MedicalInstruction findMedicalInstruction(int id)
        {
            MedicalInstruction miFound = new MedicalInstruction();
            MedicalInstructionRepository medicalInstructionRepository = new MedicalInstructionRepository();
            List<MedicalInstruction> medicalInstructions = medicalInstructionRepository.GetAllMedicalInstructions();
            foreach (MedicalInstruction mi in medicalInstructions)
            {
                if (mi.id == id)
                {
                    miFound = mi;
                    break;
                }
            }
            return miFound;
        }
        public static MedicalAppointment findAppointment(int id)
        {
            MedicalAppointment appointmentFound = new MedicalAppointment();
            MedicalAppointmentRepository medicalAppointmentRepository = new MedicalAppointmentRepository();
            List<MedicalAppointment> appointments = medicalAppointmentRepository.GetAll();
            foreach (MedicalAppointment a in appointments)
            {
                if (a.id == id)
                {
                    appointmentFound = a;
                    break;
                }
            }
            return appointmentFound;
        }
    }
}
