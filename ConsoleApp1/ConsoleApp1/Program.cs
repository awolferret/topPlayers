using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Server server = new Server();
        }
    }

    class Server
    {
        private List<Player> _players = new List<Player> { new Player("Killer", 10, 19), new Player("AlexDarkStalker98", 15, 11), new Player("Kirill99987", 20, 25), new Player("TimurAssasin", 14, 11), new Player("KtoProchitalTotSdohnet", 19, 20) };

        public Server()
        {
            ChooseTop();
        }

        private void ChooseTop()
        {
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("1. Сортировка по уровню");
                Console.WriteLine("2. Сортировка по силе");
                Console.WriteLine("3. Выход");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowTopByLevel();
                        break;
                    case "2":
                        ShowTopByPower();
                        break;
                    case "3":
                        isWorking = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowTopByLevel()
        {
            var topLevel = _players.OrderByDescending(player => player.Level);
            ShowTop(topLevel.ToList());
        }

        private void ShowTopByPower()
        {
            var topPower = _players.OrderByDescending(player => player.Power);
            ShowTop(topPower.ToList());
        }

        private void ShowTop(List<Player> list)
        {
            int topNumber = 3;

            for (int i = 0; i < topNumber; i++)
            {
                Console.WriteLine(list[i].Name + " Уровень: " + list[i].Level + " Сила: " + list[i].Power);
            }
        }
    }

    class Player
    { 
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }
    }
}