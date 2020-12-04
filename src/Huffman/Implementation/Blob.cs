using System;
using System.Collections.Generic;

namespace Huffman.Implementation
{
    public class Blob
    {
        private readonly List<byte> _bytes;
        private int _bitPosition = 7;

        public Blob()
        {
            _bytes = new List<byte>();
        }

        public void Append(string bits)
        {
            if (string.IsNullOrWhiteSpace(bits))
            {
                throw new ArgumentOutOfRangeException(nameof(bits));
            }

            foreach (var bit in bits)
            {
                if (_bitPosition == 7)
                {
                    _bytes.Add(0);
                }

                if (bit == '1')
                {
                    _bytes[^1] = (byte) (_bytes[^1] | (byte) (1 << _bitPosition));
                }

                _bitPosition--;

                if (_bitPosition == -1)
                {
                    _bitPosition = 7;
                }
            }
        }

        public byte[] ToByteArray()
        {
            return _bytes.ToArray();
        }
    }
}