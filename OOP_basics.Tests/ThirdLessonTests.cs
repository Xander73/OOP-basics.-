using Xunit;


namespace OOP_basics.Tests
{
    public class ThirdLessonTests
    {
        [Fact]
        public void ReverseStringLoop_Abc_CbaReturned ()
        {
            string expected = "cba";
            string argument = "abc";

            string actual = OtherMethods.ThirdLesson.ReverseStringLoop(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReverseStringLoop_Abcd_DcbaReturned()
        {
            string expected = "dcba";
            string argument = "abcd";

            string actual = OtherMethods.ThirdLesson.ReverseStringLoop(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReverseStringLoop_mnbvcxz1234567890_0987654321zxcvbnmReturned()
        {
            string expected = "0987654321zxcvbnm";
            string argument = "mnbvcxz1234567890";

            string actual = OtherMethods.ThirdLesson.ReverseStringLoop(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReverseStringStack_Abc_CbaReturned()
        {
            string expected = "cba";
            string argument = "abc";

            string actual = OtherMethods.ThirdLesson.ReverseStringStack(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReverseStringStack_Abcd_DcbaReturned()
        {
            string expected = "dcba";
            string argument = "abcd";

            string actual = OtherMethods.ThirdLesson.ReverseStringStack(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReverseStringStack_mnbvcxz1234567890_0987654321zxcvbnmReturned()
        {
            string expected = "0987654321zxcvbnm";
            string argument = "mnbvcxz1234567890";

            string actual = OtherMethods.ThirdLesson.ReverseStringStack(argument);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void SearchMail_SpecialStringWithEmail_OnlyEmailReturned()
        {
            string expected = "Kuchma@mail.ru\nPasha@mail.ru\n";
            string actual = "";
            OtherMethods.ThirdLesson.SearchMail(ref actual);

            Assert.Equal(expected, actual);
        }
    }
}
