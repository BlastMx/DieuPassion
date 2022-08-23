using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int romanNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ToRoman(romanNumber));

            Console.Write("\n");

            Console.WriteLine("Enter a number:");
            int value = Convert.ToInt32(Console.ReadLine());
            Pyramid(value);
        }

        public static void Pyramid(int number)
        {
            if ((number < 0) || (number > 10)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 10");

            int space = number + 4 - 1;
            int t = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", t++);
                }

                Console.Write("\n");
                space--;
            }
        }

        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3000)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3000");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
