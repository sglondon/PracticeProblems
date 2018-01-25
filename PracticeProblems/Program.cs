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



            //Homework 1/23 create an array with 25 elements, the array contains girl's names
            //populate the array with a For loop
            //print to console every other element beginning with 0


            //string[] girlsName = new string[25];
            //for (int i = 0; i < girlsName.Length; i++)
            //{
            //    Console.WriteLine("Enter a girl's name " + girlsName[i]);                
            //    girlsName[i] = Console.ReadLine().ToUpper();
            //    Console.WriteLine();
            //    //   Console.WriteLine(i); checking the value of i                
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("We now have an array of girl's name with " + girlsName.Length + " elements. We will display every other element starting at 1.");
            //Console.WriteLine();
            //Console.WriteLine();


            //for (int i = 0; i < girlsName.Length; i++)
            //{              
            //    if ((i % 2) != 0)
            //    { Console.WriteLine(girlsName[i] + " element number, " + " " + i + ".");
            //        Console.WriteLine();
            //    }
            //}

            //class exercise with julie, kristin, divya & julian
            //figure out how to do the following
            //read 10 numbers from keyboard and find their sum and avg

            // int[] myNumbers = new int[10];
            // double sum = 0;
            // double average = 0;
            // for (int i = 0; i < myNumbers.Length; i++)
            // {
            //     Console.WriteLine("Please enter a number ");
            //     myNumbers[i] = int.Parse(Console.ReadLine());


            //}
            // for (int i = 0; i < myNumbers.Length; i++)
            // {
            //     sum = sum + myNumbers[i];
            // }

            // Console.WriteLine("The sum is " + sum);
            // average = sum / myNumbers.Length;
            // Console.WriteLine("The average is " + average);



            //using the debuger to step through the nested loop for practice


            int size = 5;                   //Equals the max number of columns and rows
            int i, k;                       //i equals columns and k = rows?
            for (i = 0; i <= size; i++)
            {
                for (k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
