using System;

namespace Chords.Common.Interfaces
{
    public interface ISoundsSet
    {
        string bassEStringFretPushed { get; }
        string aStringFretPushed { get; }
        string dStringFretPushed { get; }
        string gStringFretPushed { get; }
        string hStringFretPushed { get; }
        string eStringFretPushed { get; }
        string[,] GetSounds();
        void SetSounds(string[,] value);
    }
}