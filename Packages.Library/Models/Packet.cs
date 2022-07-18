using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Library.Models
{
    public class Packet
    {
        public long UnixTime { get; set; }
        public bool StateVoltage { get; set; }
    }
}
