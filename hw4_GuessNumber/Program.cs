using System;

namespace hw4_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // вводим максимальное целое число диапазона
            Console.WriteLine("Введите максимальное целое число:");
            int maxNumber;
            while (!int.TryParse(Console.ReadLine(), out maxNumber))
            {
                Console.WriteLine($"Ошибка ввода. Введите целое число:");
            }

            Random r = new Random();
            int n = 0;

            //игра
            int gn;
            n = r.Next(0, maxNumber);
           

            Console.WriteLine($"\nУгадайте число внутри диапазона {maxNumber}:");

            while (!int.TryParse(Console.ReadLine(), out gn))
            {
                Console.WriteLine($"Ошибка ввода. Введите целое число внутри диапазона 0 - {maxNumber}:");
            }


            while (gn != n)
            {
                if (n < gn) { Console.Write("Введенное число больше загаданного"); }
                if (n > gn) { Console.Write("Введенное число меньше загаданного"); }
                Console.WriteLine("\n\nУгадайте число:");
                string ent = Console.ReadLine();
                if (ent.Length == 0) { Console.WriteLine($"\nЗагаданное число - {n}"); break; }
                if (!int.TryParse(ent, out gn))
                {
                  Console.WriteLine($"\nОшибка ввода. Введите целое число внутри диапазона 0 - {maxNumber}:");
                  while (!int.TryParse(Console.ReadLine(), out gn))
                  {
                        Console.WriteLine($"Ошибка ввода. Введите целое число внутри диапазона 0 - {maxNumber}:");
                        
                  }
                }
            }

            
            if (gn == n )Console.WriteLine($"\nВы угадали число - {n}. Игра закончена");

           
        }

    }

}
