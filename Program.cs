using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAS_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double gold; double price = 2; bool b = true; bool check = false;
            ConsoleKeyInfo press;
            do
            {
                try
                {
                    Console.Write("Введите имеющееся у Вас золото числом: ");
                    gold = Convert.ToDouble(Console.ReadLine());
                    double crystals = gold / price;
                    

                    while (gold > 0 || crystals > 0 && b)
                    {
                        Console.WriteLine($"Вы можете купить {crystals} кристаллов ");

                        Console.Write("Введите количество кристаллов, которые хотите купить: ");
                        double buy_crystals = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Нажмите F10, чтобы купить");
                        press = Console.ReadKey();
                        check = press.Key == ConsoleKey.F10;

                        while (check&& crystals >=buy_crystals&&gold>=price && buy_crystals>0)
                        {
                            double crystals_price = buy_crystals * price;
                            gold = gold - crystals_price;
                            crystals = crystals - buy_crystals;
                            Console.WriteLine($"Вы купили {buy_crystals} кристaлла. Остаток золота: {gold}. Количество оставшихся кристаллов: {crystals}");
                            check = false;
                        }
                        
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка! Введите количество числом. ");
                }

            }
            while (b);
        }
    }
}
