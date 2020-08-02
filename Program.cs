using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson42
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthPercent, maxBar = 10, manaPercent;
            Console.WriteLine("Введите оставшийся процент хп и маны персонажа");
            healthPercent = Convert.ToInt32(Console.ReadLine());
            manaPercent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ, которым будет обозначаться элемент здоровья");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            DrawBar(healthPercent, maxBar, 0, ConsoleColor.Red, symbol);
            DrawBar(manaPercent, maxBar, 1, ConsoleColor.Blue, symbol);
        }

        static void DrawBar(int percent, int fullBar, int position, ConsoleColor color, char symbol = ' ')
        {
            Console.SetCursorPosition(0, position);
            Console.Write("[");
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            int health = (fullBar * percent) / 100;
            for (int i = 0; i < fullBar; i++)
            {
                if (i < health)
                    Console.Write(symbol);
                else
                    Console.Write(' ');
            }
            Console.ForegroundColor = defaultColor;
            Console.Write("]");
        }
    }
}
