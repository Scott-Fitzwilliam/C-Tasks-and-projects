using System;

namespace Objects_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the cookie
            Cookie.Colour rgb1 = new Cookie.Colour("White", 255, 255, 255);
            Cookie.Colour rgb2 = new Cookie.Colour("Yellow", 255, 255, 0);
            Cookie.Colour rgb3 = new Cookie.Colour();
            
            Cookie c1 = new Cookie(100, "Square", rgb2);
            Cookie c2 = new Cookie(50, "Burnt Traingle", rgb3);
            Cookie c3 = new Cookie(200, "Torus", rgb1);
            Cookie c4 = new Cookie(700, "Incendary", rgb2);

            Console.WriteLine("Cookie qualities " );
            c1.Print();
            c2.Print();
            c3.Print();
            c4.Print();
        }
    }
    //Set the cookie class
    class Cookie 
    {
        public int Weight;
        public string Shape;
        public Colour Clr;

        public Cookie()
        {
            this.Weight = 50;
            this.Shape = "Round";
            this.Clr = null;
        }
        public Cookie(int _Weight, string _Shape, Colour _Colour)
        {
            this.Weight = _Weight;
            this.Shape = _Shape;
            this.Clr = _Colour;
        }
        public void Print(){
            Console.WriteLine();
            Console.WriteLine("Weight " + Weight);
            Console.WriteLine("Shape " + Shape);
            Console.WriteLine("Colour " + Clr.Name);
        }

       public class Colour
        {
            public string Name;
            public int Red;
            public int Green;
            public int Blue;

            public Colour(){
                this.Name = "Black";
                this.Red = 0;
                this.Green = 0;
                this.Blue = 0;
            }
            public Colour(string _Name, int _Red, int _Green, int _Blue){
                this.Name = _Name;
                this.Red = _Red;
                this.Green = _Green;
                this.Blue = _Blue;
                // I do not know why this does not work
                if ((_Red > 255 && _Red < 0  )||( _Green > 255 && _Green < 0 )||( _Blue > 255 && _Blue < 0 ))
                {
                    throw new ArgumentException("Invalid RGB value: Must be between 0 and 255" );
                }
            }


        }

    }

}
//First you make the main class
//Give it attributes
//Create a basic constructors to give vaules to the attributes
// Then create operations


