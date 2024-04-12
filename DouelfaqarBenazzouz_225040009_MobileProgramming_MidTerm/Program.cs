using System;
using System.Numerics;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Text-based RPG!");
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName, 100, 10);
        Enemy enemy = new Enemy("Goblin", 50, 5);

        Console.WriteLine($"Welcome, {player.Name}! You are facing a {enemy.Name}.");

        while (true)
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine("You have defeated the enemy!");
                    break;
                }
                enemy.Attack(player);
            }
            else if (choice == "2")
            {
                Console.WriteLine("You ran away!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
