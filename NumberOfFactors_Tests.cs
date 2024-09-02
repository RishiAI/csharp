using NUnit.Framework;
using System;

[TestFixture]
public class NumberOfFactors_Tests
{
    [SetUp]
    public void SetUp()
    {
        // Setup code here (if required)
    }

    [TearDown]
    public void TearDown()
    {
        // Teardown code here (if required)
    }

    [Test]
    public void Test1()
    {
        int num = 1;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 1;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int num = 5;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 2;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test3()
    {
        int num = 6;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 4;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test4()
    {
        int num = 11;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 2;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test5()
    {
        int num = 48;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 10;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test6()
    {
        int num = 1000;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 16;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test7()
    {
        int num = 1234;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 4;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test8()
    {
        int num = 43;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 2;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test9()
    {
        int num = 85;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 4;

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test10()
    {
        int num = 99;
        int actual = GD1_CH3to4.NumberOfFactors(num);
        int expected = 6;

        Assert.That(actual, Is.EqualTo(expected));

    }

}

