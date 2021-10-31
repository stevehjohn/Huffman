using System;
using System.Diagnostics.CodeAnalysis;

namespace Huffman.Implementation
{
    public class Blob
    {
        private const int InitialBufferSize = 8_000;

        private int _bitPosition = -1;
        private int _bytePosition = -1;
        private byte[] _bytes;

        public Blob()
        {
            _bytes = new byte[InitialBufferSize];
        }

        public void Append([NotNull] string bits)
        {
            var bufferSize = _bytes.Length;
            foreach (var bit in bits)
            {
                if (_bitPosition == -1)
                {
                    _bitPosition = 7;
                    _bytePosition++;

                    if (_bytePosition == bufferSize)
                    {
                        bufferSize = _bytePosition * 2;
                        Array.Resize(ref _bytes, bufferSize);
                    }
                }

                if (bit == '1')
                {
                    _bytes[_bytePosition] = (byte) (_bytes[_bytePosition] | (byte) (1 << _bitPosition));
                }

                _bitPosition--;
            }
        }

        public byte[] ToByteArray()
        {
            return _bytes[..(_bytePosition+1)];
        }
    }
}