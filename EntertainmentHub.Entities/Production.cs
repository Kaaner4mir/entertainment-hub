using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.Entities
{
    public class Production
    {
        public int ProductionID { get; set; }
        public string ProductionName { get; set; }
        public string ProductionCategory { get; set; }
        public decimal ProductionRuntime { get; set; }
        public int inTheaters { get; set; }
        public int ProductionYear { get; set; }
        public int DirectorID { get; set; }
    }
}
