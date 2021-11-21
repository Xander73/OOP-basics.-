using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basics
{
    public class ComplexNumber
    {
        //обозначил а и b т. к. это стандартные обозначения вещественной и мнимой частей
        private double _a;
        private double _b;

        public double A { 
            get => _a; 
            set => _a = value; }
        public double B {
            get => _b;
            set => _b = value;
        }


        public ComplexNumber(double a, double b)
        {
            A = a;
            B = b;
        }


        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second) =>
            new ComplexNumber(first.A + second.A, first.B + second.B);


        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second) =>
            new ComplexNumber(first.A - second.A, first.B - second.B);


        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second) =>
            new ComplexNumber(
                first.A * second.A - first.B * second.B,
                first.B * second.A + first.A * second.B);


        public static bool operator ==(ComplexNumber first, ComplexNumber second) =>
            (first.A == second.A) && (first.B == second.B);


        public static bool operator !=(ComplexNumber first, ComplexNumber second) =>
            (first.A != second.A) || (first.B != second.B);


        public override string ToString() =>
            B > 0 ? (A + "+" + B + 'i') : ($"{A}{B}i");
    }
}
