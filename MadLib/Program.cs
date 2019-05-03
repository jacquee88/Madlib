using System;

namespace MadLib
{
    class Program
    {
        static void Main()
        {
            //declare variables
            string Creature;
            string Luminous;
            string Ghastly;
            string Spectral;
            string Countryman;
            string Farrier;
            string Farmer;
            string Dreadful;
            string Apparition;
            string Hound;
            string Story;

            //write out a header
            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("--------");

            //ask player to enter words
            Console.Write("Please enter a noun: ");
            Creature = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Luminous = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Ghastly = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Spectral = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Countryman = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Farrier = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Farmer = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Dreadful = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Apparition = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Hound = Console.ReadLine();

            //write out finished story
            Story = "They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
            Console.WriteLine(Story);

            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
