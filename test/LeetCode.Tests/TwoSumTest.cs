namespace LeetCode.Tests;

public class TwoSumTest
{
    [Fact]
    public void Test1()
    {
        var sut = new TwoSum();
        var result = sut.Solution(Array.Empty<int>(), 0);
    }
}