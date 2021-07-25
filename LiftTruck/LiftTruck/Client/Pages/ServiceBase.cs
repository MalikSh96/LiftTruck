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

        public string SetCarType(string type)
        {
            return type;
        }
    }
}
