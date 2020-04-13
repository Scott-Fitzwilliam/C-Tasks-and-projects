using System;

namespace Assignment_3_repitition
{
    class Program
    {
        //Issues involing github prevented the submission of this on time. I wanted to apologise for that.
        static void Main(string[] args)
        {
            //
            {
                Console.WriteLine("Whom dares enters this code, by what name are you known?");
                string firstName = (Console.ReadLine());
                int NameReps = 10;
                while (NameReps > 0)
                {
                    Console.Write(firstName);
                    NameReps--;
                }
                Console.WriteLine();
            }
            {
                Console.WriteLine("What is your perferred name?");
                string firstName = (Console.ReadLine());
                Console.WriteLine("How many times would you like to see your name, you Egotist?");
                int NameReps = Int32.Parse(Console.ReadLine());
                while (NameReps > 0)
                {
                    Console.Write(firstName);
                    NameReps--;
                }
                Console.WriteLine("Your name shall reverbrate through this code into eternity! Well if it had memory anyway.");
                Console.WriteLine();
            }
            


            {
                Console.WriteLine("How many decending x's would you like?");
                int xRequested = Int32.Parse(Console.ReadLine());
                // xRequested = 6
                while(xRequested > 0)   
                {
                    for (int xCount = xRequested; xCount > 0; xCount--)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                    xRequested--;
                }   
            }
            
            {
                Console.WriteLine("How many accending x's would you like?");
                int MaxWidth = Int32.Parse(Console.ReadLine());
                for (int spaceCount = MaxWidth; spaceCount > 0; spaceCount--)
                {
                    int xRequired = MaxWidth - spaceCount;
                    for (int x = 0; x <= xRequired; x++)
                    {
                         Console.Write("x");
                    }
                    Console.WriteLine();
                }
            }

            {
                Console.WriteLine("How many centered decending x's would you like?");
                int MaxWidth = Int32.Parse(Console.ReadLine());


                for (int xRequired = MaxWidth; xRequired > 0; xRequired-=2)
                {
                    int spacesRequired = (MaxWidth - xRequired)/2;
                    while (spacesRequired > 0)
                    {
                        Console.Write(" ");
                        spacesRequired--;
                    }
                    for (int xCount = xRequired; xCount > 0; xCount--)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                }
                
            }

            {
                Console.WriteLine("How many centered accending x's would you like?");
                int MaxWidth = Int32.Parse(Console.ReadLine());
                int oddOrEven = MaxWidth % 2;

                for (int xRequired = oddOrEven; xRequired <= MaxWidth ; xRequired+=2)
                {
                    if (xRequired != 0)
                    {
                        int spacesRequired = (MaxWidth - xRequired)/2;
                        while (spacesRequired > 0)
                        {
                            Console.Write(" ");
                            spacesRequired--;
                        }
                        for (int xCount = xRequired; xCount > 0; xCount--)
                        {
                            Console.Write("x");
                        }
                        Console.WriteLine();
                    }
                    
                }
            }

        }
    }
}
