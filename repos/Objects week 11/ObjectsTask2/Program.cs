using System;
using System.Collections.Generic;


namespace ObjectsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //------------------------------------An absolute pain to impliment multiple inputs----------------------------------------
            Subject s1 = new Subject (new List<string>{"English", "Math", "MentalHealth" }, 2000);
            Subject s2 = new Subject (new List<string>{"Cooking", "Biology", "MentalHealth"}, 2004);

            Person p1 = new Person("Scott", "Fitzwilliam", "25/10/1996", 180, s1);
            Person p2 = new Person("Anna", "Gospel", "25/03/1997", 165, s2);
            Person p3 = new Person("Rodger", "Hill", "25/05/1992", 175, s1);

            /* Tasks */
            // Console.WriteLine(p1.id);
            // Console.WriteLine(p2.id);
            // Console.WriteLine(p3.id);
           
            // int result = functions.GetHeightDifference(p1.Height, p2.Height);
            // Console.WriteLine(result);
            // p1.GetFullName(p1.FirstName,p1.Surname);

            //shows all the subjects linked to object
            foreach (string i in p1.SubjectList)
            {
                Console.WriteLine(i);
            }
           
           Console.WriteLine();
            foreach (string i in p2.SubjectList)
            {
                Console.WriteLine(i);
            }
        }
    }

    class functions
    {
        public static int GetHeightDifference(int Height1, int Height2){
        //Finds the differnce in height between to person
        //objects which are input.
        //The easy way.
        //int result = Math.Abs(value1- value2);
        int heightdif;
        if (Height1 > Height2){
            heightdif = Height1 - Height2;
        }
        else
        {
            heightdif = Height2 - Height1;
        }
        return heightdif;
         }
    }

    class Subject{
        public List<string> Name;
        public int YearOfDelivery;

        //An absolute pain to impliment
        public Subject(List<string> _Name, int _YearOfDelivery){
            Name = _Name;
            YearOfDelivery = _YearOfDelivery;
        }
    }
    class Person
    {
        public string FirstName;
        public string Surname;
        public string DOB;
        public int Height;
        public int id;
        public Subject Sub;
        public List<string> SubjectList = new List<string> ();

        public void GetFullName(string FirstName, string Surname){
        Console.WriteLine(FirstName + " " + Surname); 
        }

        public int RandomID(){
        // Wasn't as complicated as i feared. The logic behind it is probably outrageous.
        Random rnd = new Random();
        this.id = rnd.Next(1000, 10000);
        return id;
        }
        /*
        To the Person class, add a property that is a list of subjects.  
        Add methods to Person to allow addition of new subjects and to 
        return or print a list of subjects associated with a person.
        */
        public List<string> NewSubject(){
            Console.WriteLine("What subject would you like to add for this person?");
            //lets you customer extra subject
            Sub.Name.Add(Console.In.ReadLine());

            //Merges specific subject object name list into SubjectList   
            SubjectList.AddRange(Sub.Name);
            //Never can have enough science. Also testing manual additions
            Console.WriteLine("Have some science as well \n");
            SubjectList.Add("science");
            return SubjectList;
        }

        public Person(string _FirstName, string _Surname, string _DOB, int _Height, Subject sub){
            this.FirstName = _FirstName;
            this.Surname = _Surname;
            this.DOB = _DOB;
            this.Height = _Height;
            //automatically assigns random id
            this.id = RandomID(); 
            this.Sub = sub;
            this.SubjectList = NewSubject();
            
            }
        public Person(){
            this.FirstName = "";
            this.Surname = "";
            this.DOB = "";
            this.Height = 0;
            this.id = RandomID(); 
            this.Sub = null;
            this.SubjectList = NewSubject();
        }

    }
}
