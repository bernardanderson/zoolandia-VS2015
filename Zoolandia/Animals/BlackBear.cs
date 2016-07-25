using System;

namespace Zoolandia.Animals
{
    class BlackBear : Ursus
    {
        public BlackBear() {
            this.name = "Generic Black Bear";
        }

        public BlackBear(string sentName)
        {
            this.name = sentName;
        }

        public BlackBear(int sentAge)
        {
            this.age = sentAge;
        }

        public BlackBear(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("I'm a Black Bear!  Roar... ROAR!");
        }

        public override string tailLength() {
            return "3 inches";
        }

    }
}