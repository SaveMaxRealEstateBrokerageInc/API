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
    public class FavouriteSearch
    {
        [DataMember]
        [Required, Key]
        public int FavID { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }

    }
}