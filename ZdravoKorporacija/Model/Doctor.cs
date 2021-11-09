
using System;
using Bolnica.Repository;
using Bolnica.Model;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Doctor : Employee
   {
        public Doctor() { }
        
        public Doctor(String jmbg, int id, String firstName, String lastName, String phone, String adress, String password, String username, String type, int roomId)
        {
            User u = new User();
            //base.user(Jmbg, id, firstName, lastName, phone, adress, password, username);
            u.id = id;
            u.jmbg = jmbg;
            u.firstName = firstName;
            u.lastName = lastName;
            u.phone = phone;
            u.adress = adress;
            u.password = password;
            u.username = username;
            this.type = type;
            Room room = findRoom(roomId);
            this.Room = room;
            user = u;

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

        public String type { get; set; }
      
      public System.Collections.ArrayList medicalAppointment;
      
     
      public List<int> surveys; //id-ovi anketa
      
      

        public System.Collections.ArrayList MedicalAppointment

      {
         get
         {
            if (medicalAppointment == null)
               medicalAppointment = new System.Collections.ArrayList();
            return medicalAppointment;
         }
         set
         {
            RemoveAllMedicalAppointment();
            if (value != null)
            {
               foreach (MedicalAppointment oMedicalAppointment in value)
                  AddMedicalAppointment(oMedicalAppointment);
            }
         }
      }
      public void AddMedicalAppointment(MedicalAppointment newMedicalAppointment)
      {
         if (newMedicalAppointment == null)
            return;
         if (this.medicalAppointment == null)
            this.medicalAppointment = new System.Collections.ArrayList();
         if (!this.medicalAppointment.Contains(newMedicalAppointment))
         {
            this.medicalAppointment.Add(newMedicalAppointment);
            newMedicalAppointment.doctor = this;
         }
      }
      
      public void RemoveMedicalAppointment(MedicalAppointment oldMedicalAppointment)
      {
         if (oldMedicalAppointment == null)
            return;
         if (this.medicalAppointment != null)
            if (this.medicalAppointment.Contains(oldMedicalAppointment))
            {
               this.medicalAppointment.Remove(oldMedicalAppointment);
               oldMedicalAppointment.doctor = null;
            }
      }
      public void RemoveAllMedicalAppointment()
      {
         if (medicalAppointment != null)
         {
            System.Collections.ArrayList tmpMedicalAppointment = new System.Collections.ArrayList();
            foreach (MedicalAppointment oldMedicalAppointment in medicalAppointment)
               tmpMedicalAppointment.Add(oldMedicalAppointment);
            medicalAppointment.Clear();
            foreach (MedicalAppointment oldMedicalAppointment in tmpMedicalAppointment)
               oldMedicalAppointment.doctor = null;
            tmpMedicalAppointment.Clear();
         }
      }
      public Room room;
      
      public Room Room
      {
         get
         {
            return room;
         }
         set
         {
            this.room = value;
         }
      }
   
   }
}