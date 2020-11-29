using System;
using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class CompressedData
    {
        public IEnumerable<CharacterFrequency> Frequencies { get; set; }

        public byte[] Data { get; set; }

        public byte[] Save()
        {
            var frequencies = Frequencies.ToList();

            var frequencyTable = new int[frequencies.Count * 2];

            var count = 0;

            foreach (var item in frequencies)
            {
                frequencyTable[count] = item.Frequency;
                frequencyTable[count + 1] = item.Character;

                count += 2;
            }

            var data = new byte[4 + frequencyTable.Length * 4 + Data.Length];

            Buffer.BlockCopy(new [] { frequencyTable.Length }, 0, data, 0, 4);
            Buffer.BlockCopy(frequencyTable, 0, data, 4, frequencyTable.Length * 4);
            Buffer.BlockCopy(Data, 0, data, 4 + frequencyTable.Length * 4, Data.Length);

            return data;
        }

        public void Load(byte[] data)
        {
        }
    }
}