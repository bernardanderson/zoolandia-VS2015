using System;

namespace Zoolandia.Animals
{
    class Ailurus : Animal
    {
        public int legs = 4;

        public string genus = "Ailurus";

        public virtual string isExtinct() {
            return "Extinct";
        }
    }
}