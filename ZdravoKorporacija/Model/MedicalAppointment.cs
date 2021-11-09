
using System;
using System.Collections.Generic;
using Bolnica.Repository;

namespace Bolnica.Model
{

    public class MedicalAppointment
    {
        public int id { get; set; }
        public DateTime startTime { get; set; }
        public double durationInHoours = 0.5;
      public AppointmentType type { get; set; }
      public Room room { get; set; }
      
      public Patient patient { get; set; }
        public MedicalAppointment() { }
       
     public MedicalAppointment(int id,int patientId,int doctorId,DateTime startTime,double duration,AppointmentType type,int roomId)

        {
            this.id = id;
            this.doctor = findDoctor(doctorId);
            this.patient = findPatient(patientId);
            this.startTime = startTime;
            this.durationInHoours = duration;
            this.type = type;
            this.room = findRoom(roomId);
        }

     public Doctor findDoctor(int id)
        {
            Doctor doctorFound = new Doctor();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = doctorRepository.GetAll();

            foreach(Doctor d in doctors)
            {
                if (d.user.id == id)
                {
                    doctorFound = d;
                    break;
                }
            }
            return doctorFound;
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


        public Room findRoom(int id)
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

      public Doctor doctor { get; set; }

    }
}