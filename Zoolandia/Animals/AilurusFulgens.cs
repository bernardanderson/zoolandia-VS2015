using System;

namespace Zoolandia
{
    class AilurusFulgens : Ailurus
    {
        public string hairStyle { get; set; }

        public AilurusFulgens() {
            this.name = "Generic Ailurus Fulgens";
        }

        public AilurusFulgens(string sentName)
        {
            this.name = sentName;
        }

        public AilurusFulgens(int sentAge)
        {
            this.age = sentAge;
        }

        public AilurusFulgens(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Ailurus Fulgens says Wha Wha!");
        }

        public override string isExtinct() {
            return "Not Extinct";
        }

    }
}