using System;

namespace Zoolandia.Animals
{
    class WildYak : Bos
    {
        public WildYak() {    
            this.name = "Generic Wild Yak";
        }

        public WildYak(string sentName)
        {
            this.name = sentName;
        }

        public WildYak(int sentAge)
        {
            this.age = sentAge;
        }

        public WildYak(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public string size { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Wild Yak says Yakity Yak, don't talk back!");
        }

        public override string hasHorns() {
            return "Has Horns";
        }
    }
}