using System;

namespace storytime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Once Upon a Time: You are the FairyGodMother");
            Console.WriteLine("In this game you are a fairy godmother, a far away kingdom has searched far wide for you to help. Their princess has been cursed and the kingdom needs your help to undo the curse. Do you help the princess?");

            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("You have decided to help the kingdom undo the spell that the princess is under, the kingdom is forever grateful and will reward you after.");
            }

            else if(answer == "no")
            {
                Console.WriteLine("You have heard the kingdom's cry for help but have decided that it is not your duty. You have been deemed unfit as a fairy godmother and this is game over.");
            }

            Console.WriteLine("Your first task is to travel to the far away kingdom. This will be a long trek, do you wish to travel to the kingdom?");

            string task1 = Console.ReadLine();
            if (task1 == "yes")
            {
                Console.WriteLine("You have decided that you will travel to the far away kingdom no matter what it takes! The king has decided that a part of your reward will be to give you a title once you have undone the curse.");
            }

            else if (task1 == "no")
            {
                Console.WriteLine("You have chaned your mind and do not wish to travel to the far away kingdom anymore. Sorry, you are no longer deemed a fit fairy godmother. This is game over.");
            }

            Console.WriteLine("Now, you have reached the castle but there are monsters blocking the door! You must defeat the monsters in order to get inside. Do you fight the monsters?");

            string task2 = Console.ReadLine();
            if (task2 == "yes")
            {
                Console.WriteLine("You have defeated the monsters and am now able to get into the the castle!");
            }

            else if (task2 == "no")
            {
                Console.WriteLine("You have chosen to not kill the monsters and therefore have been eaten by them. Game over!");
            }

            Console.WriteLine("Once, you reach the princess' chambers there is an evil witch blocking your way. The evil witch says she is the one who has cursed the princess! You must defeat the witch to undo the spell. Do you fight the witch?");

            string task3 = Console.ReadLine();
            if (task3 == "yes")
            {
                Console.WriteLine("Hurray!!! You have defeated the witch and undone the curse. The princess and kingdom is saved from the evil witch. As promised, you are rewarded for your good deed and everyone gets to live happily ever after!");
            }
            else if (task3 == "no")
            {
                Console.WriteLine("Oh, no! You have decided to not fight the evil witch. The kingdom is forever doomed and the evil witch has killed you. Game over.");
            }
        }
    }
}
