using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Huffman.Implementation
{
    public class Blob
    {
        private const int ChunkSize = 262_144;

        private readonly List<byte[]> _chunks;

        private byte[] _currentChunk;
        private int _bitPosition = -1;
        private int _bytePosition = ChunkSize - 1;
        private int _totalLength;

        public Blob()
        {
            _chunks = new List<byte[]>();
        }

        public void Append([NotNull] string bits)
        {
            foreach (var bit in bits)
            {
                if (_bitPosition == -1)
                {
                    _bitPosition = 7;
                    _bytePosition++;
                    _totalLength++;

                    if (_bytePosition == ChunkSize)
                    {
                        _currentChunk = new byte[ChunkSize];
                        _chunks.Add(_currentChunk);

                        _bytePosition = 0;
                    }
                }

                if (bit == '1')
                {
                    _currentChunk[_bytePosition] = (byte) (_currentChunk[_bytePosition] | (byte) (1 << _bitPosition));
                }

                _bitPosition--;
            }
        }

        public byte[] ToByteArray()
        {
            var buffer = new byte[_totalLength];

            var destinationOffset = 0;

            var toCopy = _totalLength;

            foreach (var chunk in _chunks)
            {
                Buffer.BlockCopy(chunk, 0, buffer, destinationOffset, Math.Min(ChunkSize, toCopy));

                destinationOffset += ChunkSize;

                toCopy -= ChunkSize;
            }

            return buffer;
        }
    }
}