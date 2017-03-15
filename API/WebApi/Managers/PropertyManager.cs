using WebApi.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApi.Managers
{
    /// <summary>
    /// This class is for PropertyMethods
    /// It uses SaveMaxDataService class of SaveMax Project
    /// </summary>
    public class PropertyManager
    {
        /// <summary>
        /// Use this method for fetching all properties
        /// This method will return List of properties 
        /// </summary> 
        /// <returns>List<PropertyAPIModel></returns>
        public static List<PropertyAPIModel> GetProperties()
        {
            var properties = DataService.GetProperties();
            List<PropertyAPIModel> propertiesList = new List<PropertyAPIModel>();
            if (propertiesList != null)
            {
                foreach (var property in properties)
                {
                    PropertyAPIModel propertyObject = new PropertyAPIModel();
                    propertyObject.ID = property.ID.ToString();
                    if (property.PropertyAddress != null)
                    {
                        propertyObject.Address = property.PropertyAddress.StreetAddress;
                    }
                    //propertiesModel.buildIn = propertyDetail;
                    propertyObject.Category = property.PropertyType;

                    List<AgentData> agents = GetAgentInfo(property);
                    if (agents.Count > 0)
                    {
                        AgentData agent = agents[0];
                        Contact contact = new Contact();
                        if (agent != null)
                        {
                            contact.Name = agent.Name;
                            contact.PhoneNumber = agent.Phone;
                            contact.Web = agent.Web;
                        }
                        propertyObject.Contact = contact;
                        propertyObject.Agents = agents;
                    }
                    else
                    {
                        propertyObject.Contact = null;
                        propertyObject.Agents = null;
                    }

                    ICollection<Item> generalItems = new List<Item>();
                    ICollection<Item> amentiesItems = new List<Item>();
                    Building building = property.Building;
                    Type buildingFieldsType = typeof(Building);
                    PropertyInfo[] buildingPropertyInfo = buildingFieldsType.GetProperties();
                    for (int i = 1; i < buildingPropertyInfo.Length - 3; i++)
                    {
                        Item item = new Item();
                        item.Caption = buildingPropertyInfo[i].Name;
                        if (property.Building != null)
                        {
                            item.Value = building.GetType().GetProperty(buildingPropertyInfo[i].Name).GetValue(building, null);
                        }
                        item.ValueType = buildingPropertyInfo[i].PropertyType.Name;
                        generalItems.Add(item);
                    }
                    PropertyFeature propertyFeature = property.PropertyFeatures;
                    Type propertyFeatureFieldsType = typeof(PropertyFeature);
                    PropertyInfo[] propertyFeaturePropertyInfo = propertyFeatureFieldsType.GetProperties();
                    for (int i = 1; i < propertyFeaturePropertyInfo.Length - 1; i++)
                    {
                        Item item = new Item();
                        item.Caption = propertyFeaturePropertyInfo[i].Name;
                        if (property.PropertyFeatures != null)
                        {
                            item.Value = propertyFeature.GetType().GetProperty(propertyFeaturePropertyInfo[i].Name).GetValue(propertyFeature, null);
                        }
                        item.ValueType = propertyFeaturePropertyInfo[i].PropertyType.Name;
                        amentiesItems.Add(item);
                    }
                    ICollection<ItemDetail> itemDetails = new List<ItemDetail>();
                    ItemDetail generalItemsDetail = new ItemDetail();
                    ItemDetail amenitiesItemsDetail = new ItemDetail();
                    generalItemsDetail.Items = generalItems;
                    generalItemsDetail.Title = "General";
                    amenitiesItemsDetail.Items = amentiesItems;
                    amenitiesItemsDetail.Title = "Amenities";
                    itemDetails.Add(generalItemsDetail);
                    itemDetails.Add(amenitiesItemsDetail);
                    Feature feature = new Feature();
                    propertyObject.Features = itemDetails;

                    Mapdata mapdata = new Mapdata();
                    Annotation annotation = new Annotation();
                    if (property.WalkScoreResult != null)
                    {
                        annotation.Latitude = property.WalkScoreResult.Snapped_lat;
                        annotation.Longitude = property.WalkScoreResult.Snapped_lon;
                        annotation.Title = "Molestie et wisi.";
                    }
                    mapdata.Annotations = annotation;
                    propertyObject.Mapdata = mapdata;

                    //propertiesModel.code = propertyDetail;
                    propertyObject.Description = property.LocationDescription;
                    propertyObject.Intention = property.TransactionType;
                    propertyObject.Pictures = null;
                    propertyObject.Price = property.Price;
                    String[] tags = { property.Building.BedroomsTotal + " Beds", property.Building.BathroomTotal + " Baths", property.PropertyType };
                    propertyObject.Tags = tags;
                    if (property.Building != null)
                    {
                        propertyObject.Surface = property.Building.SizeInterior;
                    }
                    if (property.PropertyAddress != null)
                    {
                        propertyObject.Title = property.PropertyAddress.PropertyTitle;
                    }
                    propertiesList.Add(propertyObject);
                }
            }

            return propertiesList;
        }

        /// <summary>
        /// Use this method for fetching particular property by id
        /// This method needs SaveMaxId as Parameter 
        /// It will return Single Property as Output
        /// </summary>
        /// <param name="id"></param>
        /// <returns>PropertyAPIModel</returns>
        public static PropertyAPIModel GetProperty(int id)
        {
            PropertyAPIModel propertyObject = null;
            var property = DataService.GetProperties().Where(e => e.ID == id).SingleOrDefault();
            if (property != null)
            {
                propertyObject = new PropertyAPIModel();
                propertyObject.ID = property.ID.ToString();
                if (property.PropertyAddress != null)
                {
                    propertyObject.Address = property.PropertyAddress.StreetAddress;
                }
                //propertiesModel.buildIn = propertyDetail;
                propertyObject.Category = property.PropertyType;

                List<AgentData> agents = GetAgentInfo(property);
                if (agents.Count > 0)
                {
                    AgentData agent = agents[0];
                    Contact contact = new Contact();
                    if (agent != null)
                    {
                        contact.Name = agent.Name;
                        contact.PhoneNumber = agent.Phone;
                        contact.Web = agent.Web;
                    }
                    propertyObject.Contact = contact;
                    propertyObject.Agents = agents;
                }
                else
                {
                    propertyObject.Contact = null;
                    propertyObject.Agents = null;
                }


                ICollection<Item> generalItems = new List<Item>();
                ICollection<Item> amentiesItems = new List<Item>();
                Building building = property.Building;
                Type buildingFieldsType = typeof(Building);
                PropertyInfo[] buildingPropertyInfo = buildingFieldsType.GetProperties();
                for (int i = 1; i < buildingPropertyInfo.Length - 3; i++)
                {
                    Item item = new Item();
                    item.Caption = buildingPropertyInfo[i].Name;
                    if (property.Building != null)
                    {
                        item.Value = building.GetType().GetProperty(buildingPropertyInfo[i].Name).GetValue(building, null);
                    }
                    item.ValueType = buildingPropertyInfo[i].PropertyType.Name;
                    generalItems.Add(item);
                }
                PropertyFeature propertyFeature = property.PropertyFeatures;
                Type propertyFeatureFieldsType = typeof(PropertyFeature);
                PropertyInfo[] propertyFeaturePropertyInfo = propertyFeatureFieldsType.GetProperties();
                for (int i = 1; i < propertyFeaturePropertyInfo.Length - 1; i++)
                {
                    Item item = new Item();
                    item.Caption = propertyFeaturePropertyInfo[i].Name;
                    if (property.PropertyFeatures != null)
                    {
                        item.Value = propertyFeature.GetType().GetProperty(propertyFeaturePropertyInfo[i].Name).GetValue(propertyFeature, null);
                    }
                    item.ValueType = propertyFeaturePropertyInfo[i].PropertyType.Name;
                    amentiesItems.Add(item);
                }
                ICollection<ItemDetail> itemDetails = new List<ItemDetail>();
                ItemDetail generalItemsDetail = new ItemDetail();
                ItemDetail amenitiesItemsDetail = new ItemDetail();
                generalItemsDetail.Items = generalItems;
                generalItemsDetail.Title = "General";
                amenitiesItemsDetail.Items = amentiesItems;
                amenitiesItemsDetail.Title = "Amenities";
                itemDetails.Add(generalItemsDetail);
                itemDetails.Add(amenitiesItemsDetail);
                Feature feature = new Feature();
                propertyObject.Features = itemDetails;

                Mapdata mapdata = new Mapdata();
                Annotation annotation = new Annotation();
                if (property.WalkScoreResult != null)
                {
                    annotation.Latitude = property.WalkScoreResult.Snapped_lat;
                    annotation.Longitude = property.WalkScoreResult.Snapped_lon;
                    annotation.Title = "Molestie et wisi.";
                }
                mapdata.Annotations = annotation;
                propertyObject.Mapdata = mapdata;

                //propertiesModel.code = propertyDetail;
                propertyObject.Description = property.LocationDescription;
                propertyObject.Intention = property.TransactionType;
                propertyObject.Pictures = null;
                propertyObject.Price = property.Price;
                String[] tags = { property.Building.BedroomsTotal + " Beds", property.Building.BathroomTotal + " Baths", property.PropertyType };
                propertyObject.Tags = tags;
                if (property.Building != null)
                {
                    propertyObject.Surface = property.Building.SizeInterior;
                }
                propertyObject.Title = property.PropertyAddress.PropertyTitle;
            }

            return propertyObject;

        }

        /// <summary>
        /// Use this method for fetching Agents with respect to property
        /// This method needs PropertyDetail object as parameter 
        /// It will return List of agents as output
        /// </summary>
        /// <param name="propertyDetail"></param>
        /// <returns>List<AgentInfo></returns>
        public static List<AgentData> GetAgentInfo(PropertyDetail property)
        {
            int SavemaxID = property.ID;
            var propertyAgentsList = DataService.GetPropertyAgents();
            var agentsPhoneList = DataService.GetAgentsPhones();
            var agentDetailsList = DataService.GetAgentDetails();
            var agentWebsiteList = DataService.GetAgentWebsites();
            List<AgentData> agentList = new List<AgentData>();
            using (var db = new DataContext())
            {
                List<int> agentIds = propertyAgentsList.Where(e => e.SavemaxID == SavemaxID).Select(e => e.AgentID).ToList();

                foreach (var id in agentIds)
                {
                    AgentData agent = new AgentData();
                    AgentsPhone agentsPhone = agentsPhoneList.Where(e => e.AgentID == id).FirstOrDefault();
                    AgentDetail agentDetails = agentDetailsList.Where(e => e.AgentID == id).FirstOrDefault();
                    AgentWebsite agentWebsite = agentWebsiteList.Where(e => e.AgentID == id).FirstOrDefault();
                    agent.AgentId = id;
                    if (agentsPhone != null)
                    {
                        agent.Phone = agentsPhone.Value;
                        agent.ContactType = agentsPhone.ContactType;
                        agent.PhoneType = agentsPhone.PhoneType;
                    }
                    else
                    {
                        agent.Phone = null;
                        agent.ContactType = null;
                        agent.PhoneType = null;
                    }
                    if (agentDetails != null)
                    {
                        agent.Name = agentDetails.Name;
                        agent.Designations = agentDetails.Designations;
                        agent.Position = agentDetails.Position;
                    }
                    else
                    {
                        agent.Name = null;
                        agent.Designations = null;
                        agent.Position = null;
                    }
                    if (agentWebsite != null)
                    {
                        agent.Web = agentWebsite.Value;
                        agent.WebsiteType = agentWebsite.WebsiteType;
                    }
                    else
                    {
                        agent.Web = null;
                        agent.WebsiteType = null;
                    }
                    agentList.Add(agent);
                }
            }
            return agentList;
        }
        /// <summary>
        /// Use this method for inserting new property
        /// This method needs propertyDetail object as parameter
        /// </summary>
        /// <param name="property"></param>
        public static void PostProperty(PropertyDetail property)
        {
            DataService.PostProperty(property);
        }
        /// <summary>
        /// Use this method to Delete particular property
        /// This method needs SaveMaxId as parameter
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteProperty(int id)
        {
            DataService.DeleteProperty(id);
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
            PropertyDetail property = DataService.PutProperty(id, newProperty);
            return property;
        }
        /// <summary>
        /// Use this method for Searching particular property by SaveMaxId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>PropertyDetail</returns>
        public static PropertyDetail SearchProperty(int id)
        {
            return DataService.GetProperties().Where(e => e.ID == id).SingleOrDefault();
        }
    }
}