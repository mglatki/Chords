using System;
using Chords.Common.Interfaces;

namespace Chords.Common.Models
{
    public class SoundsSet : ISoundsSet
    {
        public string[,] GetSounds()
        {
            string[,] arr = new string [2,2] { { "E", "2"}, { "A", "1" } };

            return arr;
        }
        public void SetSounds(string[,] value)
        {

        }
        
    }
}