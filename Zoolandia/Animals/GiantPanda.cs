using System;

namespace Zoolandia
{
    class GiantPanda : Ailuropoda
    {
        public GiantPanda() {
            this.name = "Generic Giant Panda";
        }

        public GiantPanda(string sentName)
        {
            this.name = sentName;
        }

        public GiantPanda(int sentAge)
        {
            this.age = sentAge;
        }

        public GiantPanda(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Giant Panda says whoa!");
        }

        public override string isExtinct() {
            return "Not Extinct";
        }
    }
}