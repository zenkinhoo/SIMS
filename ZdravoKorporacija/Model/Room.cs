using System;

namespace Bolnica.Model
{
    public class Room
   {
      public int id { get; set; }
      public String name { get; set; }
      public int floor { get; set; }
      public String description { get; set; }
      public RoomType roomType { get; set; }
      public bool isAvailable { get; set; }



      public Room()

        {

        }

        public Room(int id, string name, int floor, string description, RoomType roomType, bool isAvailable)
        {
            this.id = id;
            this.name = name;
            this.floor = floor;
            this.description = description;
            this.roomType = roomType;
            this.isAvailable = isAvailable;
        }



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
      public EquipmentAppointment[] equipmentAppointment;
   
   }
}