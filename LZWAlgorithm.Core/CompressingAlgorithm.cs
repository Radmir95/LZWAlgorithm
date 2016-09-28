using System.Collections.Generic;
using System.Linq;

namespace LZWAlgorithm.Core
{
    internal class CompressingAlgorithm
    {

        public string Calculate()
        {
            var dictionary = Archivator.InitialDictionary.ToDictionary(keyValue => keyValue.Key, keyValue => keyValue.Value);
            var countOfValues = Archivator._currentKey;
            var encodingPhrase = dictionary[0];
            var thread = "";
            for(var currentSymbol = 1; currentSymbol <Archivator.InputString.Length; currentSymbol++)
            {
                
                var previousWord = encodingPhrase;
                encodingPhrase += Archivator.InputString.ToCharArray()[currentSymbol].ToString();
                if (dictionary.ContainsValue(encodingPhrase)) continue;
                dictionary.Add(countOfValues,encodingPhrase);
                countOfValues++;
                thread += GetCodeOfWord(dictionary, previousWord) + " ";
                encodingPhrase = Archivator.InputString.ToCharArray()[currentSymbol].ToString();

            }
            thread += GetCodeOfWord(dictionary, encodingPhrase);
            Archivator._compressedString = thread;
            return thread;

        }

        public int GetCodeOfWord(Dictionary<int, string> dictionary, string word)
        {
            return (from keyValue in dictionary where keyValue.Value == word select keyValue.Key).FirstOrDefault();
        }


    }
}
