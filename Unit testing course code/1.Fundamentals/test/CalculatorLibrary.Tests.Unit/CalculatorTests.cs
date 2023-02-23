using Xunit;

namespace CalculatorLibrary.Tests.Unit;

public class CalculatorTests
{
    private readonly Calculator _sut = new();
    
    // private readonly Guid _guid = Guid.NewGuid();

   //private readonly ITestOutputHelper _outputHelper ;
   //Setup goes here
   // public CalculatorTests(ITestOutputHelper outputHelper)
   // {
   //     _outputHelper = outputHelper;
   //     _outputHelper.WriteLine("Hello from the ctor");
   // }
   
   
    // [Theory(Skip = "This braeks in CI")]
    //[InlineData(5, 4, 9)]
    //[InlineData(0, 0, 0)]
    //[InlineData(-5, -5, -10)]
    //public void TestAdd1(int a, int b , int expected)
    //{
    //Act
    //var result = _sut.Add(a, b);
    //Assert
    //Assert.Equal(expected, result);
    //Assert.Should().Be(expected);
    //}

    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(-5, 5, 0)]
    [InlineData(-15, -5, -20)]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        // Act
        var result = _sut.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    //[Fact(Skip = "This is just a test")]
    //public void TestSubtract()
    //{ 
        //Arrange
        //var calculator = new Calculator();
        //Act
        //var result = calculator.Add(5, 4);
        //var result = _sut.Subtract(10, 5);

        //Assert
    //   Assert.Equal(9, result);
        
        //_outputHelper.WriteLine("Hello from the ctor");
    //}

    
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(15, 5, 10)]
    [InlineData(-5, -5, 0)]
    [InlineData(-15, -5, -10)]
    [InlineData(5, 10, -5)]
    public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        // Act
        var result = _sut.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(50, 0, 0)]
    [InlineData(-5, 5, -25)]
    public void Multiply_ShouldMultiplyTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        // Act
        var result = _sut.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 5, 1)]
    [InlineData(15, 5, 3)]
    public void Divide_ShouldDivideTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        // Act
        var result = _sut.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
        
/*
[Fact]
public void TestGuid1()
{
    _outputHelper.WriteLine(_guid.ToString());
}
[Fact]
public void TestGuid2()
{
    _outputHelper.WriteLine(_guid.ToString());
}
*/
   }
}