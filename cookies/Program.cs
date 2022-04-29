using System;
namespace cookies
{
    class Program
    {
        static void Main(string[] args)
        {

            Color redColor = new Color(255, 0, 0, "red");
            Color greenColor = new Color(0,255,0,"green");

            Cookie a = new Cookie(1000, "Circle", redColor);
            Cookie b = new Cookie(500, "Square", redColor);
            Cookie c = new Cookie(600, "Square", greenColor);
            Cookie d = new Cookie(700, "Square", greenColor);
            Console.WriteLine(a.getDetails());
        }
    }
}
