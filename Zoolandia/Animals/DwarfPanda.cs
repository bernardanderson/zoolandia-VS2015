using System;

namespace Zoolandia
{
    class DwarfPanda : Ailuropoda
    {
        public DwarfPanda() {
            this.name = "Generic Dwarf Panda";
        }
        
        public DwarfPanda(string sentName)
        {
            this.name = sentName;
        }

        public DwarfPanda(int sentAge)
        {
            this.age = sentAge;
        }

        public DwarfPanda(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }
        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This Dwarf Panda says (we don't know it's sound)!");
        }

        public override string isExtinct() {
            return "Extinct";
        }
    }
}