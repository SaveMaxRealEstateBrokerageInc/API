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
    public class Building
    {

        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public string BathroomTotal { get; set; }
        [DataMember]
        public string BedroomsTotal { get; set; }
        [DataMember]
        public string ConstructionMaterial { get; set; }
        [DataMember]
        public string BedroomsAboveGround { get; set; }
        [DataMember]
        public string BedroomsBelowGround { get; set; }
        [DataMember]
        public string Age { get; set; }
        [DataMember]
        public string Appliances { get; set; }
        [DataMember]
        public string ConstructedDate { get; set; }
        [DataMember]
        public string ArchitecturalStyle { get; set; }
        [DataMember]
        public string BasementDevelopment { get; set; }
        [DataMember]
        public string BasementType { get; set; }
        [DataMember]
        public string ConstructionStyleAttachment { get; set; }
        [DataMember]
        public string CoolingType { get; set; }
        [DataMember]
        public string ExteriorFinish { get; set; }
        [DataMember]
        public string FireplacePresent { get; set; }
        [DataMember]
        public string FireplaceTotal { get; set; }
        [DataMember]
        public string FireProtection { get; set; }
        [DataMember]
        public string FireplaceType { get; set; }
        [DataMember]
        public string FlooringType { get; set; }
        [DataMember]
        public string FoundationType { get; set; }
        [DataMember]
        public string HalfBathTotal { get; set; }
        [DataMember]
        public string HeatingFuel { get; set; }
        [DataMember]
        public string HeatingType { get; set; }
        [DataMember]
        public string RoofMaterial { get; set; }
        [DataMember]
        public string RoofStyle { get; set; }
        [DataMember]
        public string SizeInterior { get; set; }
        [DataMember]
        public string UtilityWater { get; set; }
        [DataMember]
        public string StoriesTotal { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int BuildingID { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
    }
}







