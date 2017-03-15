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
    public class UtilitiesAvailable
    {        
        [DataMember]
        [Key, ForeignKey("PropertyDetail")]
        public int PropertyID { get; set; }
        [DataMember]
        public int UtilitiesAvailableID { get; set; }
        [DataMember]
        public virtual PropertyDetail PropertyDetail { get; set; }
        [DataMember]
        public virtual ICollection<Utility> Utilities { get; set; }
        
    }
}