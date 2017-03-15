using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class PropertyAPIModel
    {
        private Contact contact;
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string BuildIn { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public Contact Contact { get; set; }
        [DataMember]
        public ICollection<AgentData> Agents 
        {
            //get
            //{
            //    ICollection<AgentData> agents = null;
            //    if (agents == null)
            //    {
            //        agents = new List<AgentData>();
            //    }
            //    return agents;
            //}
            //set { } 
            get; set;
        }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public ICollection<ItemDetail> Features
        {
            //get
            //{
            //    ICollection<ItemDetail> itemDetails = null;
            //    if (itemDetails == null)
            //    {
            //        itemDetails = new List<ItemDetail>();
            //    }
            //    return itemDetails;
            //}
            //set { }
            get; set;
        }
        [DataMember]
        public string Intention { get; set; }
        [DataMember]
        public Mapdata Mapdata
        {
            //get
            //{
            //    Mapdata mapdata = null;
            //    if (mapdata == null)
            //    {
            //        mapdata = new Mapdata();
            //    }
            //    return mapdata;
            //}
            //set { }
            get; set;
        }
        [DataMember]
        public string Pictures { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Surface { get; set; }
        [DataMember]
        public Array Tags { get; set; }
        [DataMember]
        public string Thumbnail { get; set; }
        [DataMember]
        public string Title { get; set; }
    }
}