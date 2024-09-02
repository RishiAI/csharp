using NUnit.Framework;
using System;

[TestFixture]
public class Totals_Tests
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
        float[] costs = { 3.00f};
        (float,float ) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 3f;
        float expectedTaxedTotal = 3.24749994f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test2()
    {
        float[] costs = { 1.53f, 2.87f };
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 4.39999962f;
        float expectedTaxedTotal = 4.76299953f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test3()
    {
        float[] costs = { 19.50f, 17.67f ,2023.76f, 46.22f, 99.87f, 92.12f, 32.65f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 2331.79004f;
        float expectedTaxedTotal = 2524.1626f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test4()
    {
        float[] costs = { 1.17f, 2.46f, .55f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 4.18000031f;
        float expectedTaxedTotal = 4.52485037f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test5()
    {
        float[] costs = { .25f, .10f, .55f, .17f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 1.06999993f;
        float expectedTaxedTotal = 1.15827489f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test6()
    {
        float[] costs = { 17.99f, 5.43f, 6.87f, 17.53f, 55.28f, 22.43f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 125.529999f;
        float expectedTaxedTotal = 135.886215f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test7()
    {
        float[] costs = { 14.23f, 7.77f, 7.66f, 1111.11f, 35.37f, 22.40f, 123.43f, 5.78f, 6.77f, 1.92f, 55.77f, 22.40f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 1414.61023f;
        float expectedTaxedTotal = 1531.31555f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test8()
    {
        float[] costs = { .08f, 1.01f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 1.09000003f;
        float expectedTaxedTotal = 1.17992496f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test9()
    {
        float[] costs = { 3.09f, 3.00f, 8.88f};
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 14.9700003f;
        float expectedTaxedTotal = 16.2050247f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }


    [Test]
    public void Test10()
    {
        float[] costs = { 1.76f, 7.65f, 6.11f, 18.81f };
        (float, float) results = GD2_CH1to3.Totals(costs);
        float expectedSubtotal = 34.3300018f;
        float expectedTaxedTotal = 37.1622276f;

        Assert.That(results.Item1, Is.EqualTo(expectedSubtotal).Within(.0001));
        Assert.That(results.Item2, Is.EqualTo(expectedTaxedTotal).Within(.0001));
    }

}

