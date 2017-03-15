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
    public class UserAnalytic
    {
        [DataMember]
        [Required, Key]
        public int AnalyticsId { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public DateTime LoginTime { get; set; }
        [DataMember]
        public int NumberOfVisits { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }
    }
}
