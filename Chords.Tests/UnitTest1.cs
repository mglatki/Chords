using System;
using Chords.Common.Interfaces;
using Chords.Common.Models;
using Chords.Common.Utilities;
using Xunit;

namespace Chords.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] expected = new string[] {"Ddur","Dmol"};

            IDBHelper DB = new StaticDBHelper();
            ISoundsSet ss = new SoundsSet("x", "x", "0", "2", "3", "?");

            string[] result = DB.GetChords(ss);

            Assert.Equal(expected,result);
        }
    }
}
