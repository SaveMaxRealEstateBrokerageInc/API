using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    [DataContract]
    public class ErrorViewModel
    {
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string Links { get; set; }
    }
}