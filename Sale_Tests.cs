using NUnit.Framework;
using System;

[TestFixture]
public class Sale_Tests
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
        float cost1 = 1.25f;
        float cost2 = 2.5f;
        float cost3 = 3f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);
        
        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 6.125f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test2()
    {
        float cost1 = 2.5f;
        float cost2 = 2.5f;
        float cost3 = 2.5f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 6.25f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test3()
    {
        float cost1 = 8f;
        float cost2 = 8f;
        float cost3 = 14f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 26.0f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test4()
    {
        float cost1 = .5f;
        float cost2 = .5f;
        float cost3 = 3.8f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 4.55f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test5()
    {
        float cost1 = 1.25f;
        float cost2 = 2.5f;
        float cost3 = 1.25f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 4.375f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test6()
    {
        float cost1 = 125.87f;
        float cost2 = 267.9f;
        float cost3 = 123.7f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 455.619995f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test7()
    {
        float cost1 = 87.87f;
        float cost2 = 19.5f;
        float cost3 = 13.97f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 114.355003f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test8()
    {
        float cost1 = 45.6f;
        float cost2 = 123.84f;
        float cost3 = 333.17f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 479.809998f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test9()
    {
        float cost1 = 18.6f;
        float cost2 = 14.32f;
        float cost3 = 8.88f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 37.3599968f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

    [Test]
    public void Test10()
    {
        float cost1 = 98.43f;
        float cost2 = 12.54f;
        float cost3 = 6.78f;
        GD1_CH3to4.Sale(ref cost1, ref cost2, ref cost3);

        float actualCost = cost1 + cost2 + cost3;
        float expectedCost = 114.36f;

        Assert.That(actualCost, Is.EqualTo(expectedCost).Within(.0001));

    }

}

