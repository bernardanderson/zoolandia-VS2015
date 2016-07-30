using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Praire : Habitat, ILandHabitat
    {
        public Praire(Animal[] animalName)
        {
            foreach (var animal in animalName)
            {
                this.inhabitants.Add(animal.name);
            }
        }

        public string description()
        {
            return "Praire Habitat";
        }

        public string temperature()
        {
            return "Arid, Dry Climate";
        }
    }
}
