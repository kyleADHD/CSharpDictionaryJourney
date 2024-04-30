using CSharpDictionaryJourney.AdvancedDictionaryTechniques;
using CSharpDictionaryJourney.ConcurrentDictionaries;
using CSharpDictionaryJourney.DictionaryCustomKeyTypes;
using CSharpDictionaryJourney.DictionaryOperations;
using CSharpDictionaryJourney.DictionaryIteration;
using CSharpDictionaryJourney.NestedDictionaries;


public class Program {
  
  public static void Main(string[] args) {
    // Basic dictionary declarations and initializations
    DictionaryIntro.BasicDeclarationAndInitialization();

    // Adding and removing elements to/from a dictionary
    DictionaryIntro.AddingAndRemovingElements();

    // Accessing values in a dictionary using indexers and TryGetValue()
    DictionaryIntro.AccessUsingIndexerAndTryGetValue();

    // Iteration examples: iterating over keys and values
    DictionaryIteration.ForeachWithKeyValuePair();
    DictionaryIteration.LoopWithDictionaries();

    // Operations: Merging, sorting, and grouping dictionaries
    DictionaryOperations.MergeDictionaries();
    DictionaryOperations.SortingDictionaries();
    DictionaryOperations.InvertingDictionaries();

    // Nested dictionary handling
    NestedDictionaries.CreateAndAccessNestedDictionaries();
    NestedDictionaries.IterateThroughNestedDictionaries();
    NestedDictionaries.PerformOperationsOnNestedDictionaries();

    // Custom key types in dictionaries
    CustomKeyTypes.CreateDictionariesWithCustomKeyTypes();

    // Concurrency support for dictionaries
    ConcurrentDictionaries.UseConcurrentDictionary();

    // Advanced techniques: Conditional weak tables, LRU cache implementations
    AdvancedDictionaryTechniques.UseConditionalWeakTable();
    AdvancedDictionaryTechniques.ImplementLRUCache();
  }
}
