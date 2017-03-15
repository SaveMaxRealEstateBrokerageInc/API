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
    public class RoomDetail
    {
        [DataMember]
        [Key]
        public int RoomDetailID { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Width { get; set; }
        [DataMember]
        public string Length { get; set; }
        [DataMember]
        public string Level { get; set; }
        [DataMember]
        public string Dimension { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        [ForeignKey("ID")]
        public virtual Room Rooms { get; set; }
        
    }
}