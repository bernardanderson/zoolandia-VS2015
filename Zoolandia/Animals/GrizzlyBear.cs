using System;

namespace Zoolandia.Animals
{
    class GrizzlyBear : Ursus
    {
        public GrizzlyBear() {
            this.name = "Grizzly Bear";
        }

        public GrizzlyBear(string sentName)
        {
            this.name = sentName;
        }

        public GrizzlyBear(int sentAge)
        {
            this.age = sentAge;
        }

        public GrizzlyBear(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("I'm a grizzly bear!  Gerrr... Gerrr!");
        }

        public override string tailLength() {
            return "5 inches";
        }

    }
}