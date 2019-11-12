using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GameObject
    {
        static int count = 0;
        public int Health = 0;
        public int MaxHealth = 100;
        public string Name;
        Random random = new Random();

        public GameObject()
        {
            Name = "GameObject " + count++;
            Health = 100;
            MaxHealth = 100;
        }

        public GameObject(int hp)
        {
            Name = "GameObject " + count++;
            Health = hp;
        }
        
        public GameObject(int max, int hp) : this(hp)
        {
            MaxHealth = max;
        }

        ~GameObject()
        {
            count--;
        }

        public void OnHeal(object sender, EventArgs e)
        {
            int heal = random.Next(10, 20);
            Console.WriteLine($"{Name} health + {heal}");
            if (Health + heal >= MaxHealth)
                Health = MaxHealth;
            else
                Health += heal;
        }

        public void OnAttack(object sender, EventArgs e)
        {
            int damage = random.Next(5, 30);
            Health -= damage;
            Console.WriteLine($"{Name} health - {damage}");
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} is dead!");
            }
        }
    }
}
