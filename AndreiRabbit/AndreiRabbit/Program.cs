using System;

namespace MyAwesomeRabbit
{
    class Program
    {
        //Model the Rabbit class knowing that:

        //A rabbit can have Blue, Red or Black eyes.
        //A rabbit's fur can be white, brown, black or grey.
        //It has a gender.
        //It has a birth date, and based on that you should be able to see how old the rabbit is.
        //We also know that a rabbit is a mammal that moves, sleeps and eats.
        static void Main(string[] args)
        {
            Rabbit myRabbit = new Rabbit(Eyes.red, Fur.white, Gender.male, new DateTime(2018, 05, 05));

            Console.WriteLine(myRabbit.MyDescription());
            Console.WriteLine();
            Console.WriteLine(myRabbit.MyAge());
            Console.WriteLine();
            Console.WriteLine(myRabbit.Moveing());
            Console.WriteLine();
            Console.WriteLine(myRabbit.Sleeping());
            Console.WriteLine();
            Console.WriteLine(myRabbit.Eating());
            Console.WriteLine();



        }
    }
}

