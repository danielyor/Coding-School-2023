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

        public enum CodeEnum
        {
            OilChange,
            TireChange,
            BrokenWindow,
            EngineChange,
            MirrorReplacement

        }

        public string Description { get; set; }

        public decimal Hours { get; set; }
        public CodeEnum Code { get; set; }
        
        public ServiceTask()
        {
            ID = Guid.NewGuid();
        }

        
    
    }
}
