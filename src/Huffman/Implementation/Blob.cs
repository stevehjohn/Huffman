using System.Collections.Generic;

namespace Huffman.Implementation
{
    public class Blob
    {
        private readonly List<byte> _bytes;
        private int _position;

        public Blob()
        {
            _bytes = new List<byte>();
            _position = 0;
        }

        public void Append(string bits)
        {
            if (bits.Length == 0)
            {
                return;
            }

            foreach (var bit in bits)
            {
                if (_position % 8 == 0)
                {
                    _bytes.Add(0);
                }

                if (bit == '1')
                {
                    _bytes[^1] = (byte) (_bytes[^1] | (byte) (1 << (7 - _position % 8)));
                }

                _position++;
            }
        }

        public byte[] ToByteArray()
        {
            return _bytes.ToArray();
        }
    }
}