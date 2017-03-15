using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class Feature
    {
        [DataMember]
        public IEnumerable<ItemDetail> ItemDetails
        {
            get
            {
                IEnumerable<ItemDetail> itemDetails = null;
                if (itemDetails == null)
                {
                    itemDetails = new List<ItemDetail>();
                }
                return itemDetails;
            }
            set { }
        }
    }
}