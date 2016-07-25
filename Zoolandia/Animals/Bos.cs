using System;

namespace Zoolandia.Animals
{
    class Bos : Animal
    {
        public int legs = 4;

        public string genus = "Bos";

        public virtual string hasHorns() {
            return "Hornless";
        }
    }
}