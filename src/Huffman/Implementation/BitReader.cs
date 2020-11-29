namespace Huffman.Implementation
{
    public class BitReader
    {
        private readonly byte[] _data;
        private int _position = -1;

        public BitReader(byte[] data)
        {
            _data = data;
        }

        public bool Read()
        {
            _position++;

            return (_data[_position / 8] & (byte) (1 << (7 - _position % 8))) > 0;
        }
    }
}