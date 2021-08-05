using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №2
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            A = B = A != B ? A > B ? A : B : 0;
            System.Console.WriteLine($"A = {A}\nB = {B}\n");

            //Задача №3
            float operand1 = int.Parse(Console.ReadLine());
            float operand2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Операнд 1 : {operand1}\nОперанд 2 : {operand2}\nВыберите операцию:\n'+' '-' '*' '/'");
            string sign = Console.ReadLine();
            if (sign == "/" && operand2 == 0)
            {
                System.Console.WriteLine("На ноль делить нельзя!"); return;
            }
            float result = sign switch
            {
                "+" => operand1 + operand2,
                "=" => operand1 - operand2,
                "*" => operand1 * operand2,
                "/" => operand1 / operand2,
                _ => throw new ArgumentException("Недопустимая операция!!!")
            };
            System.Console.WriteLine($"{operand1} {sign} {operand2} = {result}");

            //Задача №4
            System.Console.WriteLine("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 100 && num >= 0)
                System.Console.WriteLine($"Ваше число входит в промежуток [{(num > 50 ? "51-100" : num > 35 ? "36-50" : num > 14 ? "15-35" : "0-14")}]");
            else
                System.Console.WriteLine("Ваше число не входит не в один из имеющих промежутков!");
        }
    }
}
