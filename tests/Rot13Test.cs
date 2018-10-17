using System;
using Xunit;
using Shouldly;
using code;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void testTest()
        {
            Rot13.ExecuteRot13("test").ShouldBe("grfg");
        }

        [Fact]
        public void TestTest()
        {
            Rot13.ExecuteRot13("Test").ShouldBe("Grfg");
        }

        [Fact]
        public void TestExclamationTest()
        {
            Rot13.ExecuteRot13("TeSt!").ShouldBe("GrFg!");
        }
    }
}
