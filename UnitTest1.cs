using Ch04Ex02PrimeFactorsLib;
namespace Ch04Ex02PrimeFactorsTests;
public class UnitTest1
{
    [Fact]
    public void Test4()
    {
        Assert.Equal("2 x 2", PrimeFactorsHelper.PrimeFactors(4));
    }

    [Fact]
    public void Test7()
    {
        Assert.Equal("7", PrimeFactorsHelper.PrimeFactors(7));
    }

    [Fact]
    public void Test30()
    {
        Assert.Equal("2 x 3 x 5", PrimeFactorsHelper.PrimeFactors(30));
    }

    [Fact]
    public void Test40()
    {
        Assert.Equal("2 x 2 x 2 x 5", PrimeFactorsHelper.PrimeFactors(40));
    }

    [Fact]
    public void Test50()
    {
        Assert.Equal("2 x 5 x 5", PrimeFactorsHelper.PrimeFactors(50));
    }
}