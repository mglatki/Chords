using System;

namespace Chords.Common.Interfaces
{
    public interface ISoundsSet
    {
        string[,] GetSounds();
        void SetSounds(string[,] value);
    }
}