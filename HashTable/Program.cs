using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "To be or not to be";
            CountNumbOfOccurence(paragraph);
            Console.Write("\nPress any key to continue...... ");

        }
        
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation\n---------------------------------");
            Console.WriteLine("Word      NumberOfFrequency");
            hashTabe.Display();
        }
    }
}