using System;

namespace Zoolandia
{
    class BrownBear : Ursus
    {
        public BrownBear() {
            this.name = "Generic Brown Bear";
        }

        public BrownBear(string sentName)
        {
            this.name = sentName;
        }

        public BrownBear(int sentAge)
        {
            this.age = sentAge;
        }

        public BrownBear(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("I'm a Brown Bear!  Whimper... Whimper!");
        }

        public override string tailLength() {
            return "2 inches";
        }

    }
}