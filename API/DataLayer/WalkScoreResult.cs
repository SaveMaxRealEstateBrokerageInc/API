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
    public class WalkScoreResult
    {
        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Walkscore { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Updated { get; set; }
        [DataMember]
        public string Logo_url { get; set; }
        [DataMember]
        public string More_info_icon { get; set; }
        [DataMember]
        public string More_info_link { get; set; }
        [DataMember]
        public string Ws_link { get; set; }
        [DataMember]
        public string Help_link { get; set; }
        [DataMember]
        public string Snapped_lat { get; set; }
        [DataMember]
        public string Snapped_lon { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
    }
}   