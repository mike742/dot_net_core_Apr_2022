using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dot_net_core_Apr_2022
{
    [XmlInclude(typeof(Rectangle))]
    // [XmlInclude(typeof(Circle))]
    public class Shape
    {
        public virtual string Color { get; set; }
        public virtual string Name { get; set; }
    }
}
