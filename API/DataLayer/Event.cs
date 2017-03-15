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
    public class Event
    {

        [DataMember]
        [Key]
        public int EventID { get; set; }
        [DataMember]
        public string StartDateTime { get; set; }
        [DataMember]
        public string EndDateTime { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        [ForeignKey("ID")]
        public virtual OpenHouse OpenHouse { get; set; }

    }
}