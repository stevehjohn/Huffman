using System;

namespace Huffman.Implementation;

public class BitReader
{
    private readonly byte[] _data;
    private int _bytePosition;
    private byte _bit = 128;

    public BitReader(byte[] data)
    {
        _data = new byte[data.Length + 1];
        Buffer.BlockCopy(data, 0, _data, 0, data.Length);
    }

    public bool Read()
    {
        var bit = (_data[_bytePosition] & _bit) > 0;

        _bit = (byte) (_bit >> 1 | _bit << 7);

        _bytePosition += _bit >> 7;

        return bit;
    }
}