using System;

namespace Zoolandia.Animals
{
    class PristinailurusBristoli : Ailurus
    {
        public string hairStyle { get; set; }

        public PristinailurusBristoli() {
            this.name = "Pristinailurus Bristoli";
        }

        public PristinailurusBristoli(string sentName)
        {
            this.name = sentName;
        }

        public PristinailurusBristoli(int sentAge)
        {
            this.age = sentAge;
        }

        public PristinailurusBristoli(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Pristinailurus Bristoli says Wha Wha (probably)!");
        }

        public override string isExtinct() {
            return "Extinct";
        }

    }
}