using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " What is the height of your rectangle?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What about the width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That rectangle has an area of " + (height * width) + "\nWhat would you like to search the first sentence of Alice in Wonderland for?");
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string searchTerm = Console.ReadLine().ToUpper();
            bool search = alice.ToUpper().Contains(searchTerm);
            Console.WriteLine(search);
            Console.ReadLine();
        }
    }
}
