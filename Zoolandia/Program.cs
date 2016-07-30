using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            AilurusFulgens ailurusFulgens = new AilurusFulgens();
            ailurusFulgens.height = "1ft";
            ailurusFulgens.color = "red";
            ailurusFulgens.hairStyle = "bushy";

            Console.WriteLine($"You have a {ailurusFulgens.color} ailurus fulgens named {ailurusFulgens.name} who is {ailurusFulgens.height} tall. It's hair is {ailurusFulgens.hairStyle}.");
            ailurusFulgens.talk();
            Console.WriteLine("***\n");

            GrizzlyBear grizzlyBear = new GrizzlyBear();
            grizzlyBear.height = "9ft";
            grizzlyBear.color = "brown";
            grizzlyBear.age = 16;

            Console.WriteLine($"You have a {grizzlyBear.age} year old, {grizzlyBear.color} grizzly bear named {grizzlyBear.name} who is {grizzlyBear.height} tall.");
            grizzlyBear.talk();
            Console.WriteLine("***\n");

            GiantPanda giantPanda = new GiantPanda();
            giantPanda.height = "5ft";
            giantPanda.color = "black and white";
            giantPanda.BambooType = "green and tasty";

            Console.WriteLine($"You have a {giantPanda.color} panda bear named {giantPanda.name} who is {giantPanda.height} tall. It likes to eat {giantPanda.BambooType} bamboo.");
            giantPanda.talk();
            Console.WriteLine("***\n");

            WildYak wildYak = new WildYak();
            wildYak.height = "4ft";
            wildYak.color = "red";
            wildYak.size = "600lbs";

            Console.WriteLine($"You have a {wildYak.color} manatee named {wildYak.name} who is {wildYak.height} tall. It weighs {wildYak.size}.");
            wildYak.talk();
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly1 = new GrizzlyBear("Fred");
            Console.WriteLine($"This overloaded grizzly bear is named {overloadedGrizzly1.name}");
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly2 = new GrizzlyBear(5);
            Console.WriteLine($"This overloaded grizzly bear is {overloadedGrizzly2.age} years old");
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly3 = new GrizzlyBear("Jubb Jubb", 23);
            Console.WriteLine($"This overloaded grizzly bear is named {overloadedGrizzly3.name} and is {overloadedGrizzly3.age} years old");
            Console.WriteLine("***\n");
            */

            AiluropodaBaconi ailuropodaBaconi = new AiluropodaBaconi();
            AiluropodaMicrota ailuropodaMicrota = new AiluropodaMicrota();
            GiantPanda giantPanda = new GiantPanda();
            DwarfPanda dwarfPanda = new DwarfPanda();

            AilurusFulgens ailurusFulgens = new AilurusFulgens();
            PristinailurusBristoli pristinailurusBristoli = new PristinailurusBristoli();
            SimocyonBatalleri simocyonBatalleri = new SimocyonBatalleri();

            Banteng banteng = new Banteng();
            Gaur gaur = new Gaur();
            WildYak wildYak = new WildYak();
            Zebu zebu = new Zebu();

            BlackBear blackBear = new BlackBear();
            BrownBear brownBear = new BrownBear();
            GrizzlyBear grizzlyBear = new GrizzlyBear();
            PolarBear polarBear = new PolarBear();

            Praire praire = new Praire(new Animal[] { banteng, gaur, wildYak, zebu });
            Console.WriteLine($"These are the animals in the praire:");
            foreach (var animal in praire.inhabitants)
            {
                Console.WriteLine($"{animal}");
            }
                Console.WriteLine("***\n");

            Forest forest = new Forest(new Animal[] { blackBear, brownBear, grizzlyBear, ailurusFulgens, pristinailurusBristoli, simocyonBatalleri,
               ailuropodaBaconi, ailuropodaMicrota, giantPanda, dwarfPanda});
            Console.WriteLine($"These are the animals in the forest:");
            foreach (var animal in forest.inhabitants)
            {
                Console.WriteLine($"{animal}");
            }
            Console.WriteLine("***\n");

            Arctic arctic = new Arctic(new Animal[] { polarBear });
            Console.WriteLine($"These are the animals in the arctic:");
            foreach (var animal in arctic.inhabitants)
            {
                Console.WriteLine($"{animal}");
            }
            Console.WriteLine("***\n");


            Console.ReadKey();

        }
    }
}
