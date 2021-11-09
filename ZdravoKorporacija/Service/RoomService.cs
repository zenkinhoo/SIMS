// File:    RoomService.cs
// Author:  Lenovo T450
// Created: Friday, April 16, 2021 10:42:42 AM
// Purpose: Definition of Class RoomService

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Service
{
   public class RoomService
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
      
      public bool IsRoomAvailable(DateTime startPoint, DateTime endPoint)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetAvailableRoom(DateTime currentTime)
      {
         throw new NotImplementedException();
      }
      
      public void MoveEquipment(Bolnica.Model.Room oldRoom, Bolnica.Model.Room newRoom, DateTime moveDate)
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Repository.RoomRepository roomRepository;
   
   }
}