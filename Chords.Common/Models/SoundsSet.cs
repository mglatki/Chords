using Chords.Common.Interfaces;
using System;
using System.Threading.Tasks;

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

        public SoundsSet(ISoundsSet soundsSet)
        {
            this.bassEStringFretPushed = soundsSet.bassEStringFretPushed;
            this.aStringFretPushed = soundsSet.aStringFretPushed;
            this.dStringFretPushed = soundsSet.dStringFretPushed;
            this.gStringFretPushed = soundsSet.gStringFretPushed;
            this.hStringFretPushed = soundsSet.hStringFretPushed;
            this.eStringFretPushed = soundsSet.eStringFretPushed;

        }

        public string bassEStringFretPushed { get; private set; }
        public string aStringFretPushed { get; private set; }
        public string dStringFretPushed { get; private set; }
        public string gStringFretPushed { get; private set; }
        public string hStringFretPushed { get; private set; }
        public string eStringFretPushed { get; private set; }

        public string[,] GetSounds()
        {

            string[,] arr = new string[6, 2] 
                {   
                    { "E", bassEStringFretPushed }, 
                    { "A", aStringFretPushed }, 
                    { "D", dStringFretPushed } , 
                    { "G", gStringFretPushed } , 
                    { "H", hStringFretPushed } , 
                    { "E", eStringFretPushed }  
                };

            return arr;
        }

        public void SetSounds(string[,] value)
        {

        }

    }
}