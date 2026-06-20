using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI_Platform.Models
{
    public class ConfigParameter
    {
        public string PlcIP { get; set; } = "192.168.1.10";
        public int PlcPort { get; set; } = 10003;
        public string CommandAddress { get; set; } = "D4920";
        public string ResultAddress { get; set; } = "D4922";
        public bool UseFakePLC { get; set; } = true;
    }
}
