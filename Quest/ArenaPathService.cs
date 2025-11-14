using System;
using Quest;

namespace TextQuest
{
    static class ArenaPathService
    {
        public static void ArenaPath(Game game)
        {
            Console.WriteLine("\nТи прийшов на арену. Тут ти можеш битися з ворогами");
            Console.WriteLine("1 - Розпочати бій");
            Console.WriteLine("2 - Повернутись назад");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ArenaFightService.ArenaFight(game);
            }

            else if (choice == "2")
            {
                Console.WriteLine("\nТи вирішив не битися і повернутися назад.");
                FirstChoiceService.FirstChoice(game);
            }
            else
            {
                Console.WriteLine("Невірний вибір!");
                ArenaPath(game);
            }
            
        }
    }
}