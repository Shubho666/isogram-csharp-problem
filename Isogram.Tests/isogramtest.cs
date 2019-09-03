using System;
using System.Collections.Generic;
using System.Text;
using isogram_csharp_problem;
using Xunit;

namespace Isogram.Tests
{
    public class isogramtest
    {
        
        [Theory]
        [InlineData("", true)]
        [InlineData("isogram", true)]
        [InlineData("eleven", false)]
        [InlineData("subdermatoglyphic", true)]
        [InlineData("Alphabet", true)]
        [InlineData("thumbscrew-japingly", true)]
        [InlineData("six-year-old", true)]
        [InlineData("n a m e", true)]
        [InlineData("QWERTYUIOPASDFGHJKLZXCVBNM - - -qwertyuiop  asdfghjkl zxcvbnm", true)]

        [InlineData("QWERTYUIOPASDFGHJKLZXCVBNM - - -qwerrtyuiop  asdfghjkl zxcvbnm", false)]
        public void CheckIsogram(string x,bool y)
        {
            Assert.Equal(Program.IsogramCheck(x), y);
        }
    }
}
