using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cascadia
{
    class Encounters
    {
        static Random rand = new Random();
        public static void FirstEncounter()
        {

            Console.WriteLine("Your glary eyes pierce at him while he charges towards you!");            
            Console.ReadKey();
            Combat(false, "Player", 10, 100);
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;


            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                
                Console.WriteLine(p + " Power" + " / " + h + " Health");
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (H)eal   |");
                Console.WriteLine("=====================");

                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    Console.WriteLine("You charge forward, your weapon ready! Striking the monster");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = rand.Next(1, Program.currentPlayer.weaponValue) + rand.Next(1, 25);
                    Console.WriteLine("You have lost " +damage+ " health and dealt " +attack+ " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    Console.WriteLine("As the monster charges forward, you brace for impact!");
                    int damage = (p / 10) - Program.currentPlayer.armorValue;
                    int attack = rand.Next(1, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You have lost " + damage + " health and dealt " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You rush away from the monster, it strikes you.");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are trapped!");
                        Console.ReadKey();                        

                        }

                    else
                    {
                        Console.WriteLine("You have evaded damage!");
                        Console.ReadKey();
                    }

                }

                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("You frantically search for potions, but all you find are empty flasks...");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine("The monster attacks you! You have lost " + damage + " health!");

                            
                    }
                    else
                    {
                        Console.WriteLine("You reach for a potion and drink it.");
                        int potionValue = 20;
                        Console.WriteLine("You gain " + potionValue + " health.");
                        Program.currentPlayer.health += potionValue;
                        Console.WriteLine("You move forward and strike!");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine($"You lose {health} health");
                    }
                    Console.ReadKey();
                }   

                
                Console.ReadKey();
            }
        }
    }
}

