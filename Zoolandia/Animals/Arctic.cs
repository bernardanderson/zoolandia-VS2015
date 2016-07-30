using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Arctic : Habitat, IPolarHabitat
    {
        public Arctic(Animal[] animalName)
        {
            foreach (var animal in animalName)
            {
                this.inhabitants.Add(animal.name);
            }
        }

        public string description()
        {
            return "Arctic Tundra";
        }

        public string cold()
        {
            return "Very Cold";
        }

    }
}
