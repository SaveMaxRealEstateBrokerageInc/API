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
    public class Parking
    {

        [DataMember]
        [Key]
        public int ParkingID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Spaces { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        [ForeignKey("ID")]
        public virtual ParkingSpace ParkingSpaces { get; set; }


    }
}