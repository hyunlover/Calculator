using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double num1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+,-,*,/):");
            char operation = Console.ReadLine()[0];

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 ==0)
                    {
                        Console.WriteLine("Ошибка! Нельзя делить на 0");
                        break;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ошибка! Неверная операция");
                    return;
            }
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();


        }
    }
}
