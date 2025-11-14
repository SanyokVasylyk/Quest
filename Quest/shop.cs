using System;

namespace TextQuest
{
    static class ShopService
    {
        public static void EnterShop(Game game)
        {
            Console.WriteLine($"Ти у магазині, здоров'я {game.player.Health} зброя {game.player.Strength} броня {game.player.Armor} баланс {game.player.Money}:");
            Console.WriteLine("1 - Здоров'я");
            Console.WriteLine("2 - Зброя");
            Console.WriteLine("3 - Броня");
            Console.WriteLine("4 - Вийти з магазину");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Здоров'я {game.player.Health} баланс {game.player.Money}:");
                    Console.WriteLine("1 - Покращити здоров'я на 5 (50 монет)");
                    Console.WriteLine("2 - Покращити здоров'я на 20 (180 монет)");
                    Console.WriteLine("3 - Покращити здоров'я на 50 (400 монет)");
                    Console.WriteLine("4 - Назад");
                    string choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "1":
                            if (game.player.Money >= 50)
                            {
                                game.player.Health += 5;
                                game.player.Money -= 50;
                                Console.WriteLine("Ти покращив здоров'я на 5 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "2":
                            if (game.player.Money >= 180)
                            {
                                game.player.Health += 20;
                                game.player.Money -= 180;
                                Console.WriteLine("Ти покращив здоров'я на 20 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "3":
                            if (game.player.Money >= 400)
                            {
                                game.player.Health += 50;
                                game.player.Money -= 400;
                                Console.WriteLine("Ти покращив здоров'я на 50 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "4":
                            EnterShop(game);
                            break;
                        default:
                            Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                            EnterShop(game);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Зброя {game.player.Strength} баланс {game.player.Money}:");
                    Console.WriteLine("1 - Покращити зброю на 5 (50 монет)");
                    Console.WriteLine("2 - Покращити зброю на 20 (180 монет)");
                    Console.WriteLine("3 - Покращити зброю на 50 (400 монет)");
                    Console.WriteLine("4 - Назад");
                    string choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "1":
                            if (game.player.Money >= 50)
                            {
                                game.player.Strength += 5;
                                game.player.Money -= 50;
                                Console.WriteLine("Ти покращив зброю на 5 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "2":
                            if (game.player.Money >= 180)
                            {
                                game.player.Strength += 20;
                                game.player.Money -= 180;
                                Console.WriteLine("Ти покращив зброю на 20 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "3":
                            if (game.player.Money >= 400)
                            {
                                game.player.Strength += 50;
                                game.player.Money -= 400;
                                Console.WriteLine("Ти покращив зброю на 50 одиниць");
                                EnterShop(game);
                            }
                            else
                            {
                                Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                            break;
                        case "4":
                            EnterShop(game);
                            break;
                        default:
                            Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                            EnterShop(game);
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine($"Броня {game.player.Armor} баланс {game.player.Money}:");
                    Console.WriteLine("1 - Покращити броню на 5 (50 монет)");
                    Console.WriteLine("2 - Покращити броню на 20 (180 монет)");
                    Console.WriteLine("3 - Покращити броню на 50 (400 монет)");
                    Console.WriteLine("4 - Назад");
                    string choice3 = Console.ReadLine();
                    switch (choice3)
                            {
                                case "1":
                                    if (game.player.Money >= 50)
                                    {
                                        game.player.Armor += 5;
                                        game.player.Money -= 50;
                                        Console.WriteLine("Ти покращив броню на 5 одиниць");
                                        EnterShop(game);
                                     }
                                    else
                                    {
                                        Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                                    break;
                                case "2":
                                    if (game.player.Money >= 180)
                                    {
                                        game.player.Armor += 20;
                                        game.player.Money -= 180;
                                        Console.WriteLine("Ти покращив броню на 20 одиниць");
                                        EnterShop(game);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                                    break;
                                case "3":
                                    if (game.player.Money >= 400)
                                    {
                                        game.player.Armor += 50;
                                        game.player.Money -= 400;
                                        Console.WriteLine("Ти покращив броню на 50 одиниць");
                                        EnterShop(game);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Недостатньо монет!");
                                EnterShop(game);
                            }
                                    break;
                                case "4":
                                    EnterShop(game);
                                    break;
                                default:
                                    Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                                    EnterShop(game);
                                    break;
                    }
                    break;
                        case "4":
                            Console.WriteLine("Ви виходите з крамниці.");
                            FirstChoiceService.FirstChoice(game);
                            break;
                        default:
                            Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                            EnterShop(game);
                            break;
            }
        }
    }
}
    
