using System;
using code;
using Shouldly;
using Xunit;

namespace tests
{
    public class AlternatingSplitTest
    {
        private string testString = "This is a test!";
        private AlternatingSplit altSplit = new AlternatingSplit();
        [Fact]
        public void EncryptsCorrectly()
        {
            altSplit.Encrypt(testString, 0).ShouldBe("This is a test!");
			altSplit.Encrypt(testString, 1).ShouldBe("hsi  etTi sats!");
            altSplit.Encrypt(testString, 2).ShouldBe("s eT ashi tist!");
            altSplit.Encrypt(testString, 3).ShouldBe(" Tah itse sits!");
            altSplit.Encrypt(testString, 4).ShouldBe("This is a test!");
            altSplit.Encrypt(testString, -1).ShouldBe("This is a test!");
            altSplit.Encrypt("This kata is very interesting!", 1).ShouldBe("hskt svr neetn!Ti aai eyitrsig");
        }

        [Fact]
        public void EmptyTests()
        {
            altSplit.Encrypt("", 0).ShouldBe(String.Empty);
        }

        [Fact]
        public void NullTests()
        {
            altSplit.Encrypt(null, 0).ShouldBe(null); 
        }
    }
}