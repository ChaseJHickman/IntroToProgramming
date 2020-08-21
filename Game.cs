using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool GameOver = false;
            while (GameOver == false)
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
                char input = ' ';
                Console.WriteLine();
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        health = 200;
                        damage = 40;
                        role = "Knight";
                    }
                    else if (input == '2')
                    {
                        health = 150;
                        damage = 35;
                        role = "Wizard";
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
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
                Console.Clear();
                if (input == '1')
                {
                    health = 1;
                    damage = 500;
                    Console.WriteLine("You feel like you could destroy a mountain wiht one punch!");
                    Console.WriteLine("However, after a few moments pass you notice you begin to feel awfully numb");
                    Console.WriteLine("Soon you can't feel a bone in your body and realize that you're paralized");
                    Console.WriteLine("Game over! Play again");
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (input == '1')
                    {
                        continue;
                    }
                    else if (input == '2')
                    {
                        GameOver = true;
                        break;
                    }
                    else
                    {
                        GameOver = true;
                        break;
                    }

                }
                else if (input == '2')
                {
                    Console.WriteLine("You decline and continue your journey.");
                }
                else
                {
                    Console.WriteLine("You stutter like a buffoon and you give up on the conversation and leave in a panicked hurry.");
                    Console.WriteLine("The traveler was confused and slightly annoyed and chose to walk away to find someone else to drink with.");
                    Console.WriteLine("You can hear people mutter under their breath as you begin to walk faster, feeling as if you were the center of attention.");
                    Console.WriteLine("You decide to prematurely end your adventure out of embarrassment.");
                    Console.WriteLine("Game Over! Play again?");
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (input == '1')
                    {
                        continue;
                    }
                    else if (input == '2')
                    {
                        GameOver = true;
                        break;
                    }
                    else
                    {
                        GameOver = true;
                        break;
                    }
                }

                Console.Clear();

                Console.WriteLine("Press any key to continue");
                Console.WriteLine("You've come to a crossroad.");
                Console.WriteLine("You can go left or right. What way will you go?");
                Console.WriteLine("Press 1 for Left");
                Console.WriteLine("Press 2 for Right");
                input = Console.ReadKey().KeyChar;
                Console.Clear();
                if (input == '1')
                {
                    Console.WriteLine("You head off to a deep forest.");
                    Console.WriteLine("A small pixie dashes through the trees and stops in front of you, curiously.");
                    Console.WriteLine("What will you do?");
                    Console.WriteLine("Press 1 to talk");
                    Console.WriteLine("Press 2 to attack");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (input == '1')
                    {
                        Console.WriteLine("You wave to the pixie and greet it welcomingly.");
                        Console.WriteLine("The pixie gestures to follow it and flys further into the forest, but stops after a second to wait for you.");
                        Console.WriteLine("Will you follow the pixie?");
                        Console.WriteLine("Press 1 for yes.");
                        Console.WriteLine("Press 2 for no.");
                        input = Console.ReadKey().KeyChar;
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("You try to punch the pixie for being annoying, and in your way");
                        Console.WriteLine("The pixie quickly dodges your fist and speeds through the trees in fear");
                        Console.WriteLine("Do you follow the pixie");
                        Console.WriteLine("Press 1 for yes.");
                        Console.WriteLine("Press 2 for no, and continue on your original path.");
                        input = Console.ReadKey().KeyChar;
                        Console.Clear();
                    }

                }
                else if (input == '2')
                {
                    Console.WriteLine("As you head down the right pathway, you stumble upon an abandoned church.");
                    Console.WriteLine("Do you go inside, or will you continue on?");
                    Console.WriteLine("Press 1 to go inside");
                    Console.WriteLine("Press 2 to continue on the path");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (input == '1')
                    {
                        Console.WriteLine("You push open the old squeeky church doors and head inside.");
                        Console.WriteLine("You step over and around the rubble and search around the area.");
                        Console.WriteLine("You soon realize that there isn't anything of value in this church, but this place might come in handy later.");

                    }
                }
                else
                {
                    Console.WriteLine("As you stare at the two branching pathways, something dawns on you");
                    Console.WriteLine("You realize that you don't like making decisions. You don't even know how you got this far.");
                    Console.WriteLine("Because of this you head back home and get a real job.");
                    Console.WriteLine("Game Over! Play again?");
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (input == '1')
                    {
                        continue;
                    }
                    else if (input == '2')
                    {
                        GameOver = true;
                        break;
                    }
                    else
                    {
                        GameOver = true;
                        break;
                    }
                }
            }
        }
    }
}
