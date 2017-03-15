using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class ItemDetail
    {
        [DataMember]
        public IEnumerable<Item> Items
        {
            get
            {
                IEnumerable<Item> items = null;
                if (items == null)
                {
                    items = new List<Item>();
                }
                return items;
            }
            set { }
        }
        [DataMember]
        public string Title { get; set; }
    }
}