using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorywork0102
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите размерность массива => ");
                    ulong n = Convert.ToUInt32(Console.ReadLine());
                    if (n == 0 || n < 0)
                    {
                        Console.WriteLine("Введена неверная размерность. Повторите еще ");

                    }
                    else
                    {
                        ulong[] array = new ulong[n];
                        Random random = new Random();
                        double result = 0;
                        Console.Write("Элементы массива => ");
                        for (ulong i = 0; i < array.Length; i++)
                        {
                            array[i] = (ulong)random.Next(1, 55);
                            Console.Write(" " + array[i]);
                            result += array[i];
                        }
                        Console.WriteLine("\nСреднеарифметическое элементов массива => " + result / array.Length);
                    }

                }
                catch
                {
                    Console.WriteLine("Ошибка ввода размерности массива. ");
                    Console.WriteLine("Подсказка. Возможно Вы ввели букву или символ");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}