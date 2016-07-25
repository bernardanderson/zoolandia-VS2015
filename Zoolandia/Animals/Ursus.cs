using System;

namespace Zoolandia
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