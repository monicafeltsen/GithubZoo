using System;

namespace Zoo
{
    internal class Ferret : Animal
    {
        public string OwnerName { get; set; }
        public Ferret(string name, double weight, string ownerName) : base(name, weight)
        {
            OwnerName = ownerName;
        }
    }
}
