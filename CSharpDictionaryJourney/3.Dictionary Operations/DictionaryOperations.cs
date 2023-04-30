using System;
namespace CSharpDictionaryJourney.DictionaryOperations
{
    public static class DictionaryOperations
    {
        public static void MergingDictionaries()
        {
            Console.WriteLine("1. Merging dictionaries");

            Dictionary<string, int> dictionary1 = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            Dictionary<string, int> dictionary2 = new Dictionary<string, int>
            {
                { "four", 4 },
                { "five", 5 }
            };

            // To merge two dictionaries, you can use the Concat method and ToDictionary
            var mergedDictionary = dictionary1.Concat(dictionary2).ToDictionary(entry => entry.Key, entry => entry.Value);
            Console.WriteLine();
            Console.WriteLine("Merged dictionary:");
            foreach (var entry in mergedDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            Console.WriteLine();
        }

        public static void SortingDictionaries()
        {
            Console.WriteLine("\n2. Sorting dictionaries by key or value");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "three", 3 },
                { "two", 2 }
            };

            // To sort a dictionary by key, use the OrderBy method
            var sortedByKey = myDictionary.OrderBy(entry => entry.Key).ToDictionary(entry => entry.Key, entry => entry.Value);

            Console.WriteLine("Dictionary sorted by key:");
            foreach (var entry in sortedByKey)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // To sort a dictionary by value, use the OrderBy method with the Value property
            var sortedByValue = myDictionary.OrderBy(entry => entry.Value).ToDictionary(entry => entry.Key, entry => entry.Value);

            Console.WriteLine("Dictionary sorted by value:");
            foreach (var entry in sortedByValue)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public static void InvertingDictionaries()
        {
            Console.WriteLine("\n3. Inverting a dictionary (swap keys and values)");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };

            // To invert a dictionary (swap keys and values), use the ToDictionary method with the Key and Value properties swapped
            var invertedDictionary = myDictionary.ToDictionary(entry => entry.Value, entry => entry.Key);

            Console.WriteLine("Inverted dictionary:");
            foreach (var entry in invertedDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public static void GroupingDataWithDictionaries()
        {
            Console.WriteLine("\n4. Grouping data using dictionaries");

            // Sample data: a list of people with their age
            var people = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Pieter", 30),
                new KeyValuePair<string, int>("Massimo", 25),
                new KeyValuePair<string, int>("Kyle", 28),
                new KeyValuePair<string, int>("Franscois", 29),
                new KeyValuePair<string, int>("Haryy", 25)
            };

            // Group people by their age using a dictionary
            Dictionary<int, List<string>> groupedByAge = people.GroupBy(p => p.Value).ToDictionary(g => g.Key, g => g.Select(p => p.Key).ToList());

            Console.WriteLine("People grouped by age:");
            foreach (var entry in groupedByAge)
            {
                Console.WriteLine($"Age: {entry.Key}");
                foreach (var person in entry.Value)
                {
                    Console.WriteLine($"\t{person}");
                }
            }
        }
    }
}

