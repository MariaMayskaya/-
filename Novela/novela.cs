using System;

namespace Novel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы просыпаетесь в лесу...");

            while (true)
            {
                Console.WriteLine("Что вы делаете?");
                Console.WriteLine("1. Осмотреться");
                Console.WriteLine("2. Пойти вперед");
                Console.WriteLine("3. Прислушаться");
                Console.WriteLine("4. Закончить игру");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                if (choice == "1") 
                {
                    Console.WriteLine("Вы видите тропинку и старый дом.");
                    Console.WriteLine("1. Пойти по тропинке");
                    Console.WriteLine("2. Подойти к дому");
                    Console.Write("Выберите действие: ");
                    string choice1 = Console.ReadLine();

                    if (choice1 == "1") 
                    {
                        Console.WriteLine("Тропинка приводит вас к реке. Ее можно переплыть или поискать мост.");
                        Console.WriteLine("1. Переплыть реку");
                        Console.WriteLine("2. Поискать мост");
                        Console.Write("Выберите действие: ");
                        string choice2 = Console.ReadLine();

                        if (choice2 == "1") 
                        {
                            Console.WriteLine("Во время переправы вас уносит течением. Вы чудом выбираетесь на берег, но потеряли все вещи.");
                            Console.WriteLine("Вы выжили, но остались ни с чем.");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Вы нашли старый мост. Он выглядит ненадежно.");
                            Console.WriteLine("1. Пойти по мосту");
                            Console.WriteLine("2. Вернуться в лес");
                            Console.Write("Выберите действие: ");
                            string choice4 = Console.ReadLine();

                            if (choice4 == "1") 
                            {
                                Console.WriteLine("Мост обрушился. Вы упали, но уцелели.");
                                Console.WriteLine("Вы нашли золотую монету");
                                Console.WriteLine("1. Пойти дальше");
                                Console.WriteLine("2. Отдохнуть");

                                string choice5 = Console.ReadLine();
                                if (choice5 == "1")
                                {
                                    Console.WriteLine("По пути вас встретил торговец, вы отдали ему монету, а он помог вам выбраться.");
                                    Console.WriteLine("Вы вышли из леса");
                                    Console.WriteLine("Поздравляю!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы стали жертвой волков!");
                                    Console.WriteLine("Игра окончена.");
                                    break;
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Вы вернулись в лес.");
                            }
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Дом оказался заброшенным. Внутри вы нашли старый сундук.");
                        Console.WriteLine("1. Открыть сундук");
                        Console.WriteLine("2. Уйти из дома");
                        Console.Write("Выберите действие: ");
                        string choice7 = Console.ReadLine();

                        if (choice7 == "1") 
                        {
                            Console.WriteLine("В сундуке вы нашли старую карту и немного еды.");
                            Console.WriteLine("1. Изучить карту");
                            Console.WriteLine("2. Съесть еду");
                            Console.Write("Выберите действие: ");
                            string choice8 = Console.ReadLine();

                            if (choice8 == "1")
                            {
                                Console.WriteLine("Карта показывает путь к выходу из леса.");
                                Console.WriteLine("Вы выбрались из леса!");
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("Еда оказалась испорченной. Вы заболели.");
                                Console.WriteLine("Вы умерли в заброшенном доме.");
                                break;
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Вы ушли из дома и заблудились.");
                            Console.WriteLine("Вы так и не смогли найти выход из леса.");
                            break;
                        }
                    }
                }
                else if (choice == "2") 
                {
                    Console.WriteLine("Вы идете вперед и натыкаетесь на медведя.");
                    Console.WriteLine("1. Сражаться");
                    Console.WriteLine("2. Убежать");
                    Console.Write("Выберите действие: ");
                    string choice12 = Console.ReadLine();

                    if (choice12 == "1") 
                    {
                        Console.WriteLine("Вы храбро сражаетесь, но медведь сильнее. Он вас съел.");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Вы убегаете и прячетесь на дереве.");
                        Console.WriteLine("1. Подождать, пока медведь уйдет");
                        Console.WriteLine("2. Спуститься и убежать в другую сторону");
                        string choice14 = Console.ReadLine();

                        if (choice14 == "1") 
                        {
                            Console.WriteLine("Медведь долго ждал, и решил уйти");
                            Console.WriteLine("Вы смогли убежать, поздравляю с хорошей концовкой!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Вы спрыгнули с дерева и убежали в другую сторону, но сломали ногу. ");
                            Console.WriteLine("Вы умерли от голода");
                            break;
                        }
                    }
                }
                else if (choice == "3") 
                {
                    Console.WriteLine("Вы слышите журчание ручья.");
                    Console.WriteLine("1. Пойти к ручью");
                    Console.WriteLine("2. Игнорировать звук");
                    Console.Write("Выберите действие: ");
                    string choice16 = Console.ReadLine();

                    if (choice16 == "1") 
                    {
                        Console.WriteLine("Вы нашли ручей. Вы напились и увидели тропинку вдоль ручья.");
                        Console.WriteLine("1. Пойти по тропинке");
                        Console.WriteLine("2. Выпить еще воды");
                        string choice17 = Console.ReadLine();

                        if (choice17 == "1") 
                        {
                            Console.WriteLine("Тропинка вывела вас из леса.");
                            Console.WriteLine("Поздравляю!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Вы выпили слишком много воды, вас разболелся живот, вы умерли.");
                            Console.WriteLine("Конец игры.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы пропустили шанс найти воду. Вас мучает жажда.");
                        Console.WriteLine("Вы умерли от жажды.");
                        break;
                    }
                }
                else if (choice == "4") 
                {
                    Console.WriteLine("Вы решили закончить игру.");
                    Console.WriteLine("Игра окончена. Ну, вы хотя бы попытались...");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                }
            }

            Console.WriteLine("Спасибо за игру!");
            Console.WriteLine("Спонсор mariamayskaya@mail.ru");
        }
    }
}
