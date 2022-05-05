using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dot_net_core_Apr_2022
{
    [XmlRoot("customers")]
    public class customers
    {
        [XmlElement("customer")]
        public List<Customer> Customers { get; set; }
    }
}
