using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1/16 writing to the console


            //string fullName = "Susan London";
            //string favoriteCar = "Thunderbird";
            //string superHero = "Nancy Drew";

            //// this code writes the value of the vars to the console

            //Console.WriteLine(fullName);
            //Console.WriteLine(favoriteCar);
            //Console.WriteLine(superHero);
            //Console.WriteLine();
            //Console.WriteLine();

            ////the code below concatanates the text with the value of the variables 

            //string str = "Hello, my name is " + fullName + ". ";
            //System.Console.WriteLine(str);
            //string str1 = "My favorite car is a " + favoriteCar + ". ";
            //System.Console.WriteLine(str1);
            //string str2 = "My favorite superhero is " + superHero + ". ";
            //System.Console.WriteLine(str2);


            ////Homework 1/17 assigning values to variables and writing them to the console

            // //Lisa is cooking muffins, how many more cups does she need
            // float item = 7;
            // float item1 = 2;
            // Console.WriteLine(item - item1);

            // //Mike and his friends total bill
            // item = 4;
            // item1 = 13;
            // Console.WriteLine(item * item1);

            // //How many packs of diapers can you buy
            // item = 40;
            // item1 = 8;
            // Console.WriteLine(item / item1);

            // //How much is it worth to clean the attic
            // item = 29;
            // item1 = 41;
            // Console.WriteLine(item1 - item);

            // //How many miles did Pranav run
            // item = 47;
            // item1 = 30;
            // Console.WriteLine(item - item1);

            // //how many envelopes can you buy
            // item = 12;
            // item1 = 3;
            // Console.WriteLine(item / item1);


            // //how much did the salad cost
            // item = 5.12f;
            // item1 = 27.10f;
            // Console.WriteLine(item + item1);



            //Homework 1/18 concatenation and indexing


            Console.WriteLine("What is your name?");
            Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine();

            // name is cooking muffins, how many more cups does she need displayed using concatenation
            double item = 7;
            double item1 = 2;
            Console.WriteLine(name + " is cooking muffins. The recipe calls for 7 cups of sugar and she has added 2, how many more cups does she need? She needs " + (item - item1) + " cups.");
            Console.WriteLine();
            Console.WriteLine();

            ////Mike and friends are splitting a bill displayed using an index

            Console.WriteLine("What is your name?");
            string name0 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your friend's name?");
            string friend1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your friend's name?");
            string friend2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your friend's name?");
            string friend3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            item = 4;
            item1 = 13;
            double total = item * item1;

            Console.WriteLine("{0}, {1}, {2} and {3} are splitting a bill. If each paid $13 how much was the total bill? It was ${4}.", name0, friend1, friend2, friend3, total);

            Console.WriteLine();
            Console.WriteLine();

            //How many packs of diapers can you buy with $40? displayed with an index
            int dollars = 40;
            int pack = 8;
            int diapers = dollars / pack;
            Console.WriteLine("If diapers cost ${0} per pack and you have ${1}, how many packs can you buy? You can buy {2} packs of diapers.", dollars, pack, diapers);

            Console.WriteLine();
            Console.WriteLine();

            //How much is it worth to clean the attic displayed with an index

            Console.WriteLine("What is your name?");
            string newName = Console.ReadLine();
            Console.WriteLine();
            int worker = 29;
            int earn = 41;
            int earn1 = earn - worker;
            Console.WriteLine("{3} had ${0}. After cleaning the attic he has ${1}, How much did he earn cleaning? {3} earned ${2}.", worker, earn, earn1, newName);

            Console.WriteLine();
            Console.WriteLine();


            //How many miles did Pranav run? displayed with an index

            Console.WriteLine("What is your name?");
            string runner = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your friend's name?");
            string runner1 = Console.ReadLine();
            Console.WriteLine();
            int jRan = 47;
            int moreMiles = 30;
            int pRan = jRan - moreMiles;
            Console.WriteLine("{0} ran {3} more miles than {2}. {0} ran {1} miles. How many miles did {2} run? {2} ran {4} miles.", runner, jRan, runner1, moreMiles, pRan);

            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
