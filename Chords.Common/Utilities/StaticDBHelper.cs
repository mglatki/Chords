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

            return arr;
        }

    }
}