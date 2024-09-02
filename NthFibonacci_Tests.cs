using NUnit.Framework;
using System;

[TestFixture]
public class NthFibonacci_Tests
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
        long actual = GD1_CH5to6.NthFibonacci(1);
        long expected = 0;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        long actual = GD1_CH5to6.NthFibonacci(2);
        long expected = 1;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        long actual = GD1_CH5to6.NthFibonacci(3);
        long expected = 1;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        long actual = GD1_CH5to6.NthFibonacci(4);
        long expected = 2;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        long actual = GD1_CH5to6.NthFibonacci(5);
        long expected = 3;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        long actual = GD1_CH5to6.NthFibonacci(6);
        long expected = 5;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        long actual = GD1_CH5to6.NthFibonacci(7);
        long expected = 8;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        long actual = GD1_CH5to6.NthFibonacci(30);
        long expected = 514229;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        long actual = GD1_CH5to6.NthFibonacci(50);
        long expected = 7778742049;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        long actual = GD1_CH5to6.NthFibonacci(67);
        long expected = 27777890035288;

        Assert.That(actual, Is.EqualTo(expected));
    }
}

