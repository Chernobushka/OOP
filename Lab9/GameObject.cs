using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GameObject
    {
        public int Health = 0;
        public int MaxHealth = 100;
        Random random = new Random();

        public GameObject()
        {
            Health = 100;
            MaxHealth = 100;
        }

        public GameObject(int hp)
        {
            Health = hp;
        }
        
        public GameObject(int max, int hp) : this(hp)
        {
            MaxHealth = max;
        }

        public void OnHeal(object sender, EventArgs e)
        {
            int heal = random.Next(10, 20);
            if (Health + heal >= MaxHealth)
                Health = MaxHealth;
            else
                Health += heal;
        }

        public void OnAttack(object sender, EventArgs e)
        {
            Health -= random.Next(5, 30);
            if (Health < 0)
                Health = 0;
            Console.WriteLine($"{this.ToString()} is dead!");
        }
    }
}
