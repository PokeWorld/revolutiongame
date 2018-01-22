using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmethsytConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Amethyst Console!");
            Console.WriteLine("This is where you can add money to your account, cheat upgrades, and more!");
            Console.WriteLine("To get started, type 'help'");
            Console.Write("cheat >> ");
            #region Console
            var input = Console.ReadLine();

            if(input == "help")
            {
                Console.WriteLine("Cheat Console Help:");
                Console.WriteLine("help == List commands");
                Console.Write("cheat >> ");
            }
            



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            #endregion

        }
    }
}
