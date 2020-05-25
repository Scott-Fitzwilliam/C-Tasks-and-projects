using System;

namespace myfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Input
            Console.WriteLine("Enter First name");
            string Firstname = Console.ReadLine( );

            Console.WriteLine("Enter Surname");
            string Lastname = Console.ReadLine( );

            Console.WriteLine("Enter StudentID");
            string UserName = Console.ReadLine( );

            Console.WriteLine("Enter year of birth");
            int YearOfB = Convert.ToInt32(Console.ReadLine( ));

            Console.WriteLine("Enter current year:");
            int CurrentY = Convert.ToInt32(Console.ReadLine( ));
           
           
            //processing
            string message = "Hello " + Firstname + " " + Lastname + 
            " and your Username is " + UserName;
            
           
            //Output
            Console.WriteLine(message + " and your age is " +
             ((CurrentY - YearOfB)) + "!");
            //input
            Console.ReadKey();

        }  
    }
}


