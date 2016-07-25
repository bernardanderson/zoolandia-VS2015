using System;

namespace Zoolandia.Animals
{
    class Zebu : Bos
    {
        public Zebu() {    
            this.name = "Generic Zebu";
        }

        public Zebu(string sentName)
        {
            this.name = sentName;
        }

        public Zebu(int sentAge)
        {
            this.age = sentAge;
        }

        public Zebu(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public string size { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Zebu says boo... boo... Ze-boo!");
        }

        public override string hasHorns() {
            return "Has Horns";
        }

    }
}