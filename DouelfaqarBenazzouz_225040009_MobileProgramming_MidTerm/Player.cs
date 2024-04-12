using System;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name}!");
        enemy.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} has been defeated!");
            Environment.Exit(0);
        }
    }
}
