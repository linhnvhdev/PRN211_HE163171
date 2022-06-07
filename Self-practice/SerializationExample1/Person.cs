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
    public class Person
    {
        // A public field.
        public bool IsAlive = true;
        // A private field.
        private int PersonAge = 21;
        // Public property/private data.
        private string _fName = string.Empty;
        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public override string ToString() =>
        $"IsAlive:{IsAlive} FirstName:{FirstName} Age:{PersonAge} ";
    }
}
