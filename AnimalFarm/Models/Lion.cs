using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    internal class Lion : Animal
    {
        private int power;

        public int Power
        {
            get { return power; }
            set
            {
                if (value < 0)
                {
                    power = 0;
                    throw new ArgumentException("Power must be greater than 0");
                }
                power = value;
            }
        }

        public Lion(string name, int legs, int power) : base(name, legs)
        {
            Power = power;
        }
    }
}
