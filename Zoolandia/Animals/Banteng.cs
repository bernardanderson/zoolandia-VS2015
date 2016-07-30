using System;

namespace Zoolandia.Animals
{
    class Banteng : Bos
    {
        public Banteng() {    
            this.name = "Banteng";
        }

        public Banteng(string sentName)
        {
            this.name = sentName;
        }

        public Banteng(int sentAge)
        {
            this.age = sentAge;
        }

        public Banteng(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public string size { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Banteng says 7... 8... 9... Banteng!");
        }
        public override string hasHorns() {
            return "Has Horns";
        }
    }
}