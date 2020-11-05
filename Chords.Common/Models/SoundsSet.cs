using System;
using Chords.Common.Interfaces;

namespace Chords.Common.Models
{
    public class SoundsSet : ISoundsSet
    {
        public SoundsSet(string bassEStringFretPushed, string aStringFretPushed, string dStringFretPushed, string gStringFretPushed, string hStringFretPushed, string eStringFretPushed)
        {
            this.bassEStringFretPushed = bassEStringFretPushed;
            this.aStringFretPushed = aStringFretPushed;
            this.dStringFretPushed = dStringFretPushed;
            this.gStringFretPushed = gStringFretPushed;
            this.hStringFretPushed = hStringFretPushed;
            this.eStringFretPushed = eStringFretPushed;

        }
        public string bassEStringFretPushed { get; private set; }
        public string aStringFretPushed { get; private set; }
        public string dStringFretPushed { get; private set; }
        public string gStringFretPushed { get; private set; }
        public string hStringFretPushed { get; private set; }
        public string eStringFretPushed { get; private set; }
        public string[,] GetSounds()
        {

            string[,] arr = new string[2, 2] { { "E", "2" }, { "A", "1" } };

            return arr;
        }
        public void SetSounds(string[,] value)
        {

        }

    }
}