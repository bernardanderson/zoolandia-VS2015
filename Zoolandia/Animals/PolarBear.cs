using System;

namespace Zoolandia.Animals
{
    class PolarBear : Ursus
    {
        public PolarBear() {
            this.name = "Generic Polar Bear";
        }

        public PolarBear(string sentName)
        {
            this.name = sentName;
        }

        public PolarBear(int sentAge)
        {
            this.age = sentAge;
        }

        public PolarBear(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("I'm a Polar Bear!  It's COLD!!");
        }

        public override string tailLength() {
            return "1 inch";
        }

    }
}