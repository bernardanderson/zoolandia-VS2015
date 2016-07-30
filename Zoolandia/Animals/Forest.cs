using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Forest : Habitat, ILandHabitat
    {

        public Forest(Animal[] animalName)
        {
            foreach (var animal in animalName)
            {
                this.inhabitants.Add(animal.name);
            }
        }

        public string description()
        {
            return "Forest Habitat";
        }

        public string temperature()
        {
            return "Temperate";
        }
    }
}
