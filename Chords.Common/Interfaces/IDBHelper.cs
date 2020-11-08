using System;

namespace Chords.Common.Interfaces
{
    public interface IDBHelper
    {
        string GetChord(ISoundsSet soundSet);
        string[] GetChords(ISoundsSet soundSet);
    }
}