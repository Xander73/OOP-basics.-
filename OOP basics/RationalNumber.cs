using System;

namespace OOP_basics
{
    public class RationalNumber
    {
        private int _numerator;
        private int _denomerator;

        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }

        public int Denomerator
        {
            get => _denomerator;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Делитель меньше единицы.");
                }
                else
                {
                    _denomerator = value;
                }
            }
        }


        public RationalNumber(int numerator, int denomerator)
        {
            Numerator = numerator;
            Denomerator = denomerator;
        }


        public static bool operator ==(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) == (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static bool operator !=(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) != (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static bool operator <(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) < (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static bool operator >(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) > (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static bool operator <=(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) <= (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static bool operator >=(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            return (firstNumber.Numerator / firstNumber.Denomerator) >= (secondNumber.Numerator / secondNumber.Denomerator);
        }


        public static RationalNumber operator +(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            int returnedNomenator = firstNumber.Numerator * secondNumber.Denomerator +
                                    secondNumber.Numerator * firstNumber.Denomerator;

            int returnedDenomerator = firstNumber.Denomerator * secondNumber.Denomerator;

            return new RationalNumber(returnedNomenator, returnedDenomerator);
        }


        public static RationalNumber operator -(RationalNumber firstNumber, RationalNumber secondNumber)
        {
            int returnedNomenator = firstNumber.Numerator * secondNumber.Denomerator -
                                    secondNumber.Numerator * firstNumber.Denomerator;

            int returnedDenomerator = firstNumber.Denomerator * secondNumber.Denomerator;

            return new RationalNumber(returnedNomenator, returnedDenomerator);
        }


        public static RationalNumber operator ++(RationalNumber number) => 
            new RationalNumber(number.Numerator + number.Denomerator, number.Denomerator);


        public static RationalNumber operator --(RationalNumber number) =>
            new RationalNumber(number.Numerator - number.Denomerator, number.Denomerator);


        public override string ToString()
        {
            return Numerator.ToString() + " / " + Denomerator.ToString();
        }


        public static implicit operator float (RationalNumber number) => (float) number.Numerator / number.Denomerator;


        public static explicit operator int (RationalNumber number) => (int)number.Numerator / number.Denomerator;


        public static RationalNumber operator *(RationalNumber firstNumber, RationalNumber secondNumber) =>
            new RationalNumber(
                                firstNumber.Numerator * secondNumber.Numerator,
                                firstNumber.Denomerator * secondNumber.Denomerator);


        public static RationalNumber operator *(RationalNumber firstNumber, int scale) =>
            new RationalNumber(
                                firstNumber.Numerator * scale,
                                firstNumber.Denomerator);


        public static RationalNumber operator /(RationalNumber firstNumber, RationalNumber secondNumber) =>
            new RationalNumber(
                                firstNumber.Numerator * secondNumber.Denomerator,
                                firstNumber.Denomerator * secondNumber.Numerator);


        public static RationalNumber operator /(RationalNumber firstNumber, int scale) =>
            new RationalNumber(
                                firstNumber.Numerator,
                                firstNumber.Denomerator * scale);

        /// <summary>
        /// Метод вычисляет остаток от деления для числителя и знаменателя и возвращает новое рациональеное число 
        /// с числителем равным остатку от деления исходного числителя и знаменателем равным остатку от деления 
        /// исходного знаменателя
        /// </summary>
        /// <param name="firstNumber">Исходное рациональное число</param>
        /// <param name="scale">Число, на которое будет разделено рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator %(RationalNumber firstNumber, int scale) =>
            new RationalNumber(
                                firstNumber.Numerator % scale,
                                firstNumber.Denomerator % scale);
    }
}
