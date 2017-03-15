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
    public class Business
    {

        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public string BusinessType { get; set; }
        [DataMember]
        public string BusinessSubType { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }


    }
}