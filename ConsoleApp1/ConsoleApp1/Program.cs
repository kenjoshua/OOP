using System;

namespace dog1
{

    public class Animal
    {
        public string Aname { get; set; }
        private void name()
        {

            this.Aname = Console.ReadLine();

        }

        public void eat()
        {
            Console.WriteLine(Aname + " wants to eat [h]otdog, [s]teak, [c]hicken, [p]oison");
            string x = Console.ReadLine();

            if (x == "h")
            {
                Console.WriteLine(Aname + " eat the hotdog yum yun yummy");
            }
            if (x == "s")

            {
                Console.WriteLine(Aname + " eat the steak yum yun yummy");
            }
            if (x == "c")

            {
                Console.WriteLine(Aname + " eat the chicken yum yun yummy");
            }
            if (x == "p")

            {
                Console.WriteLine(Aname + " eat the poison " + Aname + " is dead idiot");
            }
        }
        public void sleep()
        {
            Console.WriteLine(Aname + " starting to sleep zzzzzz.");
        }

        public void drink()
        {
            Console.WriteLine(Aname + " starting to drink");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal animal = new Animal();

                Console.Write("your animal name: ");
                animal.Aname = Console.ReadLine();


                Console.WriteLine("welcome " + animal.Aname + " wants to? ([e]at, [s]leep, [d]rink)");
                string a = Console.ReadLine();

                if (a == "e")
                {
                    animal.eat();
                }
                else if (a == "s")
                {
                    animal.sleep();
                }
                else if (a == "d")
                {
                    animal.drink();
                }
            }
        }
    }
}
