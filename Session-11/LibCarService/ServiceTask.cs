using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class ServiceTask
    {
        public Guid ID { get; set; }

        public enum Tasks
        {
            ChangeAirFilter,
            ChangeTires,
            ChangeBattery,
            ChangeOil,
            FullService,
            RegularMaintenance,
            ReplaceSparkPlugs
        }

        public Tasks Code { get; set; }

        public string Description { get; set; }

        public decimal Hours { get; set; }

        public ServiceTask()
        {
            ID = Guid.NewGuid();
        }
    }
}
