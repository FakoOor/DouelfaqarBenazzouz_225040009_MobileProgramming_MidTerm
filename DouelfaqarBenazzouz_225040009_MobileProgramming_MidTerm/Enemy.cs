using System;

class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks {player.Name}!");
        player.TakeDamage(Damage);
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