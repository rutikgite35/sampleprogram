using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleprogram
{
    internal class assignement2_
    {
        static void Main(string[] args)
        {
            //swap a number 
            int P = 12, Q = 21, R;
            R = P;
            P = Q;
            Q = R;

            Console.WriteLine($"a= {P}");
            Console.WriteLine($"b= {Q}");

            //2nd swap a num
            int A = 5, B = 10;
            Console.WriteLine("\nBefore swap a= " + A);
            Console.WriteLine("Before swap b= " + B);
            A = A * B;
            B = A / B;
            A = A / B;
            Console.WriteLine("A= " + A);
            Console.WriteLine("B= " + B);

            //calculate percentage
            int physics = 78, chemistry = 68, maths = 73;
            float Percentage = (physics + chemistry + maths) / 3;


            if (Percentage > 80)
            {
                Console.WriteLine($"\nGrade A= {Percentage}%");
            }
            else if (Percentage > 70)
            {
                Console.WriteLine($"\nGrade B= {Percentage}%");
            }
            else if (Percentage > 60)
            { Console.WriteLine($"\nGrade C= {Percentage}"); }
            else if (Percentage < 50)
            { Console.WriteLine($"\nGrade D= {Percentage}"); }

            //check vowel
            Console.WriteLine("\nEnter a character: ");
            char character = Convert.ToChar(Console.ReadLine());
            if (character == 'a')
                Console.WriteLine("It is vowel");
            else if (character == 'e')
                Console.WriteLine("It is vowel");
            else if (character == 'i')
                Console.WriteLine("It is vowel");
            else if (character == 'o')
                Console.WriteLine("It is vowel");
            else if (character == 'u')
                Console.WriteLine("It is vowel");
            else
                Console.WriteLine("It is not vowel");

            //check num is positive pr negative
            Console.WriteLine("\nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num<0)
            {
                Console.WriteLine("the number is negative");
            }
            else if(num>0)
            {
                Console.WriteLine("the number is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("the number is zero");
            }

            //find maximum num out of 3 num(using logical operator)

            Console.WriteLine("enter a 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a 3rd number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1>n2&&n1>n3)
            {
                Console.WriteLine($"{n1} Greatest");
            }
            else if (n2>n1&&n2>n3)
            {
                Console.WriteLine($"{n2} Greatest");
            }
            else
            { 
                Console.WriteLine($"{n3} Greatest");
            }
        }
    }
}
