using System;
using Chords.Common.Interfaces;
using Chords.Common.Models;
using Chords.Common.Utilities;

namespace Chords.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDBHelper DB = new StaticDBHelper();
            ISoundsSet ss = new SoundsSet("","","","","","");
            
            Console.WriteLine(DB.GetChord(ss));
        }
    }
}
