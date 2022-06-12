using System;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playersGold;
            int playersCrystal;
            int costCrystal = 10;

            Console.Write("Сколько у вас золотых монет? :");
            playersGold = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько кристалов вы хотите приобрести по цене {costCrystal} монет за кристал ? :");
            playersCrystal = Convert.ToInt32(Console.ReadLine());
            playersGold -= playersCrystal * costCrystal;
            Console.WriteLine($"После сделки у вас осталось {playersGold} золота и {playersCrystal} кристалов");
        }
    }
}
