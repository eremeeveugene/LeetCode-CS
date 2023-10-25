namespace LeetCode.Tests;

[TestClass]
public class TwoSumTests
{
    [TestMethod]
    [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [DataRow(new[] { 2, 5, 5, 11 }, 10, new[] { 1, 2 })]
    public void GetResult_ReturnsExpectedIndicesForGivenTarget(int[] nums, int target, int[] expectedResult)
    {
        var actualResult = TwoSum.GetResult(nums, target);

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [DataRow(new[] { 2, 5, 5, 11 }, 10, new[] { 1, 2 })]
    public void GetResultDictionary_ReturnsExpectedIndicesForGivenTarget(int[] nums, int target, int[] expectedResult)
    {
        var actualResult = TwoSum.GetResultDictionary(nums, target);

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}