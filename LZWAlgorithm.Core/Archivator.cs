using System.Collections.Generic;

namespace LZWAlgorithm.Core
{
    public static class Archivator
    {
        public static string InputString;
        internal static int _currentKey;
        internal static Dictionary<int, string> InitialDictionary;
        internal static Dictionary<int, int> _compressedString;

        private static CompressingAlgorithm _compresser;
        private static DecompressingAlgorithm _decompresser;
        private static bool IsInitialize = false;

        public static void Initialize()
        {
            InitialDictionary = new Dictionary<int, string>();
            var key = 0;
            foreach (var word in InputString)
            {
                if (InitialDictionary.ContainsValue(word.ToString())) continue;
                InitialDictionary.Add(key, word.ToString());
                key++;
            }
            _currentKey = key;

            _compresser = new CompressingAlgorithm();
            _decompresser = new DecompressingAlgorithm();

        }

        public static Dictionary<int ,int> Compress()
        {
            Initialize();
            return _compresser.Calculate();
        }

        public static string Decompress()
        {

            return _decompresser.Calculate();

        }

    }
}
