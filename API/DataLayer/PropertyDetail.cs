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
    public class PropertyDetail
    {
        [DataMember]
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DataMember]
        public int PropertyID { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }
        [DataMember]
        public string ListingID { get; set; }
        [DataMember]
        public int Board { get; set; }
        [DataMember]
        public virtual Business Business { get; set; }
        [DataMember]
        public virtual Building Building { get; set; }
        [DataMember]
        public virtual Land Land { get; set; }
        [DataMember]
        public virtual PropertyAddress PropertyAddress { get; set; }
        [DataMember]
        public virtual AlternateURL AlternateURL { get; set; }
        [DataMember]
        public string AmmenitiesNearBy { get; set; }
        [DataMember]
        public string CommunicationType { get; set; }
        [DataMember]
        public string CommunityFeatures { get; set; }
        [DataMember]
        public string MunicipalId { get; set; }
        [DataMember]
        public string EquipmentType { get; set; }
        [DataMember]
        public string Features { get; set; }
        [DataMember]
        public string MaintenanceFee { get; set; }
        [DataMember]
        public string MaintenanceFeePaymentUnit { get; set; }
        [DataMember]
        public string LocationDescription { get; set; }
        [DataMember]
        public string OwnershipType { get; set; }
        [DataMember]
        public virtual OpenHouse OpenHouse { get; set; }
        [DataMember]
        public virtual ParkingSpace ParkingSpaces { get; set; }
        [DataMember]
        public string ParkingSpaceTotal { get; set; }
        [DataMember]
        public virtual Photo Photo { get; set; }
        [DataMember]
        public string PoolType { get; set; }
        [DataMember]
        public string Plan { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string PropertyType { get; set; }
        [DataMember]
        public string PublicRemarks { get; set; }
        [DataMember]
        public string RoadType { get; set; }
        [DataMember]
        public string RentalEquipmentType { get; set; }
        [DataMember]
        public string Structure { get; set; }
        [DataMember]
        public string TransactionType { get; set; }
        [DataMember]
        public virtual UtilitiesAvailable UtilitiesAvailable { get; set; }
        [DataMember]
        public string ZoningType { get; set; }
        [DataMember]
        public string WaterFrontType { get; set; }
        [DataMember]
        public string WaterFrontName { get; set; }
        [DataMember]
        public string ZoningDescription { get; set; }
        [DataMember]
        public virtual Room Rooms { get; set; }
        [DataMember]
        public string ViewType { get; set; }
        [DataMember]
        public string AnalyticsClick { get; set; }
        [DataMember]
        public string AnalyticsView { get; set; }
        [DataMember]
        public string MoreInformationLink { get; set; }
        [DataMember]
        public virtual PropertyFeature PropertyFeatures { get; set; }
        [DataMember]
        public virtual WalkScoreResult WalkScoreResult { get; set; }
        [DataMember]
        public virtual PropertyStatus PropertyStatus { get; set; }
        [DataMember]
        public virtual PropertyAgent PropertyAgents { get; set; }
    }

}