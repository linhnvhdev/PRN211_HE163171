using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationExample1
{
    [Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class JamesBondCar : Car
    {
        [XmlAttribute]
        public bool CanFly;
        [XmlAttribute]
        public bool CanSubmerge;
        public override string ToString()
        => $"CanFly:{CanFly}, CanSubmerge:{CanSubmerge} {base.ToString()}";
    }
}
