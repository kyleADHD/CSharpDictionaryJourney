using System;
using System.Runtime.CompilerServices;

namespace CSharpDictionaryJourney.AdvancedDictionaryTechniques
{
    public class AdvancedDictionaryTechniques
    {
        // Using ConditionalWeakTable for object-to-object mappings
        public static void UseConditionalWeakTable()
        {
            Console.WriteLine("-----Using ConditionalWeakTable for object-to-object mappings-----");

            // Create a new ConditionalWeakTable instance
            var table = new ConditionalWeakTable<Key, Value>();

            // Create a new Key instance and set its value
            var key = new Key("foo");

            // Create a new Value instance and set its value
            var value = new Value(42);

            // Add the key-value pair to the table
            table.Add(key, value);

            // Try to get the value for the key
            if (table.TryGetValue(key, out Value result))
            {
                Console.WriteLine($"The value for key {key.Value} is {result.ValueField}");
            }
            else
            {
                Console.WriteLine($"No value found for key {key.Value}");
            }

            Console.WriteLine();
        }

        // Implementing LRU Cache using Dictionary and LinkedList
        public static void ImplementLRUCache()
        {
            Console.WriteLine("-----Implementing LRU Cache using Dictionary and LinkedList-----");

            // Create a new LRU cache with a maximum size of 2
            var cache = new LRUCache<int, string>(2);

            // Add some values to the cache
            cache.Add(1, "one");
            cache.Add(2, "two");
            cache.Add(3, "three");

            // Get a value from the cache
            if (cache.TryGetValue(2, out string value))
            {
                Console.WriteLine($"The value for key 2 is {value}");
            }
            else
            {
                Console.WriteLine("No value found for key 2");
            }

            Console.WriteLine();
        }

        // Key class for ConditionalWeakTable example
        private class Key
        {
            public Key(string value)
            {
                Value = value;
            }

            public string Value { get; }
        }

        // Value class for ConditionalWeakTable example
        private class Value
        {
            public Value(int val)
            {
                ValueField = val;
            }

            public int ValueField { get; }
        }


        // LRU Cache implementation using Dictionary and LinkedList
        private class LRUCache<TKey, TValue>
        {
            private readonly int _capacity;
            private readonly Dictionary<TKey, LinkedListNode<(TKey Key, TValue Value)>> _dictionary;
            private readonly LinkedList<(TKey Key, TValue Value)> _list;

            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _dictionary = new Dictionary<TKey, LinkedListNode<(TKey, TValue)>>(capacity);
                _list = new LinkedList<(TKey, TValue)>();
            }

            public void Add(TKey key, TValue value)
            {
                // If the key already exists in the cache, remove it
                if (_dictionary.TryGetValue(key, out LinkedListNode<(TKey Key, TValue Value)> node))
                {
                    _list.Remove(node);
                    _dictionary.Remove(key);
                }

                // Add the key-value pair to the cache
                var item = (_list.AddFirst((key, value)));
                _dictionary[key] = item;

                // If the cache is full, remove the least recently used item
                if (_list.Count > _capacity)
                {
                    var last = _list.Last;
                    _list.Remove(last);
                    _dictionary.Remove(last.Value.Key);
                }
            }
            public bool TryGetValue(TKey key, out TValue value)
            {
                if (_dictionary.TryGetValue(key, out LinkedListNode<(TKey Key, TValue Value)> node))
                {
                    // Move the node to the front of the list
                    _list.Remove(node);
                    _list.AddFirst(node); value = node.Value.Value;
                    return true;
                }

                value = default;
                return false;
            }
        }
    }
}                