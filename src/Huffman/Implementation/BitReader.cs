using System;
using System.Buffers;

namespace Huffman.Implementation
{
    public class BitReader : IDisposable
    {
        private readonly byte[] _data;
        private int _bytePosition;
        private byte _bit = 128;

        public BitReader(byte[] data)
        {
            _data = ArrayPool<byte>.Shared.Rent(data.Length + 1);
            Buffer.BlockCopy(data, 0, _data, 0, data.Length);
        }

        public bool Read()
        {
            var bit = (_data[_bytePosition] & _bit) > 0;

            _bit = (byte) (_bit >> 1 | _bit << 7);

            _bytePosition += _bit >> 7;

            return bit;
        }

        public void Dispose()
        {
            ArrayPool<byte>.Shared.Return(_data);
        }
    }
}