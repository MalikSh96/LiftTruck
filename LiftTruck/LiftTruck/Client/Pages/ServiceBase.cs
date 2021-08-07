using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftTruck.Client.Pages
{
    public class ServiceBase : ComponentBase
    {
        public string ServiceProvided { get; set; }
        public string Price { get; set; }
        public string AddOn { get; set; }

        public string SetServiceType(string servicetype)
        {
            ServiceProvided = servicetype;
            return ServiceProvided;
        }

        public string SetPrice(string price)
        {
            Price = price;
            return Price;
        }

        public string SetAddOn(string addOn)
        {
            AddOn = addOn;
            return AddOn;
        }
    }
}
