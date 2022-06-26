using System;

namespace Calculator
{
    public class Calculator
    {
        static void jumlahkan(int firstValue, string aritmatika, int secondValue)
        {
            switch(aritmatika)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    Console.WriteLine(firstValue / secondValue);
                    break;
                default:
                    Console.WriteLine("Masukkin yang bener ajg");
                    break;
            }
        }

        static void isian()
        {
            Console.WriteLine("\nMasukkan nilai pertama");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+ - * /");
            string? aritmatika = Console.ReadLine();
            
            Console.WriteLine("Masukkan nilai kedua");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            jumlahkan(firstValue, aritmatika, secondValue);
            isian();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator C# by Muhammad Taufiqurrahman 100% riil\n");
            isian();
            
        }
    }
}