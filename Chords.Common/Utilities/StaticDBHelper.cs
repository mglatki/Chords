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
            if(soundSet == null)
            {
                return new string[] {"Input is null"};
            }

            if(!IsInputDataCorrect(soundSet))
            {
                return new string[] {"Wrong input data"};
            }

            string[] arr = new string[] {"Amol", "Dmol"};

            if(
                soundSet.eStringFretPushed.ToLower() == "?"
                && soundSet.hStringFretPushed.ToLower() == "3"
                && soundSet.gStringFretPushed.ToLower() == "2"
                && soundSet.dStringFretPushed.ToLower() == "0"
                && soundSet.aStringFretPushed.ToLower() == "x"
                && soundSet.bassEStringFretPushed.ToLower() == "x"
            )
            {
                arr = new string[] {"Ddur","Dmol"};
            }
            else if(
                soundSet.eStringFretPushed.ToLower() == "1"
                && soundSet.hStringFretPushed.ToLower() == "3"
                && soundSet.gStringFretPushed.ToLower() == "2"
                && soundSet.dStringFretPushed.ToLower() == "0"
                && soundSet.aStringFretPushed.ToLower() == "x"
                && soundSet.bassEStringFretPushed.ToLower() == "x"
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

        private bool IsInputDataCorrect(ISoundsSet soundSet)
        {
            if(IsSoundSetCollectionItemDataCorrect(soundSet.bassEStringFretPushed)
            && IsSoundSetCollectionItemDataCorrect(soundSet.aStringFretPushed)
            && IsSoundSetCollectionItemDataCorrect(soundSet.dStringFretPushed)
            && IsSoundSetCollectionItemDataCorrect(soundSet.gStringFretPushed)
            && IsSoundSetCollectionItemDataCorrect(soundSet.hStringFretPushed)
            && IsSoundSetCollectionItemDataCorrect(soundSet.eStringFretPushed))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsSoundSetCollectionItemDataCorrect(string s)
        {
            switch (s)
            {
                case "x": return true;
                case "?": return true;
                case "0": return true;
                case "1": return true;
                case "2": return true;
                case "3": return true;
                case "4": return true;
                case "5": return true;
                case "6": return true;
                case "7": return true;
                case "8": return true;
                case "9": return true;
                case "10": return true;
                case "11": return true;
                case "12": return true;

                default: return false;
            }
        }
    }
}