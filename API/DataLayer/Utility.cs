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
    public class Utility
    {        
        [DataMember]
        [Key]
        public int UtilityID { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        [ForeignKey("ID")]
        public virtual UtilitiesAvailable UtilitiesAvailable { get; set; }
    }
}