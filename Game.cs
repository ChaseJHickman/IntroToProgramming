using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool GameOver = false;
        //Gets input from console, and updates player values
        char input = ' ';
        void endgame()
        {
            Console.WriteLine("Game Over! Play again?");
            Console.WriteLine("Press 1 for yes.");
            Console.WriteLine("Press 2 for no.");
            input = Console.ReadKey().KeyChar;
            Console.Clear();
            if (input == '1')
            {
                return;
            }
            else if (input == '2')
            {
                GameOver = true;
            }
            else
            {
                GameOver = true;
            }
        }
        public void Run()
        {
            while (GameOver == false)
            {
                //This variable is used to store health
                float playerhealth = 100.0f;
                //This value is used to heal the player
                float healthRegen = 20;
                bool maxLevelReached = false;
                int damage = 20;
                int defence = 40;
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
                Console.WriteLine();
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        playerhealth = 200;
                        role = "Knight";
                    }
                    else if (input == '2')
                    {
                        playerhealth = 150;
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
                Console.WriteLine("Player Health: " + playerhealth);
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
                    playerhealth = 0;
                    damage = 500;
                    Console.WriteLine("You feel like you could destroy a mountain wiht one punch!");
                    Console.WriteLine("However, after a few moments pass you notice you begin to feel awfully numb");
                    Console.WriteLine("Soon you can't feel a bone in your body and realize that you're paralized");
                    endgame();

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
                    endgame();
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
                        if (input == '1')
                        {
                            Console.WriteLine("You take off into the trees, traversing deeper into the forest.");
                            Console.WriteLine("As you run you notice the pixie in the distance, it thinks you lost it.");
                            Console.WriteLine("You kneel behind a tree and think over your next move.");
                            Console.WriteLine("Press 1 to attack it again");
                            Console.WriteLine("Press 2 to leave it alone");
                            input = Console.ReadKey().KeyChar;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine("As you start walking on the path again you hear something in the distance.");
                            Console.WriteLine("Press 1 to care.");
                            Console.WriteLine("Press 2 to keep walking.");
                            input = Console.ReadKey().KeyChar;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("After attacking the pixie you realize that you probably just lost your one chance at having a friend.");
                            Console.WriteLine("You filled with so much existential dread, you go home and give up on your adventure");
                            endgame();
                        }
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
                    else if (input == '2')
                    {
                        Console.WriteLine("You continue down the path and see a wolf up ahead, and he looks hungry.");
                        Console.WriteLine("You can try to fight it, or you can turn back.");
                        Console.WriteLine("Press 1 to fight the wolf.");
                        Console.WriteLine("Press 2 to turn around.");
                        input = Console.ReadKey().KeyChar;
                        Console.Clear();
                        if (input == '1')
                        {
                            Console.WriteLine("You enter a fight!");
                            int Wolfhealth = 60;
                            int Wolfdamage = 25;
                            while(playerhealth > 0 && Wolfhealth > 0)
                            {
                                Console.WriteLine("Your health is" + playerhealth + ". Your enemy's health is" + Wolfhealth + ".");
                                Console.WriteLine("Press 1 to Attack");
                                Console.WriteLine("Press 2 to Defend");
                                input = Console.ReadKey().KeyChar;
                                Console.Clear();
                                if (input == '1')
                                {
                                    Wolfhealth -= damage;
                                    Console.WriteLine("You hit the wolf with a nice left hook. The wolf took " + damage + "damage.");
                                }
                                else if (input == '2')
                                {
                                    defence -= Wolfdamage;
                                    Console.WriteLine("You raised your arms and got ready to take the hit and took " + Wolfdamage + "damage.");
                                    Console.ReadKey();
                                    continue;
                                }
                                playerhealth -= Wolfdamage;
                                Console.WriteLine("The wolf bites you. You took " + Wolfdamage + "damage.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine("You don't feel up to fighting a wild hungry animal and decide to turn around.");
                            Console.WriteLine("You head towards a cave you saw in the distance a bit ago");
                            Console.WriteLine("The entrence to the cave has a door with a riddle on it.");
                            Console.WriteLine("It says: What is life's greatest illusion?");
                            string guess = " ";
                            for(int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("You have " + (5 - i) + " tries remaining");
                                guess = Console.ReadLine();
                                if(guess == "Innocence my brother")
                                {
                                    Console.WriteLine("The door speaks: Welcome home..."); Console.WriteLine("The door open into the cave. Do you go inside?");
                                    Console.WriteLine("Press 1 to go inside.");
                                    Console.WriteLine("Press 2 to leave.");
                                    input = Console.ReadKey().KeyChar;
                                    Console.Clear();
                                    if (input == '1')
                                    {
                                        Console.WriteLine("You enter the cave.");
                                        Console.WriteLine("The cave is well lit with torches hung to either side of the wall a few inches apart from one another");
                                        Console.WriteLine("You can hear a feint chattering further down in the cave");

                                    }
                                    else if (input == '2')
                                    {
                                        Console.WriteLine("You don't like the looks of this cave so you leave it alone and go somewhere else.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The door speaks: You are not worthy...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            Console.WriteLine("The door speaks: You have tried and failed too many times... You aren't a bother...");
                            Console.WriteLine("Any more attempts too open the door fail completely.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Since you don't know how to answer 1 or 2, God deems you unworthy to go on with your adventure, do you go home.");
                        
                    }
                }
                else
                {
                    Console.WriteLine("As you stare at the two branching pathways, something dawns on you");
                    Console.WriteLine("You realize that you don't like making decisions. You don't even know how you got this far.");
                    Console.WriteLine("Because of this you head back home and get a real job.");
                    endgame();
                }
            }
        }
    }
}
