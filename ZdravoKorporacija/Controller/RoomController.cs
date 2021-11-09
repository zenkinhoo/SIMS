// File:    RoomController.cs
// Author:  Lenovo T450
// Created: Friday, April 16, 2021 11:17:22 AM
// Purpose: Definition of Class RoomController


using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Controller
{
   public class RoomController
   {
      public List<Room> ReadAll()
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Model.Room ReadOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Model.Room Save(Bolnica.Model.Room room)
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Model.Room Update(Bolnica.Model.Room room)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Bolnica.Model.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void MoveEquipment(Bolnica.Model.Room oldRoom, Bolnica.Model.Room newRoom, DateTime moveDate)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetAvailableRooms(DateTime currentTime)
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Service.RoomService roomService;
   
   }
}