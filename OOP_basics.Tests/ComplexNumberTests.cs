using Xunit;

namespace OOP_basics.Tests
{
    public class ComplexNumberTests
    {
        [Fact]
        public void ToString_1_1___1Plus1iReturned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);

            string expected = "1+1i";

            var actual = first.ToString();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ToString_Minus1_Minus1___Minus1Minus1iReturned()
        {
            ComplexNumber first = new ComplexNumber(-1, -1);

            string expected = "-1-1i";

            var actual = first.ToString();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void OperatorEqual_1_1and1_1___TrueReturned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 1);

            var actual = first.ToString();

            Assert.True(first == second);
        }


        [Fact]
        public void OperatorEqual_1_1and1_2___FalseReturned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 2);

            var actual = first.ToString();

            Assert.False(first == second);
        }


        [Fact]
        public void OperatorNoEqual_1_1and1_1___FalseReturned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 1);

            Assert.False(first != second);
        }


        [Fact]
        public void OperatorNoEqual_1_1and1_2___TrueReturned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 2);

            Assert.True(first != second);
        }


        [Fact]
        public void OperatorPlus_1_1and1_1___2_2Returned()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 1);

            ComplexNumber expected = new ComplexNumber(2, 2);

            var actual = first + second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMinus_2_2and1_1___1_1Returned()
        {
            ComplexNumber first = new ComplexNumber(2, 2);
            ComplexNumber second = new ComplexNumber(1, 1);

            ComplexNumber expected = new ComplexNumber(1, 1);

            var actual = first - second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMultiply_4_2and3_3___6_18Returned()
        {
            ComplexNumber first = new ComplexNumber(4, 2);
            ComplexNumber second = new ComplexNumber(3, 3);

            ComplexNumber expected = new ComplexNumber(6, 18);

            var actual = first * second;

            Assert.True(expected == actual);
        }
    }
}
