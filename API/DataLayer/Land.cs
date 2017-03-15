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
    public class Land
    {

        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public string SizeTotalText { get; set; }
        [DataMember]
        public string SizeFrontage { get; set; }
        [DataMember]
        public string Acreage { get; set; }
        [DataMember]
        public string Amenities { get; set; }
        [DataMember]
        public string FenceType { get; set; }
        [DataMember]
        public string FenceTotal { get; set; }
        [DataMember]
        public string SizeIrregular { get; set; }
        [DataMember]
        public string LandDisposition { get; set; }
        [DataMember]
        public string LandscapeFeatures { get; set; }
        [DataMember]
        public string Sewer { get; set; }
        [DataMember]
        public string AccessType { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }


    }
}