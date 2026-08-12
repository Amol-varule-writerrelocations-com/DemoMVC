using Xunit;

namespace DemoMVC.Tests;

public class UnitTest1
{
    [Fact]
    public void Addition_Should_Return_Correct_Result()
    {
        int result = 2 + 3;

        Assert.Equal(5, result);
    }
}