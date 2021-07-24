using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftTruck.Client.Pages
{
    public class InfoBase : ComponentBase
    {
        public string Name { get; set; } = "Muhannad Sharfo";
        public int PhoneNumber { get; set; } = 12345678;

        public InfoBase()
        {
        }

        public InfoBase(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetNumber()
        {
            return PhoneNumber;
        }

    }
}
