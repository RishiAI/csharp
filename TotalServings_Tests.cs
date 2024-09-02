using NUnit.Framework;
using System;

[TestFixture]
public class TotalServings_Tests
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
        int actual = GD1_CH1to2.TotalServings(0, 0, 0);
        int expected = 0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int actual = GD1_CH1to2.TotalServings(2, 0, 0);
        int expected = 2;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int actual = GD1_CH1to2.TotalServings(0, 3, 0);
        int expected = 54;
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Test4()
    {
        int actual = GD1_CH1to2.TotalServings(0, 0, 6);
        int expected = 348;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int actual = GD1_CH1to2.TotalServings(1, 2, 3);
        int expected = 211;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        int actual = GD1_CH1to2.TotalServings(3, 1, 2);
        int expected = 137;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        int actual = GD1_CH1to2.TotalServings(44, 7, 19);
        int expected = 1272;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        int actual = GD1_CH1to2.TotalServings(12, 45, 4);
        int expected = 1054;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        int actual = GD1_CH1to2.TotalServings(13, 26, 79);
        int expected = 5063;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        int actual = GD1_CH1to2.TotalServings(3, 6, 33);
        int expected = 2025;
        Assert.That(actual, Is.EqualTo(expected));
    }
}

