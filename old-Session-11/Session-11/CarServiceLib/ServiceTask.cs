using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11.CarServiceLib
{
    public class ServiceTask
    {

        public Guid ID { get; set; }

        public enum Code
        {
            //prepei na doume pos tha doulepsei to enum me to code

        }

        public string Description { get; set; }

        public decimal Hours { get; set; }

        public ServiceTask()
        {

        }
    }
}