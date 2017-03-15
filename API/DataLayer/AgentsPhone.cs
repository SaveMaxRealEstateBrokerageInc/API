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
    public class AgentsPhone
    {
        [DataMember]
        [Key]
        public int AgentsPhoneID { get; set; }
        [DataMember]
        public string ContactType { get; set; }
        [DataMember]
        public string PhoneType { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public int AgentID { get; set; }
        [ForeignKey("AgentID")]
        [DataMember]
        public virtual AgentDetail AgentDetail { get; set; }
    }
}
