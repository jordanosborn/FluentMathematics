using System;
using NUnit.Framework;

namespace FluentMathematics.Test;

public class DoubleExtensionsTests
{
    [TestCase(1.01, ExpectedResult = 1)]
    [TestCase(-2.0, ExpectedResult = -1)]
    [TestCase(0.0, ExpectedResult = 0)]
    public int Test_sign_returns_expected(double x)
    {
        return x.Sign();
    }

    [Test]
    public void Test_sin_returns_expected()
    {
        Assert.That((Math.PI / 2).Sin().AlmostEqual(1));
    }
}