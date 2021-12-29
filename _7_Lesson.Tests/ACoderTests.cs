using Xunit;

namespace _7_Lesson.Tests
{
    public class ACoderTests
    {
        [Fact]
        public void Encode_AbC_BcdReturned()
        {
            ICoder coder = new ACoder("AbC");

            string expected = "BcD";

            var actual = coder.Encode();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Decode_BcD_AbCReturned()
        {
            ICoder coder = new ACoder("BcD");

            string expected = "AbC";

            var actual = coder.Decode();

            Assert.Equal(expected, actual);
        }
    }
}
