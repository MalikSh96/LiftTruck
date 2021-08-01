using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftTruck.Client.Pages
{
    public class ServiceBase : ComponentBase
    {
        public string CarType { get; set; }
        public string ServiceProvided { get; set; }
        public string ServiceDescription { get; set; }

        public string SetCarType(string type)
        {
            return type;
        }

        public string SetServiceType(string servicetype)
        {
            return servicetype;
        }

        public string SetServiceDescription(string description)
        {
            return description;
        }
    }
}
