using NUnit.Framework;
using System;

[TestFixture]
public class Gather_Tests
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
        char[] farm = { '-','H'};
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 2;
       

        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test2()
    {
        char[] farm = { 'H' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 0;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test3()
    {
        char[] farm = { '-', 'F', 'H' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 6;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test4()
    {
        char[] farm = { 'F', 'H', 'F' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 4;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test5()
    {
        char[] farm = { 'H', 'F', 'F', '-' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 12;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test6()
    {
        char[] farm = { 'F', '-', 'H', '-', 'F', '-', '-', '-'};
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 18;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test7()
    {
        char[] farm = { '-', '-', 'F', 'H', 'F', '-', 'F', 'F' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 24;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test8()
    {
        char[] farm = { 'F', 'F', 'F', 'H', 'F', '-', 'F', 'F' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 28;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test9()
    {
        char[] farm = { 'F','F','-', 'H' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 10;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }

    [Test]
    public void Test10()
    {
        char[] farm = { 'F', 'H','F','F','F' };
        int moves = GD2_CH1to3.Gather(farm);
        int expectedMovesl = 14;


        Assert.That(moves, Is.EqualTo(expectedMovesl));
    }


}

