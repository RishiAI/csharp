using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class EvaluateScores_Tests
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
        (string, int)[] input = { ("Bob", 5), ("Tina", 5), ("Jane", 5), ("Vance", 5) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Bob", "Tina", "Jane", "Vance" };
        string[] expectedPassers = { "Bob", "Tina", "Jane", "Vance" };
        float passPercentage = 1.0f;
        float average = 5.0f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test2()
    {
        (string, int)[] input = { ("Bob", 1), ("Tina", 2), ("Jane", 3), ("Vance", 4), ("James", 5) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Bob", "Tina", "Jane", "Vance", "James" };
        string[] expectedPassers = { "Jane", "Vance", "James" };
        float passPercentage = 0.600f;
        float average = 3.0f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test3()
    {
        (string, int)[] input = { ("Bob", 1), ("Tina", 2), ("Jane", 2), ("Vance", 1) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Bob", "Tina", "Jane", "Vance" };
        string[] expectedPassers = {};
        float passPercentage = 0.0f;
        float average = 1.5f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test4()
    {
        (string, int)[] input = { ("Alex", 5), ("Tina", 3), ("Ted", 1), ("Luke", 2), ("Billy",5)};

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Alex", "Tina", "Ted", "Luke", "Billy"};
        string[] expectedPassers = { "Alex", "Tina", "Billy" };
        float passPercentage = 0.60f;
        float average = 3.2f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test5()
    {
        (string, int)[] input = { ("Alex", 5), ("Tina", 4), ("Ted", 4), ("Luke", 2), ("Billy", 4) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Alex", "Tina",  "Ted", "Luke", "Billy" };
        string[] expectedPassers = { "Alex", "Tina", "Ted",  "Billy" };
        float passPercentage = 0.80f;
        float average = 3.79999f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test6()
    {
        (string, int)[] input = { ("Alex", 4), ("Tina", 1), ("Ted", 2), ("Luke", 5), ("Billy", 3), ("Turtle", 3),("Harris",3)};

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Alex",  "Tina", "Ted", "Luke", "Billy",  "Turtle",  "Harris" };
        string[] expectedPassers = { "Alex",  "Luke", "Billy", "Turtle", "Harris" };
        float passPercentage = 0.714285731f;
        float average = 3.0f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test7()
    {
        (string, int)[] input = { ("Alex", 2), ("Tina", 3), ("Ted", 1), ("Luke", 1), ("Billy", 3), ("Turtle", 2), ("Harris", 2), ("Jack",2), ("Gabby",4)};

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Alex", "Tina", "Ted", "Luke", "Billy", "Turtle", "Harris", "Jack", "Gabby"};
        string[] expectedPassers = {  "Tina", "Billy", "Gabby" };
        float passPercentage = 0.333333343f;
        float average = 2.22222233f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }


    [Test]
    public void Test8()
    {
        (string, int)[] input = { ("Alex", 5), ("Tina", 4), ("Ted", 3), ("Luke", 3), ("Billy", 2), ("Turtle", 5), ("Harris",4), ("Jack", 5), ("Gabby", 4) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Alex", "Tina", "Ted", "Luke", "Billy", "Turtle", "Harris", "Jack", "Gabby" };
        string[] expectedPassers = { "Alex", "Tina", "Ted", "Luke", "Turtle", "Harris", "Jack", "Gabby" };
        float passPercentage = 0.888888896f;
        float average = 3.88888884f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test9()
    {
        (string, int)[] input = { ("Apple", 3), ("Pear", 2), ("Bananas", 5) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Apple", "Pear", "Bananas" };
        string[] expectedPassers = { "Apple", "Bananas" };
        float passPercentage = .66666f;
        float average = 3.33333f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

    [Test]
    public void Test10()
    {
        (string, int)[] input = { ("Victor", 1), ("Jim", 3), ("Blake", 2), ("Vin", 1) };

        (string[], string[], float, float) results = GD2_CH1to3.EvaluateScores(input);
        string[] expectedTakers = { "Victor", "Jim", "Blake", "Vin" };
        string[] expectedPassers = {  "Jim" };
        float passPercentage = 0.25f;
        float average = 1.75f;

        Assert.That(results.Item1, Is.EqualTo(expectedTakers));
        Assert.That(results.Item2, Is.EqualTo(expectedPassers));
        Assert.That(results.Item3, Is.EqualTo(passPercentage).Within(.0001));
        Assert.That(results.Item4, Is.EqualTo(average).Within(.0001));
    }

}