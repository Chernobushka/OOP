using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void show(GameObject[] array)
            {
                Console.WriteLine("Health:");
                foreach (GameObject x in array)
                {
                    Console.WriteLine($"{x.Name} health is {x.Health}");
                }
                Console.WriteLine();
            }

            StringBuilder str = new StringBuilder("S1 S2 A...");
            Action<StringBuilder> action;
            action = StringMethods.AddBAfterS;
            action += StringMethods.DeleteSpaces;
            action += StringMethods.AddSpacesAfterPoints;
            action += StringMethods.DeleteCommas;
            action += StringMethods.DeleteLetterA;

            action(str);
            Console.WriteLine($"{str}\n");

            Game game = new Game();
            GameObject[] arr = new GameObject[3];
            arr[0] = new GameObject(100, 100);
            arr[1] = new GameObject(100, 50);
            arr[2] = new GameObject(3);

            game.Attack += arr[0].OnAttack;
            game.Attack += arr[2].OnAttack;
            game.Heal += arr[1].OnHeal;
            game.play();
            show(arr);
            game.Heal += arr[2].OnHeal;
            game.play();
            show(arr);
        }
    }
}
