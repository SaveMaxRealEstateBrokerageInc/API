using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class Mapdata
    {
        [DataMember]
        public Annotation Annotations
        {
            get
            {
                Annotation annotation = null;
                if (annotation == null)
                {
                    annotation = new Annotation();
                }
                return annotation;
            }
            set { }
        }
    }
}