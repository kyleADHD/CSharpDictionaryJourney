using System;
namespace CSharpDictionaryJourney.DictionaryIteration
{
    public static class DictionaryIteration
    {
        public static void ForeachWithKeyValuePair()
        {
            Console.WriteLine("1. Using foreach loop with KeyValuePair");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            // To iterate through a dictionary, you can use a foreach loop with KeyValuePair
            foreach (KeyValuePair<string, int> entry in myDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public static void LinqWithDictionaries()
        {
            Console.WriteLine("\n2. Using LINQ to filter or transform dictionary contents");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            // You can use LINQ to filter or transform dictionary contents
            var filteredDictionary = myDictionary.Where(entry => entry.Value > 1).ToDictionary(entry => entry.Key, entry => entry.Value);

            Console.WriteLine("Filtered dictionary (values > 1):");
            foreach (var entry in filteredDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public static void IterateKeysAndValuesSeparately()
        {
            Console.WriteLine("\n3. Iterating dictionary keys and values separately");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            // You can iterate through the dictionary keys and values separately
            Console.WriteLine("Dictionary keys:");
            foreach (string key in myDictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Dictionary values:");
            foreach (int value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}