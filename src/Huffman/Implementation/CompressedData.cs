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

            var frequencyTable = new byte[frequencies.Count * 8];

            var count = 0;

            foreach (var item in frequencies)
            {
                Buffer.BlockCopy(BitConverter.GetBytes(item.Frequency), 0, frequencyTable, count * 8, 4);
                Buffer.BlockCopy(BitConverter.GetBytes((int) item.Character), 0, frequencyTable, count * 8 + 4, 4);

                count++;
            }

            var data = new byte[4 + frequencyTable.Length + Data.Length];

            Buffer.BlockCopy(BitConverter.GetBytes(frequencies.Count), 0, data, 0, 4);
            Buffer.BlockCopy(frequencyTable, 0, data, 4, frequencyTable.Length);
            Buffer.BlockCopy(Data, 0, data, 4 + frequencyTable.Length, Data.Length);

            return data;
        }

        public void Load(byte[] data)
        {
            var frequencies = new List<CharacterFrequency>();

            var frequencyCount = BitConverter.ToInt32(data, 0);

            for (var i = 0; i < frequencyCount * 8; i += 8)
            {
                var frequency = BitConverter.ToInt32(data, 4 + i);
                var character = (char) BitConverter.ToInt32(data, 8 + i);

                frequencies.Add(new CharacterFrequency { Frequency = frequency, Character = character });
            }

            Frequencies = frequencies;

            Data = new byte[data.Length - 4 - frequencyCount * 8];

            Buffer.BlockCopy(data, 4 + frequencyCount * 8, Data, 0, data.Length - 4 - frequencyCount * 8);
        }
    }
}