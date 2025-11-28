using TestxUnit.Methods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestxUnit;

public class NumberHelperFactTests
{
    public static IList<object[]> TestNumbers = new List<object[]>()
    {
        new object[]{4,5,6},
        new object[]{7,8,9},
        new object[]{6,9,8}
    };
    [Fact]
    public void IsOddNumber_ValueOf3_ShouldReturnTrue()
    {
        Assert.True(NumberHelper.IsOddNumber(3));
        Assert.False(NumberHelper.IsEvenNumber(5));
    }

    [Fact]
    public void IsOddNumber_ValueOf6_ShouldReturnFalse()
    {
        Assert.False(NumberHelper.IsOddNumber(6));
    }

    [Fact]
    public void IsEvenNumber_ValueOf3_ShouldReturnFalse()
    {
        Assert.False(NumberHelper.IsEvenNumber(3));
    }

    [Fact]
    public void IsOddNumber_ValueOf6_ShouldReturnTrue()
    {
        Assert.True(NumberHelper.IsEvenNumber(6));
    }

    [Fact]
    public void RatingScore_ValueOf7_EqualsGreat()
    {
        Assert.Equal("Great", NumberHelper.RatingScore(7));
    }

    [Fact]
    public void RatingScore_ValueOf7_DoesNotEqualsBad()
    {
        Assert.NotEqual("Bad", NumberHelper.RatingScore(7));
    }

    [Theory]
    [InlineData(2,"Bad")]
    [InlineData(5,"Ok")]
    [InlineData(9,"Great")]
    public void RatingScore_Values_EqualCorrectRating(int number, string rating)
    {
        Assert.Equal(rating, NumberHelper.RatingScore(number));
    }

    [Theory]
    [MemberData(nameof(TestNumbers))]
    public void ConvertToNumber_MemberData_ReturnsCorrectData(int x, int y, int z)
    {
        Assert.Equal("Unknown", NumberHelper.RatingScore(y+z));
    }

    [Fact]
    public void Home_ValidLargeNumberResult_ShouldBeEqual()
    {
        //Arrange
        var gussedNumber = 120;
        string expectedResult = "Wrong! Try a smaller number";

        //Act
        string result = $"{expectedResult} {gussedNumber}";

        //Assert
        Assert.Equal(result, $"{expectedResult} {gussedNumber}");
        Assert.True(gussedNumber > 100);
    }
}
