using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataLayer
{
    [DataContract]
    public class PropertyFeature
    {
        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public bool? SecuritySystem { get; set; }
        [DataMember]
        public bool? ParkingOnStreet { get; set; }
        [DataMember]
        public bool? Garage { get; set; }
        [DataMember]
        public bool? Internet { get; set; }
        [DataMember]
        public bool? Telephone { get; set; }
        [DataMember]
        public bool? AlarmClock { get; set; }
        [DataMember]
        public bool? WaterCooler { get; set; }
        [DataMember]
        public bool? AirConditioning { get; set; }
        [DataMember]
        public bool? Heating { get; set; }
        [DataMember]
        public bool? WashingMachine { get; set; }
        [DataMember]
        public bool? ClothesDryer { get; set; }
        [DataMember]
        public bool? Fireplace { get; set; }
        [DataMember]
        public bool? SofaBed { get; set; }
        [DataMember]
        public bool? Dishwasher { get; set; }
        [DataMember]
        public bool? Refrigerator { get; set; }
        [DataMember]
        public bool? Freezer { get; set; }
        [DataMember]
        public bool? Oven { get; set; }
        [DataMember]
        public bool? Microwave { get; set; }
        [DataMember]
        public bool? CoffeeMaker { get; set; }
        [DataMember]
        public bool? Toaster { get; set; }
        [DataMember]
        public bool? IceMaker { get; set; }
        [DataMember]
        public bool? Stove { get; set; }
        [DataMember]
        public bool? DishesUtensils { get; set; }
        [DataMember]
        public bool? SatelliteCableTV { get; set; }
        [DataMember]
        public bool? Balcony { get; set; }
        [DataMember]
        public bool? DeckPatio { get; set; }
        [DataMember]
        public bool? OutdoorGrill { get; set; }
        [DataMember]
        public bool? Garagefor2cars { get; set; }
        [DataMember]
        public bool? OutdoorPool { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
        
    }
}