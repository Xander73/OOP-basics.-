using System;
using Xunit;

namespace OOP_basics.Tests
{
    public class RationalNumberTests
    {
        [Fact]
        public void Constructor_DenomeratorMinus1_ArgumentExceptionReturned()
        {
            try
            {
                new RationalNumber(1, -1);
            }
            catch (Exception ex)
            {
                Assert.IsType<ArgumentException>(ex);
            }
        }

        [Fact]
        public void Constructor_Denomerator0_ArgumentExceptionReturned()
        {
            try
            {
                new RationalNumber(1, 0);
            }
            catch (Exception ex)
            {
                Assert.IsType<ArgumentException>(ex);
            }
        }

        [Fact]
        public void OperatorEqual_EqualRationalNumbers_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.True(first == second);
        }


        [Fact]
        public void OperatorEqual_NoEqualRationalNumbers_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.False(first == second);
        }


        [Fact]
        public void OperatorNoEqual_NoEqualRationalNumbers_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.True(first != second);
        }


        [Fact]
        public void OperatorNoEqual_EqualRationalNumbers_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.False(first != second);
        }


        [Fact]
        public void OperatorLess_FirstRationalNumberLess_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.True(first < second);
        }


        [Fact]
        public void OperatorLess_SecondRationalNumberLess_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.False(first < second);
        }


        [Fact]
        public void OperatorMore_FirstRationalNumberLess_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.False(first > second);
        }


        [Fact]
        public void OperatorMore_SecondRationalNumberLess_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.True(first > second);
        }


        [Fact]
        public void OperatorLessOrEqual_FirstRationalNumberLess_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.True(first <= second);
        }


        [Fact]
        public void OperatorLessOrEqual_FirstRationalNumberEqual_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.True(first <= second);
        }


        [Fact]
        public void OperatorLessOrEqual_SecondRationalNumberLess_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.False(first <= second);
        }


        [Fact]
        public void OperatorMoreOrEqual_FirstRationalNumberLess_FalseReturned()
        {
            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.False(first >= second);
        }


        [Fact]
        public void OperatorMoreOrEqual_FirstRationalNumberEqual_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 1);

            Assert.True(first >= second);
        }


        [Fact]
        public void OperatorMoreOrEqual_SecondRationalNumberLess_TrueReturned()
        {
            RationalNumber first = new RationalNumber(1, 1);
            RationalNumber second = new RationalNumber(1, 2);

            Assert.True(first >= second);
        }


        [Fact]
        public void OperatorPlus_1_2and1_4____6_8Returned()
        {
            RationalNumber expected = new RationalNumber(6, 8);

            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 4);

            var actual = first + second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMinus_1_2and1_4____2_8Returned()
        {
            RationalNumber expected = new RationalNumber(2, 8);

            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 4);

            var actual = first - second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorIncrement_1_2and____3_2Returned()
        {
            RationalNumber expected = new RationalNumber(3, 2);

            RationalNumber first = new RationalNumber(1, 2);

            var actual = ++first;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorDecrement_1_2and____Minus1_2Returned()
        {
            RationalNumber expected = new RationalNumber(-1, 2);

            RationalNumber first = new RationalNumber(1, 2);

            var actual = --first;

            Assert.True(expected == actual);
        }


        [Fact]
        public void ImplicitToFloat_1_2and____FloatReturned()
        {
            float expected = 0.5f;

            RationalNumber first = new RationalNumber(1, 2);

            float actual = first;

            Assert.True(expected == actual);
        }


        [Fact]
        public void ExplicitToInt_3_2and____IntReturned()
        {
            int expected = 1;

            RationalNumber first = new RationalNumber(3, 2);

            int actual = (int)first;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMultiply_1_2and2____2_2Returned()
        {
            RationalNumber expected = new RationalNumber(2, 2);
            int scale = 2;

            RationalNumber first = new RationalNumber(1, 2);

            var actual = first * scale;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMultiply_1_2and1_2____1_4Returned()
        {
            RationalNumber expected = new RationalNumber(1, 4);

            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 2);

            var actual = first * second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorDivision_1_2and2____2_2Returned()
        {
            RationalNumber expected = new RationalNumber(1, 2);
            int scale = 2;

            RationalNumber first = new RationalNumber(1, 2);


            var actual = first / scale;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorDivision_1_2and1_3____2_2Returned()
        {
            RationalNumber expected = new RationalNumber(2, 2);

            RationalNumber first = new RationalNumber(1, 2);
            RationalNumber second = new RationalNumber(1, 3);


            var actual = first / second;

            Assert.True(expected == actual);
        }


        [Fact]
        public void OperatorMultiply_4_5and3____1_2Returned()
        {
            RationalNumber expected = new RationalNumber(1, 2);
            int scale = 2;

            RationalNumber first = new RationalNumber(4, 5);

            var actual = first % scale;

            Assert.True(expected == actual);
        }
    }
}
