using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataLayer
{
    [DataContract]
    public class AspNetUser
    {
        [DataMember]
        public String Id { get; set; }
        [DataMember]
        public String Email { get; set; }
        [DataMember]
        public Boolean EmailConfirmed { get; set; }
        [DataMember]
        public String PasswordHash { get; set; }
        [DataMember]
        public String SecurityStamp { get; set; }
        [DataMember]
        public String PhoneNumber { get; set; }
        [DataMember]
        public Boolean PhoneNumberConfirmed { get; set; }
        [DataMember]
        public Boolean TwoFactorEnabled { get; set; }
        [DataMember]
        public DateTime LockoutEndDateutc { get; set; }
        [DataMember]
        public Boolean LockoutEnabled { get; set; }
        [DataMember]
        public int AccessFailedCount { get; set; }
        [DataMember]
        public String UserName { get; set; }

    }
}
