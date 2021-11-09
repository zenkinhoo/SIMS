/***********************************************************************
 * Module:  StaticEquipment.cs
 * Author:  Acer
 * Purpose: Definition of the Class StaticEquipment
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
   public class StaticEquipment
   {
      public String id;
      public String name;
      public int quantity;
      public String description;
      
      public EquipmentManagement[] equipmentManagement;
   
   }
}