using System;
using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Cascadia
{
    class Program
    {
        public static Player currentPlayer = new Player();
        
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void MagentaText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void YellowText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine(@"

██████╗ █████╗ ███████╗ ██████╗ █████╗ ██████╗ ██╗ █████╗ 
██╔════╝██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗██║██╔══██╗
██║     ███████║███████╗██║     ███████║██║  ██║██║███████║
██║     ██╔══██║╚════██║██║     ██╔══██║██║  ██║██║██╔══██║
╚██████╗██║  ██║███████║╚██████╗██║  ██║██████╔╝██║██║  ██║
 ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝
                    by Otto Hellwig                                                                                                                                        
");
            Console.ResetColor();
            
            MagentaText("Welcome to Cascadia! What is your name?");          
            var name = Console.ReadLine();            

            while (string.IsNullOrEmpty(name))
            {
                
                MagentaText("You need a name wanderer!");           
                name = Console.ReadLine();            
            }

            while (name.All(Char.IsLetter) == false)
            {
                MagentaText("That isn't a real name stranger, try again.");                
                name = Console.ReadLine();
            }

            MagentaText($"Nice to meet you, {name}. Please choose a race.");
            Race();
            
            Console.Clear();

            // BACK TO NEW MENU 
            // Story1();
            Story1();
        }

        public static void Race()
        {
            // Prompts Race menu in Start();

            YellowText("1. Human");
            YellowText("2. Elf");
            YellowText("3. Dwarf");            

            int Choice;
            Choice = Convert.ToInt32(Console.ReadLine());
                     
            if (Choice == 1)
            {
                int health = 100;
                int mana = 100;
                int stamina = 100;
            }
            if (Choice == 2)
            {
                int health = 75;
                int mana = 150;
                int stamina = 75;
            }
            if (Choice == 3)
            {
                int health = 125;
                int mana = 50;
                int stamina = 125;
            }


            switch (Choice)
            {
                case 1:
                    MagentaText("You have chosen human.\nYou have 100 health, 100 mana, and 100 mana.");                    
                    Console.ReadKey();                    
                    break;
                case 2:
                    MagentaText("You have chosen elf.\nYou have 75 health, 150 mana, and 75 mana.");                    
                    Console.ReadKey();
                    break;
                case 3:
                    MagentaText("You have chosen dwarf.\nYou have 125 health, 50 mana, and 125 mana.");                    
                    Console.ReadKey();
                    break;
                default:
                    MagentaText("That can't be! What are you?");                    
                    Race();
                    break;

            }


        }

        public static void Story1()
        {
            YellowText(@" █     █░ ▄▄▄       ██ ▄█▀▓█████     █    ██  ██▓███   ▐██▌ 
▓█░ █ ░█░▒████▄     ██▄█▒ ▓█   ▀     ██  ▓██▒▓██░  ██▒ ▐██▌ 
▒█░ █ ░█ ▒██  ▀█▄  ▓███▄░ ▒███      ▓██  ▒██░▓██░ ██▓▒ ▐██▌ 
░█░ █ ░█ ░██▄▄▄▄██ ▓██ █▄ ▒▓█  ▄    ▓▓█  ░██░▒██▄█▓▒ ▒ ▓██▒ 
░░██▒██▓  ▓█   ▓██▒▒██▒ █▄░▒████▒   ▒▒█████▓ ▒██▒ ░  ░ ▒▄▄  
░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▒ ▓▒░░ ▒░ ░   ░▒▓▒ ▒ ▒ ▒▓▒░ ░  ░ ░▀▀▒ 
  ▒ ░ ░    ▒   ▒▒ ░░ ░▒ ▒░ ░ ░  ░   ░░▒░ ░ ░ ░▒ ░      ░  ░ 
  ░   ░    ░   ▒   ░ ░░ ░    ░       ░░░ ░ ░ ░░           ░ 
    ░          ░  ░░  ░      ░  ░      ░               ░    
");

            MagentaText("You find yourself awake in a cold, dark room. You see a tall angry figure in the corner of the room.");


        }
    }
}



