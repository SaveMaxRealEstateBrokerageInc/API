using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{ 

    [DataContract]
    public class Item
    {
        [DataMember]
        public string Caption { get; set; }
        [DataMember]
        public Object Value { get; set; }
        [DataMember]
        public string ValueType { get; set; }
         
    }
}