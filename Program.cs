using System;
using System.Collections.Generic;

namespace FullProject
{
    class Factory
    {
        static void Main(string[] args)
        {
            Factory MetalFactory = new Factory(); // создаем экземпляр класса под именем MetalFactory

            Console.Write("Какой вам нужен металл? ");
            string Metal = Console.ReadLine();

            Console.Write("Введите высоту: ");
            MetalFactory.Height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину: ");
            MetalFactory.Width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину: ");
            MetalFactory.Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Общий объем: " + MetalFactory.FullSize());

            double TotalCost = MetalFactory.FullSell(Metal);
            Console.WriteLine("Итоговая цена: " + TotalCost + " EUR");

            Console.ReadKey();
        }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }

        public int FullSize()
        {
            return Height * Width * Length;
        }

        public double FullSell(string metalName)
        {
            if (metals.TryGetValue(metalName, out var value))
            {
                double price = value.Price;
                return FullSize() * price;
            }
            else
            {
                Console.WriteLine("Металл не найден.");
                return 0;
            }
        }
        Dictionary<string, (string Currency, double Price)> metals = new Dictionary<string, (string, double)>
        {
            { "Gold", ("EUR", 55.0) },
            { "Silver", ("EUR", 0.6) },
            { "Copper", ("EUR", 0.06) },
            { "Aluminum", ("EUR", 0.01) },
            { "Steel", ("EUR", 0.008) },
            { "Platinum", ("EUR", 23.0) },
            { "Titanium", ("EUR", 0.02) }
        };
    }
}
