//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sampleprogram
//{
//    internal class rutik1
//    {
//        static void Main(string[] args)
//        {
//            ("\nthe total is: " + Total);
//            Console.WriteLine("\nthe Average is: " + Average);
//            Console.WriteLine("\nthe Percentage is" + Percentage);

//            //Q1:RADIUS OF A CIRCLE
//            Console.WriteLine("enter a radius: ");
//            double Radius = Convert.ToDouble(Console.ReadLine());
//            double Area = Math.PI * Radius * Radius;

//            Console.WriteLine($"the result is= {Area}");



//            //Q2:PERIMETER OF A RECTANGLE
//            int length = 5, breadth = 8;
//            int Perimeter = 2 * (length + breadth);
//            Console.WriteLine("\n\nperimeter of a rectangle " + Perimeter);




//            //Q3:FIND THIRD ANGLE OF A TRIANGLE
//            int A = 50, B = 70;
//            int C = 180 - (A + B);
//            Console.WriteLine("\n\nThe third angle of triangle is " + C);



//            //Q4:FIND TH GREATEST NUMBER  
//            Console.WriteLine("\n\nenter the num1: ");
//            int num1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the num2: ");
//            int num2 = Convert.ToInt32(Console.ReadLine());

//            if (num1 > num2)
//                Console.WriteLine($"{num1} is a greater number");
//            else
//                Console.WriteLine($"{num2} is a greater number");




//            //Q5:CALCULATE AREA OF EQUILATERAL TRIANGLE
//            Console.WriteLine("\n\nEnter the side of a triangle a = ");
//            double a = Convert.ToDouble(Console.ReadLine());

//            Area = (1.73 * a * a) / 4;
//            Console.WriteLine($"the area of a equilateral trianle is {Area}");



//            //Q6:CALCULATE THE TOTAL, AVERAGE, AND PERCENTAGE OF A 5 SUB?
//            int sub1 = 87, sub2 = 92, sub3 = 95, sub4 = 98, sub5 = 85, Total;
//            double Average, Percentage;

//            Total = sub1 + sub2 + sub3 + sub4 + sub5;
//            Average = Total / 5;
//            Percentage = Total * 100 / 500;

//            Console.WriteLine




//            Total = sub1 + sub2 + sub3 + sub4 + sub5;
//            Average = Total / 5;
//            Percentage = (Total / 500) * 100;




//            //Q8:CALCULATE COMPOUND INTEREST
//            int celsius = 30, Fahrenheit;
//            Fahrenheit = ((celsius * 9) / 5) + 32;

//            Console.WriteLine("The Fahrenheit is: " + Fahrenheit);
//        }
//    }
//}
