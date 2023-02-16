using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public double Weight { get; set; }

        public string Name { get; set; }

        public Animal(string name, double weight) 
        {
            Weight = weight;
            Name = name;
        }
    }
}

