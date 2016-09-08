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
            


        }

        public ArrayList GetListOfCodesAndWords()
        {
            return ListOfCodesAndWords;
        }

    }
}
