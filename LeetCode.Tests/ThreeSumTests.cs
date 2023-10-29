using LeetCode.Core;
using LeetCode.ThreeSumTask;
using Newtonsoft.Json;

namespace LeetCode.Tests;

[TestClass]
public class ThreeSumTests
{
    [TestMethod]
    [DataRow(new[] { -1, 0, 1, 2, -1, -4 }, "[[-1, -1, 2], [-1, 0, 1]]")]
    [DataRow(new[] { 0, 1, 1 }, "[]")]
    [DataRow(new[] { 0, 0, 0 }, "[[0, 0, 0]]")]
    [DataRow(new[] { -3, -2, 1, 1, 2 }, "[[-3, 1, 2], [-2, 1, 1]]")]
    [DataRow(new[] { 3, 0, -2, -1, 1, 2 }, "[[-2, -1, 3],[-2, 0, 2],[-1, 0, 1]]")]
    public void ThreeSum_GetResult_ReturnsExpectedIndicesForGivenTarget(int[] nums, string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonConvert.DeserializeObject<int[][]>(expectedResultJson);

        // Act
        var actualResult = ThreeSum.GetResult(nums);

        // Assert
        var expectedSet = new HashSet<int[]>(expectedResult!.Select(e => e.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());
        var actualSet = new HashSet<int[]>(actualResult.Select(a => a.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());

        Assert.AreEqual(expectedResult!.Length, actualResult.Count);
        Assert.IsTrue(expectedSet.SetEquals(actualSet));
    }  
    
    [TestMethod]
    [DataRow(new[] { -1, 0, 1, 2, -1, -4 }, "[[-1, -1, 2], [-1, 0, 1]]")]
    [DataRow(new[] { 0, 1, 1 }, "[]")]
    [DataRow(new[] { 0, 0, 0 }, "[[0, 0, 0]]")]
    [DataRow(new[] { -3, -2, 1, 1, 2 }, "[[-3, 1, 2], [-2, 1, 1]]")]
    [DataRow(new[] { 3, 0, -2, -1, 1, 2 }, "[[-2, -1, 3], [-2, 0, 2], [-1, 0, 1]]")]
    public void ThreeSum_GetResultTwoPointers_ReturnsExpectedIndicesForGivenTarget(int[] nums, string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonConvert.DeserializeObject<int[][]>(expectedResultJson);

        // Act
        var actualResult = ThreeSum.GetResultTwoPointers(nums);

        // Assert
        var expectedSet = new HashSet<int[]>(expectedResult!.Select(e => e.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());
        var actualSet = new HashSet<int[]>(actualResult.Select(a => a.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());

        Assert.AreEqual(expectedResult!.Length, actualResult.Count);
        Assert.IsTrue(expectedSet.SetEquals(actualSet));
    }
}