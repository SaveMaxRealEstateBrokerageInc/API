using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DataLayer
{
    /// <summary>
    /// This class is for dealing directly with database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public class DataService
    {
        /// <summary>
        /// Use this method for fetching all properties
        /// This method will return List of properties 
        /// </summary> 
        /// <returns>IEnumerable<PropertyDetail></returns>
        public static IEnumerable<PropertyDetail> GetProperties()
        {
            using (var db = new DataContext())
            {
                return db.PropertyDetails.Include("Business")
                                     .Include("Building")
                                     .Include("Land")
                                     .Include("PropertyAddress")
                                     .Include("OpenHouse")
                                     .Include("OpenHouse.Events")
                                     .Include("ParkingSpaces")
                                     .Include("ParkingSpaces.Parkings")
                                     .Include("Photo")
                                     .Include("Photo.PropertyPhotos")
                                     .Include("UtilitiesAvailable")
                                     .Include("UtilitiesAvailable.Utilities")
                                     .Include("AlternateURL")
                                     .Include("PropertyFeatures")
                                     .Include("Rooms")
                                     .Include("Rooms.RoomDetails")
                                     .Include("PropertyStatus")
                                     .Include("WalkScoreResult")
                                     .ToList();
            }
        }
        /// <summary>
        /// Use this method for fetching all propertyAgents
        /// It will return List of PropertyAgents
        /// </summary>
        /// <returns>IEnumerable<PropertyAgent></returns>
        public static IEnumerable<PropertyAgent> GetPropertyAgents()
        {
            using (var db = new DataContext())
            {
                return db.PropertyAgents.ToList();
            }
        }
        /// <summary>
        /// Use this method for fetching all AgentsPhones
        /// It will return List of AgentsPhone
        /// </summary>
        /// <returns>IEnumerable<AgentsPhone></returns>
        public static IEnumerable<AgentsPhone> GetAgentsPhones()
        {
            using (var db = new DataContext())
            {
                return db.AgentsPhones.ToList();
            }
        }
        /// <summary>
        /// Use this method for fetching all AgentDetails
        /// It will return List of AgentDetail object
        /// </summary>
        /// <returns>IEnumerable<AgentDetail></returns>
        public static IEnumerable<AgentDetail> GetAgentDetails()
        {
            using (var db = new DataContext())
            {
                return db.AgentDetails.ToList();
            }
        }
        /// <summary>
        /// Use this method for fetching all AgentWebsites
        /// It will return List of AgentWebsite
        /// </summary>
        /// <returns>IEnumerable<AgentWebsite></returns>
        public static IEnumerable<AgentWebsite> GetAgentWebsites()
        {
            using (var db = new DataContext())
            {
                return db.AgentWebsites.ToList();
            }
        }
        /// <summary>
        /// Use this method for inserting new property
        /// This method needs propertyDetail Object as parameter
        /// </summary>
        /// <param name="property"></param>
        public static void PostProperty(PropertyDetail property)
        {
            using (var db = new DataContext())
            {
                db.PropertyDetails.Add(property);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Use this method to delete particular propertyDetail Object
        /// This method needs SaveMax Id as parameter
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteProperty(int id)
        {
            using (var db = new DataContext())
            {
                PropertyDetail property = GetProperties().Where(e => e.ID == id).SingleOrDefault();
                db.PropertyDetails.Remove(property);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Use this method to update particular property
        /// This method needs SaveMaxId and Object of PropertyDetail
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newProperty"></param>
        /// <returns>PropertyDetail</returns>
        public static PropertyDetail PutProperty(int id, PropertyDetail newProperty)
        {
            using (var db = new DataContext())
            {
                PropertyDetail oldProperty = GetProperties().Where(e => e.ID == id).SingleOrDefault();
                oldProperty = newProperty;
                db.Entry(oldProperty).State = EntityState.Modified;
                db.SaveChanges();
                return oldProperty;
            }


        }
        /// <summary>
        /// get neighbourhood data for all cities
        /// </summary>
        /// <returns>list</returns>

        public static IEnumerable<NeighbourhoodDemographic> GetNeighbourhoodDemographics()
        {
            using (var db = new DataContext())
            {
                return db.NeighbourhoodDemographics.ToList();
            }

        }
        /// <summary>
        /// add new Neighbourhood(city) data 
        /// </summary>
        /// <param name="data"></param>


        public static void PostNeighbourhoodDemographic(NeighbourhoodDemographic data)
        {
            using (var db = new DataContext())
            {
                db.NeighbourhoodDemographics.Add(data);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// update city data by location Name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newData"></param>
        /// <returns>updated object</returns>

        public static NeighbourhoodDemographic PutNeighbourhoodDemographic(string id, NeighbourhoodDemographic newData)
        {
            using (var db = new DataContext())
            {
                NeighbourhoodDemographic oldData = GetNeighbourhoodDemographics().Where(e => e.LocationName == id).SingleOrDefault();
                oldData = newData;
                db.Entry(oldData).State = EntityState.Modified;
                db.SaveChanges();
                return oldData;
            }
        }
        /// <summary>
        /// delete neighbourhood data by locationId
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteNeighbourhoodData(int id)
        {
            using (var db = new DataContext())
            {
                NeighbourhoodDemographic data = GetNeighbourhoodDemographics().Where(e => e.LocationId == id).SingleOrDefault();
                db.NeighbourhoodDemographics.Remove(data);
                db.SaveChanges();
            }
        }
        public static void insertPropertyAnalytics(int id, string userId)
        {
            using (var db = new DataContext())
            {
                db.SaveChanges();
            }
        }
    }
}