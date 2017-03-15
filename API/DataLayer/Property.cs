using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataLayer
{
    [DataContract]
    public class Property
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public System.DateTime LastUpdated { get; set; }
        [DataMember]
        public string PropertyID { get; set; }
        [DataMember]
        public string MemberName { get; set; }
        [DataMember]
        public bool Manual { get; set; }
    }
}