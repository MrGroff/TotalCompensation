using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCompensation
{
    public class EmployeeData
    {
        public string Employee { get; set; }
        [JsonProperty("timePunch")]
        public List<TimePunch> TimePunches { get; set; }
    }
}
