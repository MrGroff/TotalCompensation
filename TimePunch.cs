using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Globalization;
namespace TotalCompensation
{
    public class TimePunch
    {
        public string Job { get; set; }

        //[JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd HH:mm:ss")]
        public DateTimeOffset Start { get; set; }

        //[JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd HH:mm:ss")]
        public DateTimeOffset End { get; set; }
    }
}
