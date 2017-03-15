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
    public class Room
    {
        
        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public int RoomsID { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
        [DataMember]
        public virtual ICollection<RoomDetail> RoomDetails { get; set; }
        
    }
}