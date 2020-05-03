using System;

namespace Assignment_4_Functions_Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Uncomment as required for each task to test them.*/

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            
            static void Task1(){
                Console.WriteLine(HelloFriend());
            }   
            
            static void Task2(){
                Console.WriteLine("Please input a name :");
                string name = Console.ReadLine();
                Console.WriteLine(HelloFriendname(name));
           }

            static void Task3(){
                Console.WriteLine("The sum of two numbers is: " + calculate(15, 16));
            }
            
            static void Task4(){
                Console.WriteLine("Please input a string: ");
                string testString = Console.ReadLine();
                Console.WriteLine(testString + " contains " + spaceCount(testString) + " spaces.");
            }

            static void Task5(){
                int[] arrayNumbers = new int[5] {5, 7, 3, 2, 9};
                Console.WriteLine(arraySum(arrayNumbers));
            }

            static void Task6(){
                Console.WriteLine("Enter a number: ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine(swapValue(input1, input2));
            }

            static void Task7(){
                Console.WriteLine("Enter a number ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("To what exponential power would you like to raise it to? ");
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine("So, the number" + input1 + " ^(to the power)" + input2 + " = " + youJustGotSquared(input1, input2));
            }

            static void Task8(){
                Console.WriteLine("Input a number: ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("The Fibonacci series of " + input1 + " numbers is :");
                    for (int i = 0; i < input1; i++)
                    {
                        Console.Write(FibonacciSeries(i) + " ");
                    }
            }

            static void Task9(){
                Console.WriteLine("Input a number: ");
                int input1 = int.Parse(Console.ReadLine());
                    if (primalityTest(input1) == true) {
                        Console.WriteLine(input1 + " is a prime number");
                    }
                    else {
                        Console.WriteLine(input1 + " is not prime number"); 
                    }
            }

            static void Task10(){
                Console.WriteLine("Input a number: ");
                string input1 = Console.ReadLine();
                Console.WriteLine("The sum of the digits of the number" + input1 + " is: " + ShoeStringSumation(input1));
            }

             static void Task11(){
                Console.WriteLine("Input a number: ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("The factorial of " + input1 + "! is " + TheXFactor(input1));
             }

            static void Task12(){
                Console.WriteLine("Input a number: ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("The Fibonacci of the " + input1 + "th term is " + FibonacciTerm(input1));
            }

        }

        /* Task 1 Function */
        static string HelloFriend(){
           string FriendGreeting = "Welcome Friends!" + "\nHave a nice day!";
           return FriendGreeting;
        }
        /* Task 2 Function */
        static string HelloFriendname(string name){
           string FriendGreeting = "Welcome friend " + name +  "!\nHave a nice day!" ;
           return FriendGreeting;
        }
        /* Task 3 Function */
        static int calculate(int num1, int num2){
            int ans = num1 + num2;
            return ans;
        }
        /* Task 4 Function */
        static int spaceCount(string sentence){
            int spaceCount = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' '){
                    spaceCount++;
                }
            }
            return spaceCount;
        }
        /* Task 5 Function */
        static int arraySum(int[] arrayNumbers){
            int result = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {   
            result += arrayNumbers[i];
            }
            return result;
        }
        /* Task 6 Function */
        static string swapValue(int num1, int num2){
            int tempNumber = num1;
            num1 = num2;
            num2 = tempNumber;
            string swapped = "Now the 1st number is: " + num1 + ", and the 2nd number is: " + num2;
            return swapped;
        }
        /* Task 7 Function */
        static int youJustGotSquared(int num1, int num2){
            //exponentialResult must = 1 to account for num1^0 = 1
            int exponentialResult = 1;
            for (int i = 0; i < num2; i++)
            {
                exponentialResult = exponentialResult * num1;
            }
            return exponentialResult;
        }
        /* Task 8 Function */
         static int FibonacciSeries(int num1){
            int FibonacciPreviousNum = 0;
            int FibonacciNextNum = 1;
            //This is the first entry, i know the order below doesn;t make sense logically. This is the only way it works. If you have feedback on how to better label the variables, please give me feedback to improve.

            for (int i = 0; i < num1; i++)
            {

                int FibonacciBeginning = FibonacciPreviousNum;
                FibonacciPreviousNum =  FibonacciNextNum;
                FibonacciNextNum += FibonacciBeginning;
            }
            return FibonacciPreviousNum;
        }       
        /* Task 9 Function */
        static bool primalityTest(int possiblePrime){
            //2 & 3 are primes so if possiblePrime <= 3 and > 1, you have a prime.
            if (possiblePrime <= 3)
            {
                return possiblePrime > 1;
            }
            else if (possiblePrime % 2 == 0 || possiblePrime % 3 == 0)
            {
                return false;
            }

            int algorithm  = 5;
            while (algorithm*algorithm <= possiblePrime)
            {
                if (possiblePrime % algorithm == 0 || possiblePrime % (algorithm + 2) == 0 )
                {
                    return false;
                }
                algorithm = algorithm + 5;
            }
            return true;
        }
        /* Task 10 Function */
        static int ShoeStringSumation(string notGoingToEndWell){
                int Result = 0;
                
                for (int i = 0; i < notGoingToEndWell.Length; i++)
                {
                    char stringToChar = (notGoingToEndWell[i]); 
                    int CharToInt = int.Parse(stringToChar.ToString());

                    Result += CharToInt;
                }
                return Result;
        }
        /* Task 11 Function */
         static int TheXFactor(int didNotFactorForThatIntoMyPlans){
            int result = 1;
            for (int i = didNotFactorForThatIntoMyPlans; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }
        /* Task 12 Function */
        //God it feels good to recycle code.
            static int FibonacciTerm(int num1){
            int FibonacciPreviousNum = 0;
            int FibonacciNextNum = 1;

            for (int i = 0; i < num1; i++)
            {

                int FibonacciBeginning = FibonacciPreviousNum;
                FibonacciPreviousNum =  FibonacciNextNum;
                FibonacciNextNum += FibonacciBeginning;
            }
            return FibonacciPreviousNum;
        }       
    }
}

