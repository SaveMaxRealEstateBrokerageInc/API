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
    public class PropertyAgent
    {
        [DataMember]
        [Key]
        public int ID { get; set; }
        [DataMember]
        public int AgentID { get; set; }
        [DataMember]
        public int SavemaxID { get; set; }
    }
}