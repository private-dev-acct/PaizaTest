using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;

namespace PaizaTest
{
    class Program
    {
        private static readonly Scanner _sc = new Scanner();
        
        static void Solve()
        {
            // do something ...    
        }

        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Solve(); 
                sw.Flush();
            }
        }
    }

    #region Scan

    class Scanner
    {
        private string[] _strArray;
        private int _index;
        private readonly char[] _separator;
        public Scanner(char sepa = ' ')
        {
            _strArray = new string[0];
            _index = 0;
            _separator = new char[] { sepa };
        }

        public string Next()
        {
            if (_index < _strArray.Length) 
                return _strArray[_index++];
            string st = Console.ReadLine();
            while (st == "") 
                st = Console.ReadLine();
            _strArray = st.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
            if (_strArray.Length == 0) 
                return Next();
            _index = 0;
            return _strArray[_index++];
        }

        public int NextInt() => int.Parse(Next());
        public long NextLong() => long.Parse(Next());
        public double NextDouble() => double.Parse(Next());
        public BigInteger NextBigInt() => BigInteger.Parse(Next());
    }

    #endregion
}
