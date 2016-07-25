using System;

namespace Zoolandia
{
    class AiluropodaBaconi : Ailuropoda
    {
        public AiluropodaBaconi() {
            this.name = "Generic Ailuropoda Baconi";
        }

        public AiluropodaBaconi(string sentName)
        {
            this.name = sentName;
        }

        public AiluropodaBaconi(int sentAge)
        {
            this.age = sentAge;
        }

        public AiluropodaBaconi(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Ailuropoda Baconi says 'I'm long extinct'!");
        }

        public override string isExtinct() {
            return "Extinct";
        }
    }
}