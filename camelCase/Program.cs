using System;
using System.Globalization;

namespace camelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide me with a sentence: ");
            string phrase = Console.ReadLine();

            string titleCasePhrase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

            string lowerCaseFirstLetter = char.ToLower(titleCasePhrase[0]) + titleCasePhrase.Substring(1);

            string noSpacesPhrase = lowerCaseFirstLetter.Replace(" ", string.Empty);

            Console.WriteLine("Camel case of the sentence is: " + noSpacesPhrase);

            

            Console.ReadLine();
        }
    }
}


