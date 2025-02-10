using NUnit.Framework;
using System;
using System.IO;

public class FibonacciGeneratorTests
{
    private FibonacciGenerator generator;
    private StringWriter consoleOutput;

    [SetUp]
    public void Setup()
    {
        generator = new FibonacciGenerator();
        consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
    }

    [TearDown]
    public void TearDown()
    {
        consoleOutput.Dispose();
        Console.SetOut(Console.Out);
    }

    [Test]
    public void PrintFibonacciSeries_NegativeInput_PrintsErrorMessage()
    {
        generator.PrintFibonacciSeries(-5);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("Input must be a non-negative integer."));
    }

    [Test]
    public void PrintFibonacciSeries_ZeroInput_PrintsNothing()
    {
        generator.PrintFibonacciSeries(0);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo(""));
    }

    [Test]
    public void PrintFibonacciSeries_OneInput_PrintsZero()
    {
        generator.PrintFibonacciSeries(1);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0"));
    }

    [Test]
    public void PrintFibonacciSeries_TwoInput_PrintsZeroAndOne()
    {
        generator.PrintFibonacciSeries(2);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1"));
    }

    [Test]
    public void PrintFibonacciSeries_FiveInput_PrintsCorrectSequence()
    {
        generator.PrintFibonacciSeries(5);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3"));
    }

    [Test]
    public void PrintFibonacciSeries_TenInput_PrintsCorrectSequence()
    {
        generator.PrintFibonacciSeries(10);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34"));
    }

    [Test]
    public void PrintFibonacciSeries_LargeInput_PrintsCorrectSequence()
    {
        generator.PrintFibonacciSeries(15);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n55\r\n89\r\n144\r\n233\r\n377"));
    }
}