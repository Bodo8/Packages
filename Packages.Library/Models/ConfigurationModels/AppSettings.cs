using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Library.Models.ConfigurationModels
{
    public class AppSettings
    {
        public int PercentSetToZero { get; set; }
        public bool RunCheckCheckboxes { get; set; }
        public bool RunCheckAvailability { get; set; }
    }
}
