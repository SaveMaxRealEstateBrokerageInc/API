using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    [DataContract]
    public class NeighbourhoodDemographic
    {
        [DataMember]
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationId { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public int AvgPropertyPrice { get; set; }

        [DataMember]
        public int AvgHouseholdIncome { get; set; }

        [DataMember]
        public int TotalProperties { get; set; }

        [DataMember]
        public int PropertiesOwned { get; set; }

        [DataMember]
        public int PropertiesRented { get; set; }

        [DataMember]
        public int TotalPopulation { get; set; }

        [DataMember]
        public int Age0To14 { get; set; }

        [DataMember]
        public int Age15To24 { get; set; }

        [DataMember]
        public int Age25To34 { get; set; }

        [DataMember]
        public int Age35To44 { get; set; }

        [DataMember]
        public int Age45To54 { get; set; }

        [DataMember]
        public int Age55To64 { get; set; }

        [DataMember]
        public int AgeAbove65 { get; set; }

        [DataMember]
        public DateTime LastUpdated { get; set; }

    }
}
