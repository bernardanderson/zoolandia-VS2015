using System;

namespace Zoolandia.Animals
{
    class AiluropodaMicrota : Ailuropoda
    {
        public AiluropodaMicrota() {
            this.name = "Generic Ailuropoda Microta";
        }
        
        public AiluropodaMicrota(string sentName)
        {
            this.name = sentName;
        }

        public AiluropodaMicrota(int sentAge)
        {
            this.age = sentAge;
        }

        public AiluropodaMicrota(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }
        
        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Ailuropoda Microta says (we don't know it's sound)!");
        }

        public override string isExtinct() {
            return "Extinct";
        }
    }
}