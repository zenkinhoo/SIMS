using System;
using System.Collections.Generic;
using Bolnica.Model;
namespace Bolnica.Repository
{
   public class RoomRepository
   {

        private String fileLocation = @"rooms.txt";

        public List<Room> GetAll()
      {
            throw new NotImplementedException();
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                int id = Convert.ToInt32(fields[0]);
                string name = fields[1];
                int floor = Convert.ToInt32(fields[2]);
                string description = fields[3];

                RoomType type; 

                Enum.TryParse(fields[4], out type);
                bool isAvailable = Convert.ToBoolean(fields[5]);
                Room room = new Room(id, name, floor, description, type, isAvailable);
                rooms.Add(room);
            }
            return rooms;
        }

        public List<Room> GetAllSecretary()
        {
            List<Room> rooms = new List<Room>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                int id = Convert.ToInt32(fields[0]);
                string name = fields[1];
                int floor = Convert.ToInt32(fields[2]);
                string description = fields[3];
                RoomType type = (RoomType)Convert.ToInt32(fields[4]);
                bool isAvailable = Convert.ToBoolean(fields[5]);
                Room room = new Room(id, name, floor, description, type, isAvailable);
                rooms.Add(room);
            }
            return rooms;
        }


        public Room GetOne(int id)
      {
         throw new NotImplementedException();
      }
        public Room GetOne(String ime)
        {
            Room room= new Room();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                int id = Convert.ToInt32(fields[0]);
                string name = fields[1];
                int floor = Convert.ToInt32(fields[2]);
                string description = fields[3];
                RoomType type = (RoomType)Convert.ToInt32(fields[4]);
                bool isAvailable = Convert.ToBoolean(fields[5]);
               

                if (ime == name)
                {
                    room = new Room(id, name, floor, description, type, isAvailable);
                    return room;
                }
            }
            return null;
        }
        public Room Save(Room newRoom)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Room room)
      {
         throw new NotImplementedException();
      }
   
   }
}