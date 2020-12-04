namespace Huffman.Implementation
{
    public class BitReader
    {
        private readonly byte[] _data;
        private int _bytePosition;
        private int _bitPosition = 7;

        public BitReader(byte[] data)
        {
            _data = data;
        }

        public bool Read()
        {
            var bit = (_data[_bytePosition] & (byte) (1 << _bitPosition)) > 0;

            _bitPosition--;

            if (_bitPosition == -1)
            {
                _bitPosition = 7;
                _bytePosition++;
            }

            return bit;
        }
    }
}