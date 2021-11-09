/***********************************************************************
 * Module:  EquipmentManagement.cs
 * Author:  Acer
 * Purpose: Definition of the Class EquipmentManagement
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
   public class EquipmentManagement : EquipmentAppointment
   {
      public Room roomTo;
      
      public System.Collections.Generic.List<StaticEquipment> staticEquipment;
      
      /// <summary>
      /// Property for collection of StaticEquipment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<StaticEquipment> StaticEquipment
      {
         get
         {
            if (staticEquipment == null)
               staticEquipment = new System.Collections.Generic.List<StaticEquipment>();
            return staticEquipment;
         }
         set
         {
            RemoveAllStaticEquipment();
            if (value != null)
            {
               foreach (StaticEquipment oStaticEquipment in value)
                  AddStaticEquipment(oStaticEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new StaticEquipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddStaticEquipment(StaticEquipment newStaticEquipment)
      {
         if (newStaticEquipment == null)
            return;
         if (this.staticEquipment == null)
            this.staticEquipment = new System.Collections.Generic.List<StaticEquipment>();
         if (!this.staticEquipment.Contains(newStaticEquipment))
            this.staticEquipment.Add(newStaticEquipment);
      }
      
      /// <summary>
      /// Remove an existing StaticEquipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveStaticEquipment(StaticEquipment oldStaticEquipment)
      {
         if (oldStaticEquipment == null)
            return;
         if (this.staticEquipment != null)
            if (this.staticEquipment.Contains(oldStaticEquipment))
               this.staticEquipment.Remove(oldStaticEquipment);
      }
      
      /// <summary>
      /// Remove all instances of StaticEquipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllStaticEquipment()
      {
         if (staticEquipment != null)
            staticEquipment.Clear();
      }
   
   }
}