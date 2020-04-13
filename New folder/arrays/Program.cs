using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        //For convenience I have put all tasks into one program and commented them out, 
        //so one can be selected rather then four files, the first comment 
        //at each section shall state what task it is for.

        //Post note: I've been getting very stange word colouring with functions not matching properly
        //if you get this too and know what is causing it, please let me know.
        //I thought i was messing up the code when it kept miscolouring. - Scott
        static void Main(string[] args)
        // Array TASK 1
        // {
        //     int size = 5;
        //     string[] names = new string[size];

        //     Console.WriteLine("Please enter 5 names");
        //     for (int i = 0; i < names.Length; i++)
        //     {
        //         names[i] = (Console.In.ReadLine());
        //     }
        //     Console.WriteLine("Here are your names, but horizontal.");
        //     for (int i = 0; i < names.Length; i++)
        //     {
        //         Console.Write(names[i] + " ");
                
        //     }
        // }
            
        // Array TASK 2
        // {
            
        //     int[] values = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
        //     int sum = 0;
        //     for (int numCount = 0; numCount < values.Length; numCount++)
        //     {
        //         sum += values[numCount];
        //     }
        //     Console.WriteLine(sum);
        // }


        // List TASK 1
        // {
        //     // Write a program that reads in 5 numbers. It then asks the
        //     // user for another number and outputs whether the number 
        //     //has already been entered.

            
        //     List<int> numbers = new List<int> ();
        //     int size = 5;

        //     Console.WriteLine("Please enter an number");
        //     for (int i = 0; i < size; i++)
        //     {
        //         numbers.Add(Int32.Parse(Console.In.ReadLine()));
        //     }

        //     Console.WriteLine();
        //     int extraNumber = Int32.Parse(Console.In.ReadLine());
        //     if (numbers.Contains(extraNumber)){
        //         Console.WriteLine("You've entered this number previously in the list");
        //     }
        //     else
        //     {
        //         Console.WriteLine( "This is a new number in the list");
        //     }

        // }

        // List TASK 2
        // {

        //     // Write a program that reads in 5 numbers. It then asks the
        //     // user for another number and  will tell the user how many 
        //     //times a repeated number has been entered.

            
        //     List<int> numbers = new List<int> ();
        //     int size = 5;

        //     Console.WriteLine("Please enter 5 numbers");
        //     for (int i = 0; i < size; i++)
        //     {
        //         numbers.Add(Int32.Parse(Console.In.ReadLine()));
        //     }

        //     Console.WriteLine("Enter one last number");
        //     int extraNumber = Int32.Parse(Console.In.ReadLine());
        //     int repeated = 0; 
          
        //     if (numbers.Contains(extraNumber)){
        //          for (int i = 0; i < size; i++) {
        //             if (extraNumber == numbers[i]) {
        //                 repeated++; 
        //             }
                    
        //          }
        //         Console.WriteLine("You've entered this number previously in the list " + repeated + " times." );
        //     }
        //     else
        //     {
        //         Console.WriteLine( "This is a new number in the list");
        //     }

        // }

        //List TASK 3
        {

            List<string> endlessWordList = new List<string> ();
            string stop = "stop";
            Console.WriteLine("Feed me words. When you dont't want to feed me anymore, write stop.");
            for (int wordCount = 0; wordCount <= endlessWordList.Count; wordCount++)
            {
                 
                string input = Console.ReadLine();
                
                if (input == stop)
                {
                  //  endlessWordList.Add(input); if you want stop to be
                    endlessWordList.Reverse();
                    Console.WriteLine();
                    for (int i = 0; i < endlessWordList.Count; i++)
                    {
                        Console.WriteLine(endlessWordList[i]);
                    }
                    // Stop that pesky infinite recursion.
                    break;
                }
                else
                {
                    Console.WriteLine("Give me another!");
                    endlessWordList.Add(input);
                }
            }
        }
        //Only essential brackets after this point.
    }
}
