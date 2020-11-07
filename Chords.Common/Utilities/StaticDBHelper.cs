using System;
using Chords.Common.Interfaces;

namespace Chords.Common.Utilities
{
    public class StaticDBHelper : IDBHelper
    {
        public StaticDBHelper()
        {
            
        }
        public string GetChord(ISoundsSet soundSet)
        {
            return "Amol";
        }

        public string[] GetChords(ISoundsSet soundSet)
        {

            string[] arr = new string[] {"Amol", "Dmol"};

            if(
                soundSet.eStringFretPushed == "?"
                && soundSet.hStringFretPushed == "3"
                && soundSet.gStringFretPushed == "2"
                && soundSet.dStringFretPushed == "0"
                && soundSet.aStringFretPushed == "x"
                && soundSet.bassEStringFretPushed == "x"
            )
            {
                arr = new string[] {"Ddur","Dmol"};
            }
            else if(
                soundSet.eStringFretPushed == "1"
                && soundSet.hStringFretPushed == "3"
                && soundSet.gStringFretPushed == "2"
                && soundSet.dStringFretPushed == "0"
                && soundSet.aStringFretPushed == "x"
                && soundSet.bassEStringFretPushed == "x"
            )
            {
                arr = new string[] {"Dmol"};
            }
            else 
            {
                arr = new string[] {"else"};
            }

            return arr;
        }

    }
}