using System;
using TextQuest;

namespace Quest
{
    static class ArenaFightService
    {
        public static void ArenaFight(Game game)
        {
            Random random = new Random();

            while (true)
            {
                int roll = random.Next(0, 101); 
                Enemy enemy;

                if (roll < 33)
                {
                    enemy = new Enemy("Розбійник", 50, 15);
                }
                else if (roll > 66)
                {
                    enemy = new Enemy("Страж", 70, 10);
                }
                else
                {
                    enemy = new Enemy("Борець арени", 80, 20);
                }

                var result = FightService.StartFight(game.player, enemy);

                switch (result)
                {
                    case FightResult.Win:
                        Console.WriteLine("\nТи переміг! Що робити далі?");
                        Console.WriteLine("1 - Битися ще раз");
                        Console.WriteLine("2 - Покинути арену");
                        string afterWin = Console.ReadLine();
                        if (afterWin == "1")
                        {
                            
                            continue;
                        }
                        else if (afterWin == "2")
                        {
                            Console.WriteLine("\nТи покидаєш арену.");
                            FirstChoiceService.FirstChoice(game);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Невірний вибір. Повертаю тебе в меню арени.");
                            ArenaPathService.ArenaPath(game);
                            return;
                        }

                    case FightResult.Escape:
                        Console.WriteLine("\nТобі вдалося втекти від бою. Повертаєшся в меню арени.");
                        ArenaPathService.ArenaPath(game);
                        return;

                    case FightResult.Lose:
                        Console.WriteLine("\nТи програв бій... Гра закінчена.");
                        return;
                }
            }
        }
    }
}
