using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RestSharp
{
    public class Result
    {
        public Options options { get; set; }
        public string statusmsg { get; set; }
        public string rawout { get; set; }
        public int status { get; set; }
    }
}
