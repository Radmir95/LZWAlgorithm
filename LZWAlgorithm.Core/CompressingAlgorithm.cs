using System.Collections.Generic;
using System.Linq;

namespace LZWAlgorithm.Core
{
    internal class CompressingAlgorithm
    {

        public Dictionary<int, int> Calculate()
        {
            var dictionary = Archivator.InitialDictionary.ToDictionary(keyValue => keyValue.Key, keyValue => keyValue.Value);
            var countOfValues = Archivator._currentKey;
            var encodingPhrase = dictionary[0];
            var thread = new Dictionary<int, int>();
            var countThread = 0;
            for(var currentSymbol = 1; currentSymbol <Archivator.InputString.Length; currentSymbol++)
            {
                
                var previousWord = encodingPhrase;
                encodingPhrase += Archivator.InputString.ToCharArray()[currentSymbol].ToString();
                if (dictionary.ContainsValue(encodingPhrase)) continue;
                dictionary.Add(countOfValues,encodingPhrase);
                countOfValues++;
                thread.Add(countThread, GetCodeOfWord(dictionary, previousWord));
                countThread++;
                encodingPhrase = Archivator.InputString.ToCharArray()[currentSymbol].ToString();

            }
            thread.Add(countThread, GetCodeOfWord(dictionary, encodingPhrase));
            Archivator._compressedString = thread;
            return thread;

        }

        public int GetCodeOfWord(Dictionary<int, string> dictionary, string word)
        {
            return (from keyValue in dictionary where keyValue.Value == word select keyValue.Key).FirstOrDefault();
        }


    }
}
