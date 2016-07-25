using System;

namespace Zoolandia.Animals
{
    class SimocyonBatalleri : Ailurus
    {
        public string hairStyle { get; set; }

        public SimocyonBatalleri() {
            this.name = "Generic Simocyon Batalleri";
        }

        public SimocyonBatalleri(string sentName)
        {
            this.name = sentName;
        }

        public SimocyonBatalleri(int sentAge)
        {
            this.age = sentAge;
        }

        public SimocyonBatalleri(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Simocyon Batalleri says (I'm long exinct)!");
        }

        public override string isExtinct() {
            return "Extinct";
        }

    }
}