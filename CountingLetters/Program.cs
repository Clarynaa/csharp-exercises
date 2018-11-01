using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string toCompare = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            while (toCompare != "")
            {
                Counting(toCompare);
                Console.WriteLine("Please enter a string or leave blank to exit: ");
                toCompare = Console.ReadLine();

            }
        }

        static void Counting(string toCompare)
        {
            string toCompareLower = toCompare.ToLower();
            var letterCount = new Dictionary<char, int>();
            for (int i = 0; i < toCompare.Length; i++)
            {
                if (char.IsLetter(toCompareLower[i]))
                {
                    if (!letterCount.ContainsKey(toCompareLower[i]))
                    {
                        letterCount.Add(toCompareLower[i], 1);
                    }
                    else
                    {
                        letterCount[toCompareLower[i]]++;
                    }
                }

                else if (char.IsNumber(toCompareLower[i]))
                {
                    if (!letterCount.ContainsKey(toCompareLower[i]))
                    {
                        letterCount.Add(toCompareLower[i], 1);
                    }
                    else
                    {
                        letterCount[toCompareLower[i]]++;
                    }
                }
            }

            Console.WriteLine("Unsorted: ");

            foreach (var pair in letterCount)
            {
                Console.Out.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.Out.WriteLine("-----------------------------------------\nSorted:");
            List<char> letters = letterCount.Keys.ToList();
            letters.Sort();

            foreach (char letter in letters)
            {
                Console.Out.WriteLine(letter + ": " + letterCount[letter]);
            }
        }
    }
}
