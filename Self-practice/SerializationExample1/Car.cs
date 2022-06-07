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
    public class Car
    {
        public Radio TheRadio = new Radio();
        public bool IsHatchBack;
        public override string ToString()
        => $"IsHatchback:{IsHatchBack} Radio:{TheRadio.ToString()}";
    }
}
