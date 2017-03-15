using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class AgentData
    {
        [DataMember]
        public int AgentId { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Web { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Designations { get; set; }
        [DataMember]
        public string ContactType { get; set; }
        [DataMember]
        public string WebsiteType { get; set; }
        [DataMember]
        public string PhoneType { get; set; }
    }
}