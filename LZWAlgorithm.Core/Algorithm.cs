using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Calculate()
        {

            var encodingPhrase = ListOfCodesAndWords[0].ToString();
            string thread = "";
            for(var i = 1; i < InputString.Length; i++)
            {
                
                var previousWord = encodingPhrase;
                encodingPhrase += InputString.ToCharArray()[i].ToString();
                if (!ListOfCodesAndWords.Contains(encodingPhrase))
                {
                    ListOfCodesAndWords.Add(encodingPhrase);
                    continue;
                }
                for (var index = 0; index < ListOfCodesAndWords.Count; index++)
                {
                    if (ListOfCodesAndWords[index].ToString() == previousWord)
                    {
                        thread += index.ToString();
                    }
                }
                encodingPhrase = "";

            }
            Console.WriteLine(thread);

        }

        public ArrayList GetListOfCodesAndWords()
        {
            return ListOfCodesAndWords;
        }

    }
}
