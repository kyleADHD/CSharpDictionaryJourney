using System;
namespace CSharpDictionaryJourney.NestedDictionaries
{
    public class NestedDictionaries
    {
        // Creating and accessing nested dictionaries
        public static void CreateAndAccessNestedDictionaries()
        {
            // Create a new nested dictionary with outer keys of type string and inner values of type Dictionary<string, int>.
            Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>();

            // Add a new key-value pair to the nested dictionary.
            string outerKey = "outer";
            string innerKey = "inner";
            int value = 42;

            if (!nestedDict.ContainsKey(outerKey))
            {
                nestedDict.Add(outerKey, new Dictionary<string, int>());
            }

            nestedDict[outerKey][innerKey] = value;

            // Access a value in the nested dictionary by checking if the keys exist and
            // then getting the value using the TryGetValue method.
            if (nestedDict.ContainsKey(outerKey))
            {
                int innerValue;
                if (nestedDict[outerKey].TryGetValue(innerKey, out innerValue))
                {
                    Console.WriteLine($"Value for '{outerKey}' and '{innerKey}' is {innerValue}");
                }
             
            }
            Console.WriteLine();
        }

        // Iterating through nested dictionaries
        public static void IterateThroughNestedDictionaries()
        {
            // Create a new nested dictionary with two outer keys and two inner keys.
            Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>();

            string outerKey1 = "outer1";
            string outerKey2 = "outer2";
            string innerKey1 = "inner1";
            string innerKey2 = "inner2";
            int value1 = 42;
            int value2 = 100;

            if (!nestedDict.ContainsKey(outerKey1))
            {
                nestedDict.Add(outerKey1, new Dictionary<string, int>());
            }

            if (!nestedDict.ContainsKey(outerKey2))
            {
                nestedDict.Add(outerKey2, new Dictionary<string, int>());
            }

            nestedDict[outerKey1][innerKey1] = value1;
            nestedDict[outerKey1][innerKey2] = value2;
            nestedDict[outerKey2][innerKey1] = value1;

            // Iterate through the nested dictionary using nested loops to print out all the key-value pairs.
            foreach (var outerEntry in nestedDict)
            {
                Console.WriteLine($"Outer key: {outerEntry.Key}");

                foreach (var innerEntry in outerEntry.Value)
                {
                    Console.WriteLine($"\tInner key: {innerEntry.Key}, value: {innerEntry.Value}");
                }
            }
            Console.WriteLine();
        }
        // Performing operations on nested dictionaries
        public static void PerformOperationsOnNestedDictionaries()
        {
            // Create a new nested dictionary with two outer keys and two inner keys.
            Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>();

            string outerKey1 = "outer1";
            string outerKey2 = "outer2";
            string innerKey1 = "inner1";
            string innerKey2 = "inner2";
            int value1 = 42;
            int value2 = 100;

            if (!nestedDict.ContainsKey(outerKey1))
            {
                nestedDict.Add(outerKey1, new Dictionary<string, int>());
            }

            if (!nestedDict.ContainsKey(outerKey2))
            {
                nestedDict.Add(outerKey2, new Dictionary<string, int>());
            }

            nestedDict[outerKey1][innerKey1] = value1;
            nestedDict[outerKey1][innerKey2] = value2;
            nestedDict[outerKey2][innerKey1] = value1;

            // Group the nested dictionary by outer key using LINQ.
            var groupedByOuterKey = nestedDict
                .GroupBy(outerEntry => outerEntry.Key)
                .ToDictionary(g => g.Key, g => g.ToDictionary(innerEntry => innerEntry.Key, innerEntry => innerEntry.Value));

            // Iterate through the grouped dictionary using nested loops to print out all the key-value pairs.
            foreach (var outerEntry in groupedByOuterKey)
            {
                Console.WriteLine($"Outer key: {outerEntry.Key}");

                foreach (var innerEntry in outerEntry.Value)
                {
                    Console.WriteLine($"\tInner key: {innerEntry.Key}, value: {innerEntry.Value}");
                }
            }
            Console.WriteLine();
        }
    }  
}