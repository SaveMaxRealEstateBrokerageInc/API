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
    public class PropertyAddress
    {

        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int ID { get; set; }
        [DataMember]
        public string StreetAddress { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string StreetNumber { get; set; }
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public string StreetSuffix { get; set; }
        [DataMember]
        public string StreetDirectionSuffix { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Province { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string CommunityName { get; set; }
        [DataMember]
        public string Neighbourhood { get; set; }
        [DataMember]
        public string PropertyURL { get; set; }
        [DataMember]
        public string PropertyTitle { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
    }
}