using System;

namespace Practice_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //instantiate a new car.
            //create the new engine, then pass that engine into car1.
            Engine e1 = new Engine(4, 500);
            Car c1 = new Car("ZXC987", 0, 0, 0, 0, e1);
            //This doesn't work because the construct needs 7 inputs or 5 inputs and 1 object input
            //Car c2 = new Car("ABC123", 5, 0, 0, 0);
            Car c2 = new Car("ABC123", 5, 0, 0, 0, 6, 200);

            Console.WriteLine("Before " + c1.en.NumCylinders);
            Console.WriteLine("Before " + c2.en.NumCylinders);
            //how you call parts inside things (gives you vroom vroom.)
            c1.en.Rev();

            
        }
    }
    //---------------------------------------------
    //class engine is an attribute of the car, therefore it needs to be added to car
    class Engine{
        public int NumCylinders;
        public int CylinderSize;

        public Engine(int nc, int cs){
            this.NumCylinders = nc;
            this.CylinderSize = cs;
        }

        public void Rev(){
            Console.WriteLine("Vroom Vroom");
        }

    }

    //----------------------------------------
    class Car
    {
        // attributes
        public string Rego;
        public int PassengerLimit;
        public int Passengers;
        public int Xcord;
        public int Ycord;
        //When referencing an object/class, you don't add int or string, you just add the name and tag(en).
        public Engine en;
        
        // -------------------------------------------
        //constructors

        public Car(){ 
            //'this' refers to this class, so it give priority the the string set above, the class scope.
            // appartently you can name the same variable twice as long it is has different scopes. Weird.
            //int Rego;
            //Rego = 10;
            this.Rego = "";
            this.PassengerLimit = 0;
            this.Passengers = 0;
            this.Xcord = 0;
            this.Ycord = 0;
            this.en = null;
        }
        public Car(string rego, int pl, int pass, int x, int y, Engine e){
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers= pass;
            this.Xcord = x;
            this.Ycord = y;
             //this uses the constructor for engine to give properties.
            this.en = e;
        }

        public Car(string rego, int pl, int pass, int x, int y, int nc, int cs){
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers= pass;
            this.Xcord = x;
            this.Ycord = y;
            // you can just create a new object directly here instead.
            this.en = new Engine(nc, cs);
        }

        // operations/ functions
        /// <summary>
        /// Adds number of newPassengers to passengers.!-- To remove passengers, provide negative newPassengers value.
        /// <summary>
        /// <param name="newPassengers"><param>

        //void Addpassengers(int newPassengers){
        //void RemovePassengers( int newPassengers){
         public void UpdatePassengers(int newPassengers){
             if (this.Passengers + newPassengers <= this.PassengerLimit && this.Passengers + newPassengers >= 0)
             {
                 this.Passengers += newPassengers;
             }
        }

        public void Move(int newX, int newY) {
            this.Xcord = newX;
            this.Ycord = newY;
        }

    }
}
