using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftTruck.Client.Pages
{
    public class AboutUsBase : ComponentBase
    {
        public string History { get; set; }
        public string Name { get; set; } = "MyName IsThis";
        public int PhoneNumber { get; set; } = 12345678;
        public string Address { get; set; } = "This is the Address 123";

        public string SetHistory(string history)
        {
            return history;
        }
        public string GetName()
        {
            return Name;
        }

        public int GetNumber()
        {
            return PhoneNumber;
        }

        public string GetAddress()
        {
            return Address;
        }
    }
}
