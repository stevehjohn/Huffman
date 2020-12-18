using System;

namespace Huffman.Implementation
{
    public class BitReader
    {
        private readonly byte[] _data;
        private int _bytePosition;
        private byte _bit = 128;
        private byte _currentByte;

        public BitReader(byte[] data)
        {
            _data = new byte[data.Length + 1];
            Buffer.BlockCopy(data, 0, _data, 0, data.Length);
            _currentByte = data[0];
        }

        public bool Read()
        {
            var bit = (_currentByte & _bit) > 0;

            _bit = (byte) (_bit >> 1);

            if (_bit == 0)
            {
                _bit = 128;
                _bytePosition++;
                _currentByte = _data[_bytePosition];
            }

            return bit;
        }
    }
}