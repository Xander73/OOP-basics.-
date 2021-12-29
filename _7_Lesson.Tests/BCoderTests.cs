using Xunit;

namespace _7_Lesson.Tests
{
    public class BCoderTests
    {
        [Fact]
        public void Encode_AbC_ZyXReturned()
        {
            ICoder coder = new BCoder("AbC");

            string expected = "ZyX";

            var actual = coder.Encode();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Decode_ZyX_AbCReturned()
        {
            ICoder coder = new BCoder("ZyX");

            string expected = "AbC";

            var actual = coder.Decode();

            Assert.Equal(expected, actual);
        }
    }
}
