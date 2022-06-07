using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationExample1
{
    public class Radio
    {
        public bool HasTweeters;
        public bool HasSubWoofers;
        public List<double> StationPresets;
        public string RadioId = "XF-552RR6";
        public override string ToString()
        {
            var presets = string.Join(",", StationPresets.Select(i => i.ToString()).ToList());
            return $"HasTweeters:{HasTweeters} HasSubWoofers:{HasSubWoofers} StationPresets: { presets}";
        }
    }
}
