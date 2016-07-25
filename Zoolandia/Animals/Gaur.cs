using System;

namespace Zoolandia
{
    class Gaur : Bos
    {
        public Gaur() {    
            this.name = "Generic Gaur";
        }

        public Gaur(string sentName)
        {
            this.name = sentName;
        }

        public Gaur(int sentAge)
        {
            this.age = sentAge;
        }

        public Gaur(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public string size { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Gaur says Ga-rawr!");
        }

        public override string hasHorns() {
            return "Has Horns";
        }
    }
}