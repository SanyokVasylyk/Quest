using System;

namespace TextQuest
{
    static class PlayerClassSelector
    {
        public static PlayerClass ChooseClass()
        {
            Console.WriteLine("Оберіть клас героя:");
            Console.WriteLine("1 - Лучник");
            Console.WriteLine("2 - Мечник");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return PlayerClass.Archer;
                case "2":
                    return PlayerClass.Swordsman;
                default:
                    Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                    return ChooseClass();
            }
        }
    }
}