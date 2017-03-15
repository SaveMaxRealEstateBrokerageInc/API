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
    public class AgentDetail
    {
        [DataMember]
        [Key]
        public int AgentID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int OfficeID { get; set; }
        [DataMember]
        public string LastUpdated { get; set; }
        [DataMember]
        public string Board { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Designations { get; set; }
        [DataMember]
        public string PhotoLastUpdated { get; set; }
        [DataMember]
        public Boolean isHidden { get; set; }

    }
}
