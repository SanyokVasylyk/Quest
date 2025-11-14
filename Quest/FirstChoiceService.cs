using System;

namespace TextQuest
{
    static class FirstChoiceService
    {
        public static void FirstChoice(Game game)
        {
            Console.WriteLine("Ти у селищі, вибери куди будеш йти:");
            Console.WriteLine("1 - Арена");
            Console.WriteLine("2 - Бій з босом");
            Console.WriteLine("3 - Магазин");
            Console.WriteLine("4 - Зберегти гру");
            Console.WriteLine("5 - Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ArenaPathService.ArenaPath(game);
                    break;
                case "2":
                    BossPathService.BossPath(game);
                    break;
                case "3":
                    ShopService.EnterShop(game);
                    break;
                case "4":
                    game.Save();
                    FirstChoice(game);
                    break;
                case "5":
                    Console.WriteLine("Вихід з гри. До зустрічі!");
                    break;
                default:
                    Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                    FirstChoice(game);
                    break;
            }
        }
    }
}