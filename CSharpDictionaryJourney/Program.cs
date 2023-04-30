using CSharpDictionaryJourney.AdvancedDictionaryTechniques;
using CSharpDictionaryJourney.ConcurrentDictionaries;
using CSharpDictionaryJourney.DictionaryCustomKeyTypes;
using CSharpDictionaryJourney.DictionaryIntroduction;
using CSharpDictionaryJourney.DictionaryIteration;
using CSharpDictionaryJourney.DictionaryOperations;
using CSharpDictionaryJourney.NestedDictionaries;

#region Dictionary Introduction examples
DictionaryIntro.BasicDeclarationAndInitialization();
DictionaryIntro.AddingAndRemovingElements();
DictionaryIntro.AccessUsingIndexerAndTryGetValue();
#endregion

#region Dictionary Iteration examples
DictionaryIteration.ForeachWithKeyValuePair();
DictionaryIteration.LinqWithDictionaries();
DictionaryIteration.IterateKeysAndValuesSeparately();
#endregion

#region Dictionary Operations examples
DictionaryOperations.MergingDictionaries();
DictionaryOperations.SortingDictionaries();
DictionaryOperations.InvertingDictionaries();
DictionaryOperations.GroupingDataWithDictionaries();
#endregion

#region NestedDictionaries
NestedDictionaries.CreateAndAccessNestedDictionaries();
NestedDictionaries.IterateThroughNestedDictionaries();
NestedDictionaries.PerformOperationsOnNestedDictionaries();
#endregion

#region Custom Key Types in Dictionaries
CustomKeyTypes.CreateDictionariesWithCustomKeyTypes();
#endregion

#region Concurrent Dictionaries
ConcurrentDictionaries.UseConcurrentDictionary();
#endregion

#region Advanced Dictionary Techniques
AdvancedDictionaryTechniques.UseConditionalWeakTable();
AdvancedDictionaryTechniques.ImplementLRUCache();
#endregion