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
    public class PropertyPhoto
    {
       
        [DataMember]
        [Key]
        public int PropertyPhotoID { get; set; }
        [DataMember]
        public int SequenceId { get; set; }
        [DataMember]
        public string LastUpdated { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        [ForeignKey("ID")]
        public virtual Photo Photo { get; set; }


    }
}