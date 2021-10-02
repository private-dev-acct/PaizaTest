using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace PaizaTest
{
    class Program
    {                
        static void Solve()
        {
            var ss = new StreamScanner(Console.OpenStandardInput());
            

            return;
        }

        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);
                Solve(); 
                sw.Flush();
            }
        }
    }

    #region StreamScanner

    public class StreamScanner
    {
        public StreamScanner(Stream stream) { _str = stream; }

        private const int KB = 1 << 10;
        private readonly Stream _str;
        private readonly byte[] _buffer = new byte[KB];
        private int len, ptr;
        public bool isEof = false;
        public bool IsEndOfStream { get { return isEof; } }
        private byte Read()
        {
            if (isEof) throw new EndOfStreamException();
            if (ptr >= len)
            {
                ptr = 0;
                if ((len = _str.Read(_buffer, 0, KB)) <= 0)
                {
                    isEof = true;
                    return 0;
                }
            }
            return _buffer[ptr++];
        }
        public char Char()
        {
            byte b;
            do b = Read();
            while (b < 33 || 126 < b);
            return (char)b;
        }
        public string Next()
        {
            var sb = new StringBuilder();
            for (var b = Char(); b >= 33 && b <= 126; b = (char)Read())
                sb.Append(b);
            return sb.ToString();
        }
        public long NextLong()
        {
            long ret = 0;
            var ng = false;
            byte b;
            do b = Read();
            while (b != '-' && (b < '0' || '9' < b));
            if (b == '-') { ng = true; b = Read(); }
            for (; true; b = Read())
            {
                if (b < '0' || '9' < b)
                    return ng ? -ret : ret;
                else ret = ret * 10 + b - '0';
            }
        }
        public int NextInt() => (int)NextLong();
        public double NextDouble() => double.Parse(Next(), CultureInfo.InvariantCulture);
        public BigInteger NextBigInt() => BigInteger.Parse(Next());
    }

    #endregion
}
