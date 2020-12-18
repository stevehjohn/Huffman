namespace Huffman.Implementation
{
    public class BitReader
    {
        private readonly byte[] _data;
        private int _bytePosition;
        private byte _bit = 128;

        public BitReader(byte[] data)
        {
            _data = data;
        }

        public bool Read()
        {
            var bit = (_data[_bytePosition] & _bit) > 0;

            _bit = (byte) (_bit >> 1);

            if (_bit == 0)
            {
                _bit = 128;
                _bytePosition++;
            }

            return bit;
        }
    }
}