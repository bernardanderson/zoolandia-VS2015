using System;

namespace Zoolandia.Animals
{
    class Ailuropoda : Animal
    {

        public string BambooType { get; set; }

        public string genus = "Ailuropoda";

        public virtual string isExtinct() {
            return "Extinct";
        }
    }
}