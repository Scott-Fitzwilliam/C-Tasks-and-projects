using System;

namespace Assignment_4_Functions_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine(PrintHello("Scott", "Fitzwilliam"));
           int a = calculate(77, 33);
           Console.WriteLine(a);
           //Another way of writing it.
           Console.WriteLine(calculate(77, 33));

           int prime = (int)17.9;
           Console.WriteLine(prime);
        }
    
        static string PrintHello(string Fname, string Lname){
            string sentence = "Hello " + "Fname" + " " + "Lname";
            return sentence;
        }

        static int calculate(int num1, int num2){
            //you do not declare nums here, they go in the called function
            // num1 = 77;
            // num2 = 33;
            int ans = num1 + num2;
            //returns value to Main function
            // return num1; would place 77 rather then 110 in main function
            return ans;

        }












    }
}
