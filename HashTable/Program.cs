using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            CountNumbOfOccurence(paragraph);
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
            Console.WriteLine("Word                 NumberOfFrequency");
            hashTabe.Display();
            string s = "avoidable";
            hashTabe.Remove(s);
            Console.WriteLine("\n------------  After removing avoidable word from paragraph  ----------------------", s);
            Console.WriteLine("After removed word:  {0}\n----------------------------------\n", s);
            hashTabe.Display();
        }
    }
}