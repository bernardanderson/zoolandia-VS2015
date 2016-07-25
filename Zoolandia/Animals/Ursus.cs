using System;

namespace Zoolandia.Animals
{
    class Ursus : Animal
    {
        public int legs = 4;

        public string genus = "Ursus";

        public virtual string tailLength() {
            return "0 inches";
        }
    }
}