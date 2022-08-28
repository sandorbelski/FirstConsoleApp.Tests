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
    public void Test_001()
    {
        Employee epl = new Employee("Ivan", "Bulkin", 3, 7);
        int income = epl.getIncomeSum(2000); 
        
        Assert.AreEqual(2000, income, "Income value was calculated wrong!");
    }
    
    [Test]
    public void Test_002()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 5, 7);
        int income = epl.getIncomeSum(2000); 
        
        Assert.AreEqual(2000, income, "Income value was calculated wrong!");
    }

    [Test]
    public void Test_003()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 8, 7);
        int income = epl.getIncomeSum(2000); 
        
        Assert.AreEqual(2200, income, "Income value was calculated wrong!");
    }

    [Test]
    public void Test_004()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 2, 10);
        int income = epl.getIncomeSum(2000); 
        
        Assert.AreEqual(2000, income, "Income value was calculated wrong!");
    }

    [Test]
    public void Test_005()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 2, 15);
        int income = epl.getIncomeSum(2000); 
        
        Assert.AreEqual(2300, income, "Income value was calculated wrong!");
    }

    [Test]
    public void Test_006()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 10, 17);
        int income = epl.getIncomeSum(3000); 
        
        Assert.AreEqual(3795, income, "Income value was calculated wrong!");
    }

    [Test]
    public void Test_007()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 10, 18);
        int income = epl.getIncomeSum(0); 
        
        Assert.AreEqual(-1, income, "Income is 0");
    }

    [Test]
    public void Test_008()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 10, 18);
        int income = epl.getIncomeSum(-1000); 
        
        Assert.AreEqual(-1, income, "Income is less than 0");
    }

    [Test]
    public void Test_009()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 0, 18);
        int income = epl.getIncomeSum(3000); 
        
        Assert.AreEqual(-1, income, "Experience Years are 0");
    }

    [Test]
    public void Test_010()
    {
        Employee epl = new Employee("Fedor", "Bulkin", -10, 18);
        int income = epl.getIncomeSum(3000); 
        
        Assert.AreEqual(-1, income, "Experience Years are less than 0");
    }

    [Test]
    public void Test_011()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 10, 0);
        int income = epl.getIncomeSum(3000); 
        
        Assert.AreEqual(-1, income, "Number of passed exams is 0");
    }

    [Test]
    public void Test_012()
    {
        Employee epl = new Employee("Fedor", "Bulkin", 10, -15);
        int income = epl.getIncomeSum(3000); 
        
        Assert.AreEqual(-1, income, "Number of passed exams is less than 0");
    }
}