using System;
using System.Collections.Concurrent;

namespace CSharpDictionaryJourney.ConcurrentDictionaries
{
    public class ConcurrentDictionaries
    {
        // This method demonstrates how to use ConcurrentDictionary to perform thread-safe operations.
        public static void UseConcurrentDictionary()
        {
            // Create a new concurrent dictionary with string keys and integer values.
            var dict = new ConcurrentDictionary<string, int>();

            // Add elements to the dictionary.
            dict.TryAdd("apple", 1);
            dict.TryAdd("banana", 2);
            dict.TryAdd("orange", 3);

            // Use GetOrAdd to retrieve a value by key, or add a new value if the key does not exist.
            int val1 = dict.GetOrAdd("apple", 4);
            int val2 = dict.GetOrAdd("pear", 5);

            Console.WriteLine($"The value of 'apple' is {val1}.");
            Console.WriteLine();
            Console.WriteLine($"The value of 'pear' is {val2}.");
            Console.WriteLine();

            // Use AddOrUpdate to update an existing value or add a new key/value pair.
            int newVal1 = dict.AddOrUpdate("apple", 10, (key, oldValue) => oldValue + 10);
            int newVal2 = dict.AddOrUpdate("mango", 6, (key, oldValue) => oldValue + 6);

            Console.WriteLine($"The new value of 'apple' is {newVal1}.");
            Console.WriteLine();
            Console.WriteLine($"The value of 'mango' is {newVal2}.");
            Console.WriteLine();
        }
    }
}