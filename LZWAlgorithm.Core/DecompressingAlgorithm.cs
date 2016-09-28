using System;
using System.Linq;

namespace LZWAlgorithm.Core
{
    internal class DecompressingAlgorithm
    {
        public string Calculate()
        {

            var temp = Archivator._compressedString;

            var key = Archivator._currentKey;
            var decompressed = temp[0].ToString();
            var firstCode = Convert.ToInt32(decompressed);

            var dictionary = Archivator.InitialDictionary.ToDictionary(keyValue => keyValue.Key, keyValue => keyValue.Value);

            decompressed = dictionary[firstCode];

            var prevStep = decompressed;

            for (var index = 1; index < temp.Count; index++)
            {
                var code = temp[index];

                var word = dictionary[code];

                decompressed += word;
       
                var newWord = prevStep + word.ToCharArray()[0];

                dictionary.Add(key, newWord);
                key++;

               prevStep = word;

            }
            return decompressed;
        }
    }
}
