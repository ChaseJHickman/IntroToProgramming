using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal the player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int damage = 20;
            int level = 1;
            bool ready = true;
            string role = "none";

            //Prints welcome message
            Console.WriteLine("Hello traveler! What is your name?");
            string name = Console.ReadLine();

            //Asks the player to select a role from the given options
            Console.WriteLine("Welcome " + name + "! " + "Please select a role");
            Console.WriteLine("Press 1 for Knight role");
            Console.WriteLine("Press 2 for Wizard role");

            //Gets input from console, and updates player values
            char input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                health = 200;
                role = "Knight";
            }
            else if(input=='2')
            {
                damage = 40;
                role = "Wizard";
            }
            else
            {
                Console.WriteLine("Invalid input. Using default stats");
            }

            //Pringts player stats to the screen
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("PlayerLevel: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("You've been approached by a mysterious traveler.");
            Console.WriteLine("They offer you a strange beverage with a promise to boost your strength.");
            Console.WriteLine("Do you accept?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                health = 1;
                damage = 500;
                Console.WriteLine("You feel like you could destroy a mountain wiht one punch!");
                Console.WriteLine("Unfortunately it seems like both your legs are now broken");
            }
            else if(input == '2')
            {
                Console.WriteLine("You decline and continue your journey.");
            }
            else
            {
                Console.WriteLine("You stutter like a buffoon and you give up on the conversation and leave in a panicked hurry.");
                Console.WriteLine("The traveler was confused and slightly annoyed and chose to walk away to find someone else to drink with.");
                Console.WriteLine("You can hear people mutter under their breath as you begin to walk faster, knowing you where the center of attention.");
            }

            Console.Clear();

            Console.WriteLine("Press any key to continue");
            Console.WriteLine("You've come to a crossroad.");
            Console.WriteLine("You can go left or right. What way will you go?");
            Console.WriteLine("Press 1 for Left");
            Console.WriteLine("Press 2 for Right");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("You head off to a deep forest.");
                Console.WriteLine("A small pixie dashes through the trees and stops in front of you, curiously.");

            }
            else
        }
    }
}
