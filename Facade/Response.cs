using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Response
    {
        [JsonProperty("main")]
        public MainInfo Main { get; set; }
    }
}
