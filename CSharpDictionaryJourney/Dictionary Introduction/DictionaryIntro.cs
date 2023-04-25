using System;
namespace CSharpDictionaryJourney.DictionaryIntroduction
{
    public static class DictionaryIntro
    {
        public static void BasicDeclarationAndInitialization()
        {
            Console.WriteLine("1. Basic dictionary declaration and initialization");

            // Declare a new dictionary with keys of type 'string' and values of type 'int'
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // You can also initialize a dictionary with some values like this
            Dictionary<string, int> myInitializedDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            Console.WriteLine("Dictionary declared and initialized.");
        }

        public static void AddingAndRemovingElements()
        {
            Console.WriteLine("\n2. Adding and removing elements");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Add elements to the dictionary using the Add method
            myDictionary.Add("four", 4);
            myDictionary.Add("five", 5);
            Console.WriteLine("Added elements to the dictionary.");

            // Remove an element from the dictionary using the Remove method
            myDictionary.Remove("four"); // This will remove the key "four" and its associated value
            Console.WriteLine("Removed an element from the dictionary.");
        }

        public static void AccessUsingIndexerAndTryGetValue()
        {
            Console.WriteLine("\n3. Accessing dictionary elements using the indexer and TryGetValue");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            // Access a value using the indexer
            int valueFromIndexer = myDictionary["two"]; // This will return the value 2
            Console.WriteLine($"Accessed value using indexer: {valueFromIndexer}");

            // If you try to access a non-existent key using the indexer, it will throw an exception
            // So, it's better to use TryGetValue method, which is a safer way to access values
            int valueFromTryGetValue;
            bool foundKey = myDictionary.TryGetValue("three", out valueFromTryGetValue);

            if (foundKey)
            {
                Console.WriteLine($"We found the key! The value is: {valueFromTryGetValue}");
            }
            else
            {
                Console.WriteLine("Oops! The key was not found.");
            }
        }
    }
}

