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
    public class PropertyStatus
    {
        
        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public DateTime RemovedDate { get; set; }
        [DataMember]
        public bool IsPropertyRemoved { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public bool Manual { get; set; }
        [DataMember]
        public string MemberName { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
    }
}