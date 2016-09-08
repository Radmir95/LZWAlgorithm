using System;
using System.Collections;

namespace LZWAlgorithm.Core
{
    public class Algorithm
    {

        public string InputString { get; }
        private ArrayList ListOfCodesAndWords { get; }

        public Algorithm(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input string can't be null");
            InputString = inputString;
            InputString = "abacabadabacabae";
            ListOfCodesAndWords = new ArrayList();
        }

        public void InitializeDictionary()
        {
            foreach (var word in InputString)
            {
                if (!ListOfCodesAndWords.Contains(word.ToString()))
                {

                    ListOfCodesAndWords.Add(word.ToString());

                }
            }
        }

        public string Calculate()
        {

            var encodingPhrase = ListOfCodesAndWords[0].ToString();
            var thread = "";
            for(var i = 1; i < InputString.Length; i++)
            {
                
                var previousWord = encodingPhrase;
                encodingPhrase += InputString.ToCharArray()[i].ToString();
                if (!ListOfCodesAndWords.Contains(encodingPhrase))
                {

                    ListOfCodesAndWords.Add(encodingPhrase);
                    //Some code must be there
                    continue;
                }
                for (var index = 0; index < ListOfCodesAndWords.Count; index++)
                {
                    if (ListOfCodesAndWords[index].ToString() == previousWord)
                    {
                        thread += index.ToString();
                        encodingPhrase = "";
                        break;
                    }
                }
            }
            return thread;

        }

        public ArrayList GetListOfCodesAndWords()
        {
            return ListOfCodesAndWords;
        }

    }
}
