using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Game
    {
        public event EventHandler Attack;
        public event EventHandler Heal;
        public void play()
        {
            Console.WriteLine("Game started!");
            if (Attack != null)
                Attack(this, null);
            Heal?.Invoke(this, null);
        }
    }
}
