using Fartbook.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook
{
    public class UserInputHelper
    {
        public Fart GetFartFromUser()
        {
            Fart fartToReturn = new Fart();
            Console.WriteLine("What is the sound of the fart?");
            fartToReturn.Sound = Console.ReadLine();
            Console.WriteLine("What is the smell rating of the fart(as a positive whole number)");
            string userInputForSmellRating = Console.ReadLine();
            while (userInputForSmellRating.Contains("-"))
            {
                Console.WriteLine("What is the smell rating of the fart(as a positive whole number)");
                userInputForSmellRating = Console.ReadLine();
            }
            fartToReturn.SmellRating = Convert.ToInt32(userInputForSmellRating);
            var randomNumberGenerator = new Random();
            fartToReturn.FartID = randomNumberGenerator.Next(0, 10000000);
            return fartToReturn;
        }
        public Fart GetUpdatedFartFromUser()
        {
            Fart fartToReturn = new Fart();
            // Prompt for Smell
            Console.WriteLine("What is the smell for the fart?");
            fartToReturn.SmellRating = Convert.ToInt32(Console.ReadLine());
            // Prompt for Sound
            Console.WriteLine("What is the sound for the fart?");
            fartToReturn.Sound = Console.ReadLine();
            // Return fart without ID
            return fartToReturn;
        }
        public FartType GetNewFartTypeFromUser()
        {
            FartType newFartType = new FartType();
            Console.WriteLine("What is the title of this fart type?");
            newFartType.Title = Console.ReadLine();
            Console.WriteLine("Is this type of fart embarassing for the giver?(y/n)");
            newFartType.EmbarassesGiver = Console.ReadLine().Contains('y');
            Console.WriteLine("Is this type of fart embarassing for the recipient?(y/n)");
            newFartType.EmbarassesRecipient = Console.ReadLine().Contains('y');
            var randomNumberGenerator = new Random();
            newFartType.FartTypeID = randomNumberGenerator.Next(0, 10000000);
            return newFartType;
        }
        public string GetTitleOfFartTypeToDelete()
        {
            Console.WriteLine("What is the title of this fart type?");
            string title = Console.ReadLine();
            return title;
        }
        public void DisplayPopularFartTypes(List<FartType> fartTypes)
        {
            foreach (FartType fartType in fartTypes)
            {
                Console.WriteLine($"{fartType.FartTypeID} | {fartType.Title} | {(fartType.EmbarassesGiver ? "Embarasses Giver" : "")} | {(fartType.EmbarassesRecipient ? "Embarasses Recipient" : "")} ");
            }
        }
    }
}
