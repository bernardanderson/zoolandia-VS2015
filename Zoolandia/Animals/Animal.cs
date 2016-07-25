using System;

namespace Zoolandia.Animals
{
    public class Animal
    {

        public virtual string name { get; set; } = "Generic Animal";

        public string color { get; set; }

        public string height { get; set; }

        public int age { get; set; }

        public virtual void walk ()
        {
            Console.WriteLine("This animal is now walking");
        }

        public virtual void talk ()
        {
            Console.WriteLine("This animal is now talking");
        }

        public virtual void sleep ()
        {
            Console.WriteLine("This animal is now sleeping");
        }
    }

}