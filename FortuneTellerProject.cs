using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) // Allows the program to be restarted or quit

            {

                Console.WriteLine("I am Glenda the good witch, here to tell your fortune."+ "\n"+ "If you would like to leave at any time type \"quit\".");
                Console.WriteLine("You may also start over at any point by typing \"restart\".");
                Console.WriteLine();


                Console.WriteLine("Please provide your first name.");
                string name = Console.ReadLine();
                if(name.ToLower()=="quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                if (name.ToLower() == "restart") 
                {
                    continue;
                }

                Console.WriteLine("Hello " + name + ", what is you Last name?");
                string lastName = Console.ReadLine();
                if (lastName.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                if (lastName.ToLower()== "restart")
                {
                    continue;
                }

                Console.WriteLine("Ok, " + name + " " + lastName + " " + "How old are you?");

                
                
                    string inputAge = Console.ReadLine();
                    int age;
                    if (inputAge.ToLower() == "quit")
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                    }

                    else if (inputAge.ToLower()=="restart")
                {
                    continue;
                }

                    else
                    {
                        bool res = int.TryParse(inputAge, out age);
                        if (res == true)
                        {
                            Console.WriteLine("So you are, " + age + "." + "\n" + "What month where you born in?");
                        }
                        else
                        {
                        age = 30;
                        Console.WriteLine("What month where you born in?");
                        }
                    }
                

                
                string month = Console.ReadLine();

                if (month.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                else if (month.ToLower()== "restart")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Hmm born in, " + month + "\n" + "Very interesting!");
                }
                Console.WriteLine("What is your favorite ROYGBIV color?" + "\n" + "If you do not know what ROYGBIV is enter \"help\"");
                string color = Console.ReadLine().ToLower();


                while (true)
                {
                    if (color == "help")
                    {
                        Console.WriteLine("ROYGBIV is an acronym for rainbow colors: red, orange, yellow, green, blue, indigo, and violet.");
                        Console.WriteLine("What is your favorite ROYGBIV color?" + "\n" + "If you do not know what ROYGBIV is enter \"help\"");
                        Console.WriteLine("What is your favorite ROYGBIV Color?");
                        color = Console.ReadLine().ToLower();

                    }

                    else
                    {
                        break;
                    }



                }

                if (color == "red" || color == "r")
                {
                    Console.WriteLine("Red, the color of blood, hmmm..");
                }

                else if (color == "orange" || color == "o")
                {
                    Console.WriteLine("Orange, like the fruit. Interesting...");
                }

                else if (color == "yellow" || color == "y")
                {
                    Console.WriteLine("Yellow, that makes me think of daffodils. Intriguing...");
                }

                else if (color == "green" || color == "g")
                {
                    Console.WriteLine("Green, like grass. Hmm...");
                }

                else if (color == "blue" || color == "b")
                {
                    Console.WriteLine("Blue like that sky. That is very interesting...");
                }

                else if (color == "indigo" || color == "i")
                {
                    Console.WriteLine("Indigo! How unique...");
                }
                else if (color == "violet" || color == "v")
                {
                    Console.WriteLine("Violet, the color of royalty. Intriguing...");
                }

                else if( color=="quit")
                    {
                    Console.WriteLine("Nobody likes a quiter...");
                     break;
                     }
                else if (color== "restart")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Well OK then.");
                }

                Console.WriteLine("How many sibilings do you have? ");
                string sibInput = (Console.ReadLine());
                int sib;

                if (sibInput.ToLower()=="quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                else if (sibInput.ToLower()=="restart")
                {
                    continue;
                }

                else
                {
                    bool result = int.TryParse(sibInput, out sib);
                    if (result==true)
                    {
                        Console.WriteLine(sib+ " siblings... interesting.");
                    }
                    else
                    {
                        sib = 1;
                    }
                }

                if (age % 2 == 0)
                {
                    Console.WriteLine(name + " " + lastName + " you will retire in 12 years" );
                }

                else
                {
                    Console.WriteLine(name + " " + lastName + " you will retire in 22 years");

                }

                string fullname = name + lastName;

                string x = month[0].ToString().ToLower();
                string y = month[1].ToString().ToLower();
                string z = month[2].ToString().ToLower();
                string[] money = { "almost $32,00", "at least $50,000", "just over $1million" };
                if (fullname.Contains(x))
                {
                    Console.WriteLine("with " + money[0] + "in the bank, ");
                }

                else if (fullname.Contains(y))
                {
                    Console.WriteLine("with " + money[1]+ "in the bank, ");
                }

                else if (fullname.Contains(z))
                {
                    Console.WriteLine("with " + money[2]+ "in the bank, ");
                }

                string[] home = { "Barrow, Alaska. Better pack your warm coat!", "Billings, Montana.\"Home, Home on the range...\"", "Columbus", "Denver, Colorado. Take your hiking boots!", "Australia. The land down under where everything is trying to kill you!" };
                switch (sib)
                {
                    case 0:
                        Console.WriteLine("and have a vacation home in " + home[0]);
                        break;
                    case 1:
                        Console.WriteLine("and have a vacation home in " + home[1]);
                        break;
                    case 2:
                        Console.WriteLine("and have a vacation home in " + home[3]);
                        break;
                    case 3:
                        Console.WriteLine("and have a vacation home in " + home[5]);
                        break;

                    default:
                        Console.WriteLine("and have a vacation home in "+ home[6]);
                        break;
                }

                switch (color)
                {
                    case "red":
                    case "r":
                        Console.WriteLine("You will drive a horse and buggy.");
                        break;
                    case "orange":
                    case "o":
                        Console.WriteLine("You will drive a hearse.");
                        break;
                    case "yellow":
                    case "y":
                        Console.WriteLine("You will drive a wood paneled station wagon.");
                        break;
                    case "green":
                    case "g":
                        Console.WriteLine("You will drive a shopping cart with a lawn mower motor.");
                        break;
                    case "blue":
                    case "b":
                        Console.WriteLine("You will fly a helicopter.");
                        break;
                    case "indigo":
                    case "i":
                        Console.WriteLine("You will drive a minivan.");
                        break;
                    case "violet":
                    case "v":
                        Console.WriteLine("You will be driven in a Limo.");
                        break;
                    default:
                        Console.WriteLine("You will drive a very plain black sedan.");
                        break;

                }

                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Enter \"Yes\" to continue or  \"quit\" to quit.");
                string response = Console.ReadLine().ToLower();
                if (response == "yes"|| response == "restart")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }


            }


                






        }
    }
}
