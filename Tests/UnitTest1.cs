using BadRulesProject;

namespace Tests;

public class UnitTest1
{
    
    [Fact] // A single, independent test case
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(5, 3);

        // Assert
        Assert.Equal(8, result);
    }
    
    
    [Theory] // Data-driven test case with multiple inputs
    [InlineData(6, 2, 3)]
    [InlineData(10, 2, 5)]
    [InlineData(15, 5, 3)]
    public void Divide_ValidInputs_ReturnsCorrectQuotient(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}