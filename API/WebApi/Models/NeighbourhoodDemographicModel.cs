using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class NeighbourhoodDemographicModel

    {
        [DataMember]
        public String LocationId { get; set; }

        [DataMember]
        public String LocationName { get; set; }

        [DataMember]
        public String AvgPropertyPrice { get; set; }

        [DataMember]
        public String AvgHouseholdIncome { get; set; }

        [DataMember]
        public String TotalProperties { get; set; }

        [DataMember]
        public String PropertiesOwned { get; set; }

        [DataMember]
        public String PropertiesRented { get; set; }

        [DataMember]
        public String TotalPopulation { get; set; }

        [DataMember]
        public String Age0To14 { get; set; }

        [DataMember]
        public String Age15To24 { get; set; }

        [DataMember]
        public String Age25To34 { get; set; }

        [DataMember]
        public String Age35To44 { get; set; }

        [DataMember]
        public String Age45To54 { get; set; }

        [DataMember]
        public String Age55To64 { get; set; }

        [DataMember]
        public String AgeAbove65 { get; set; }

        [DataMember]
        public DateTime LastUpdated { get; set; }

    }
}
