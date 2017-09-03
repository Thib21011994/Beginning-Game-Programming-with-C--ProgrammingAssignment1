using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the welcome message.

            Console.WriteLine("Hello.");
            Console.WriteLine("");
            Console.WriteLine("This application will calculate the distance between two points and the angle between those points.");

            // Getting the coordinates from the user.

            Console.WriteLine("Please, enter a x value for the first point:");
            string string1X = Console.ReadLine();
            float point1X = float.Parse(string1X);
            Console.WriteLine("");

            Console.WriteLine("Please, enter a y value for the first point:");
            string string1Y = Console.ReadLine();
            float point1Y = float.Parse(string1Y);
            Console.WriteLine("");

            Console.WriteLine("Please, enter a x value for the second point:");
            string string2X = Console.ReadLine();
            float point2X = float.Parse(string2X);
            Console.WriteLine("");

            Console.WriteLine("Please, enter a y value for the second point:");
            string string2Y = Console.ReadLine();
            float point2Y = float.Parse(string2Y);
            Console.WriteLine("");

            // Caluculating deltaX and deltaY. 

            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // Calculating the distance between the two points using the Pythagorean Theorem (A² + B² = C²). 

            float valueA = (float)Math.Pow(deltaX,2);
            float valueB = (float)Math.Pow(deltaY, 2);
            float valueC = valueA + valueB;

            float distance = (float)Math.Sqrt(valueC);

            // Displaying the distance between the two points.

            Console.WriteLine("The distance between the two points is: " + (distance.ToString("F3")));

            // Calculating and displaying the angle between the two points.

            float radians = (float)Math.Atan2(deltaY, deltaX);
            float angle = (float)(180 * (radians / Math.PI));

            Console.WriteLine("The angle between the two points is: " + (angle.ToString("F3")) + " degrees");

            // printing the ending message.

            Console.WriteLine("");
            Console.WriteLine("Thank you for using this application, press Enter to quit.");
            Console.ReadLine();
        }
    }
}
