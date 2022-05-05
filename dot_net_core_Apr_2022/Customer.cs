using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dot_net_core_Apr_2022
{
    [Serializable]
    public class Customer
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("creditcard")]
        public string Creditcard { get; set; }
        [XmlElement("password")]
        public string Password { get; set; }
    }
}
