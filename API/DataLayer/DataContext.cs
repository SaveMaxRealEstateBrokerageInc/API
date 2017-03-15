using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace DataLayer
{

    public class DataContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // other code 
            Database.SetInitializer<DataContext>(null);
            // more code
        }
        public DataContext() : base(ConfigurationManager.ConnectionStrings["connection"].ConnectionString)
        {
        }
        [DataMember]
        public virtual DbSet<NeighbourhoodDemographic> NeighbourhoodDemographics { get; set; }
        [DataMember]
        public virtual DbSet<AlternateURL> AlternateURLs { get; set; }
        [DataMember]
        public virtual DbSet<Building> Buildings { get; set; }
        [DataMember]
        public virtual DbSet<Business> Businesses { get; set; }
        [DataMember]
        public virtual DbSet<PropertyFeature> PropertyFeatures { get; set; }
        [DataMember]
        public virtual DbSet<Event> Events { get; set; }
        [DataMember]
        public virtual DbSet<Land> Lands { get; set; }
        [DataMember]
        public virtual DbSet<OpenHouse> OpenHouses { get; set; }
        [DataMember]
        public virtual DbSet<Parking> Parkings { get; set; }
        [DataMember]
        public virtual DbSet<ParkingSpace> ParkingSpaces { get; set; }
        [DataMember]
        public virtual DbSet<Photo> Photos { get; set; }
        [DataMember]
        public virtual DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        [DataMember]
        public virtual DbSet<PropertyAddress> PropertyAddresses { get; set; }
        [DataMember]
        public virtual DbSet<PropertyAgent> PropertyAgents { get; set; }
        [DataMember]
        public virtual DbSet<PropertyDetail> PropertyDetails { get; set; }
        [DataMember]
        public virtual DbSet<PropertyAnalytic> PropertyAnalytics { get; set; }
        [DataMember]
        public virtual DbSet<PropertyStatus> PropertyStatus { get; set; }
        [DataMember]
        public virtual DbSet<Room> Roooms { get; set; }
        [DataMember]
        public virtual DbSet<RoomDetail> RoomDetails { get; set; }
        [DataMember]
        public virtual DbSet<UtilitiesAvailable> UtilitiesAvailables { get; set; }
        [DataMember]
        public virtual DbSet<Utility> Utilities { get; set; }
        [DataMember]
        public virtual DbSet<WalkScoreResult> WalkScoreResults { get; set; }
        [DataMember]
        public virtual DbSet<Property> Properties { get; set; }
        [DataMember]
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        [DataMember]
        public virtual DbSet<AgentsPhone> AgentsPhones { get; set; }

        [DataMember]
        public virtual DbSet<AgentDetail> AgentDetails { get; set; }
        [DataMember]
        public virtual DbSet<AgentWebsite> AgentWebsites { get; set; }
        [DataMember]
        public virtual DbSet<FavouriteSearch> FavouriteSearchs { get; set; }
        [DataMember]
        public virtual DbSet<SaveSearch> SaveSearchs { get; set; }
        [DataMember]
        public virtual DbSet<UserAnalytic> UserAnalytics { get; set; }

    }
}
