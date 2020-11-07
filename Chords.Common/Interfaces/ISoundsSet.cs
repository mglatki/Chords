using System;

namespace Chords.Common.Interfaces
{
    public interface ISoundsSet
    {
        string bassEStringFretPushed { get; set; }
        string aStringFretPushed { get; set; }
        string dStringFretPushed { get; set; }
        string gStringFretPushed { get; set; }
        string hStringFretPushed { get; set; }
        string eStringFretPushed { get; set; }
        string[,] GetSounds();
        void SetSounds(string[,] value);
    }
}