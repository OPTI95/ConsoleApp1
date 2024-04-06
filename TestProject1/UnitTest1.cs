namespace TestProject1;
using Xunit;
using ConsoleApp1;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
[TestClass]
public class MathFunctionsTests
{
    [Fact]
    [TestMethod]
    public void TestAddition()
    {
        // Arrange
        int a = 5;
        int b = 10;
        int expectedSum = 15;

        // Act
        int actualSum = MathFunctions.Add(a, b);

        // Assert
        Assert.Equal(expectedSum, actualSum);
    }
    [TestMethod]
    [Theory]
    [InlineData(5, 120)] // 5! = 120
    [InlineData(0, 1)]   // 0! = 1
    public void TestFactorial(int n, int expectedFactorial)
    {
        // Act
        int actualFactorial = MathFunctions.Factorial(n);

        // Assert
        Assert.Equal(expectedFactorial, actualFactorial);
    }
    [TestMethod]
    [Theory]
    [InlineData(7)]
    [InlineData(11)]
    public void TestPrime(int primeNumber)
    {
        // Act
        bool isPrime = MathFunctions.IsPrime(primeNumber);

        // Assert
        Assert.True(isPrime);
    }
}
[TestClass]
public class StringFunctionsTests
{
    [TestMethod]
    [Fact]
    public void TestReverseString()
    {
        // Arrange
        string inputString = "hello";
        string expectedReversedString = "olleh";

        // Act
        string actualReversedString = StringFunctions.ReverseString(inputString);

        // Assert
        Assert.Equal(expectedReversedString, actualReversedString);
    }
    [TestMethod]
    [Fact]
    public void TestIsPalindrome()
    {
        // Arrange
        string palindrome = "radar";

        // Act
        bool isPalindrome = StringFunctions.IsPalindrome(palindrome);

        // Assert
        Assert.True(isPalindrome);
    }
}