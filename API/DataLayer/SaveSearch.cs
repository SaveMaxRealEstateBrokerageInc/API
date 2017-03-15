using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [DataContract]
    public class SaveSearch
    {
        [DataMember]
        [Required, Key]
        public int SearchID { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public double PriceFrom { get; set; }
        [DataMember]
        public double PriceTo { get; set; }
        [DataMember]
        public int Bathrooms { get; set; }
        [DataMember]
        public int Bedrooms { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public string AlertFrequency { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }

    }
}