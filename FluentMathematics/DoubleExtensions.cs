using System;
using System.Runtime.CompilerServices;

namespace FluentMathematics
{
    public static class DoubleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Abs(this double x) => Math.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acos(this double x) => Math.Acos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acosh(this double x) => Math.Log(x + Math.Sqrt(x * x - 1));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Asin(this double x) => Math.Asin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Asinh(this double x) => Math.Log(x + Math.Sqrt(x * x + 1));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atan(this double x) => Math.Atan(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atanh(this double x) => 0.5 * Math.Log((1 + x) / (1 - x));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cbrt(this double x) => Math.Pow(x, 1.0 / 3.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Ceiling(this double x) => Math.Ceiling(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(this double x, double min, double max)
            => x < min ? min : x > max ? max : x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cos(this double x) => Math.Cos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cosh(this double x) => Math.Cosh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Exp(this double x) => Math.Exp(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Floor(this double x) => Math.Floor(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Inverse(this double x) => 1.0 / x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double InverseSqrt(this double x) => 1.0 / Math.Sqrt(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(this double x) => Math.Log(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(this double x, double newBase) => Math.Log(x, newBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log10(this double x) => Math.Log10(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log2(this double x) => Math.Log(x, 2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Pow(this double x, double y) => Math.Pow(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double x) => Math.Round(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double x, int digits) => Math.Round(x, digits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double x, int digits, MidpointRounding mode) => Math.Round(x, digits, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(this double x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sin(this double x) => Math.Sin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sqrt(this double x) => Math.Sqrt(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Squared(this double x) => x * x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tan(this double x) => Math.Tan(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tanh(this double x) => Math.Tanh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(this double x) => Math.Truncate(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AlmostEqual(this double x, double y, double tolerance = 1e-10) => Math.Abs(x - y) < tolerance;
    }
}