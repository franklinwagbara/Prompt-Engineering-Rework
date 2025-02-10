using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FibonacciTests
{
    private Fibonacci fibonacci;
    private StringWriter consoleOutput;

    [SetUp]
    public void Setup()
    {
        fibonacci = new Fibonacci();
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
    public void PrintFibonacciSeries_NegativeInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => fibonacci.PrintFibonacciSeries(-1));
    }

    [Test]
    public void PrintFibonacciSeries_ZeroInput_DoesNotPrintAnything()
    {
        fibonacci.PrintFibonacciSeries(0);
        Assert.That(consoleOutput.ToString(), Is.EqualTo(""));
    }

    [Test]
    public void PrintFibonacciSeries_OneInput_PrintsZero()
    {
        fibonacci.PrintFibonacciSeries(1);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0"));
    }

    [Test]
    public void PrintFibonacciSeries_TwoInput_PrintsZeroAndOne()
    {
        fibonacci.PrintFibonacciSeries(2);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1"));
    }

    [Test]
    public void PrintFibonacciSeries_FiveInput_PrintsCorrectSequence()
    {
        fibonacci.PrintFibonacciSeries(5);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3"));
    }

    [Test]
    public void PrintFibonacciSeries_TenInput_PrintsCorrectSequence()
    {
        fibonacci.PrintFibonacciSeries(10);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34"));
    }

    [Test]
    public void PrintFibonacciSeries_LargeInput_PrintsCorrectSequence()
    {
        fibonacci.PrintFibonacciSeries(15);
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n55\r\n89\r\n144\r\n233\r\n377"));
    }
}