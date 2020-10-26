using System;

namespace Practice_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Pick a item from below.");
            Console.WriteLine($"1. Cheeseburger \n 2. Hot Dog \n 3. Fries");


            string foodChoice = Console.ReadLine().ToLower();

            switch (foodChoice)
            {
                case "1":
                case "Cheeseburger":
                    foodChoice = "Cheeseburger";
                    Console.WriteLine($"{foodChoice}, excellent choice!");
                    Console.WriteLine("What would you like to drink with that?");
                    Console.WriteLine($"1. Coke \n 2. Diet Coke \n 3. Sprite \n 4. Water");
                    break;

                case "2":
                case "Hot Dog":
                    foodChoice = "Hot Dog";
                    Console.WriteLine($"{foodChoice}, very nice!");
                    Console.WriteLine("What would you like to drink with that?");
                    Console.WriteLine($"1. Coke \n 2. Diet Coke \n 3. Sprite \n 4. Water");
                    break;

                case "3":
                case "Fries":
                    foodChoice = "Fries";
                    Console.WriteLine($"{foodChoice}, great choice! Small, Medium or Large?");
                    break;

                default:
                    Console.WriteLine("Try again.");
                    break;
            }
                    string userPick = Console.ReadLine().ToLower();
                    //string size = Console.ReadLine().ToLower();

            switch (userPick)
            {
                case "1":
                case "coke":
                    Console.WriteLine($"Classic Coke, coming right up!");
                    break;

                case "2":
                case "diet coke":
                    Console.WriteLine("Diet for my favorite customer!");
                    break;

                case "3":
                case "sprite":
                    Console.WriteLine("One Sprite, on its way!");
                    break;

                case "4":
                case "water":
                    Console.WriteLine("Keeping it simple. I like that!");
                    break;

                default:
                    break;
            }

            //switch (size)
            //{
            //    case "small":
            //        Console.WriteLine("You've ordered a Small.");
            //        break;

            //    case "medium":
            //        Console.WriteLine("You've ordered a Medium.");
            //        break;

            //    case "large":
            //        Console.WriteLine("You've ordered a Large.");
            //        break;

            //    default:
            //        break;
            //}
        }
    }
}
