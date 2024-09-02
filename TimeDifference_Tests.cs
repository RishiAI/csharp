using NUnit.Framework;
using System;

[TestFixture]
public class TimeDifference_Tests
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
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1211, 1433, out actualHours,out actualMinutes);
        int expectedHours = 2;
        int expectedMinutes = 22;
        
        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test2()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(833, 855, out actualHours, out actualMinutes);
        int expectedHours = 0;
        int expectedMinutes = 22;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test3()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1448, 1603, out actualHours, out actualMinutes);
        int expectedHours = 1;
        int expectedMinutes = 15;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test4()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(222, 1622, out actualHours, out actualMinutes);
        int expectedHours = 14;
        int expectedMinutes = 0;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test5()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1445, 2359, out actualHours, out actualMinutes);
        int expectedHours = 9;
        int expectedMinutes = 14;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test6()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(354, 637, out actualHours, out actualMinutes);
        int expectedHours = 2;
        int expectedMinutes = 43;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test7()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1903, 2301, out actualHours, out actualMinutes);
        int expectedHours = 3;
        int expectedMinutes = 58;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test8()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1313, 1414, out actualHours, out actualMinutes);
        int expectedHours = 1;
        int expectedMinutes = 1;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test9()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1112, 1211, out actualHours, out actualMinutes);
        int expectedHours = 0;
        int expectedMinutes = 59;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

    [Test]
    public void Test10()
    {
        int actualMinutes = 0;
        int actualHours = 0;
        GD1_CH1to2.TimeDifference(1547, 2219, out actualHours, out actualMinutes);
        int expectedHours = 6;
        int expectedMinutes = 32;

        Assert.That(actualMinutes, Is.EqualTo(expectedMinutes));
        Assert.That(actualHours, Is.EqualTo(expectedHours));
    }

}

