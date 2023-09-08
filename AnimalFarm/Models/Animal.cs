using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        public string ToString(int value)
        {
            return value.ToString();
        }

    }
}
