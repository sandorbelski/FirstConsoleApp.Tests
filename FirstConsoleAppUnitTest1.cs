using NUnit.Framework;
using CodeJam;

namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        System.Console.WriteLine("===== Tests started =====");
        
    }

    [Test]
    public void PassedTest()
    {
        Assert.True(true);
    }

    [Test]
    public void FailedTest()
    {
        Assert.True(false);
    }
}