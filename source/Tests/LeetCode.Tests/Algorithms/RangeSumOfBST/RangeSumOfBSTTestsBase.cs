using LeetCode.Algorithms.RangeSumOfBST;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.RangeSumOfBST;

public abstract class RangeSumOfBSTTestsBase<T> where T : IRangeSumOfBST, new()
{
    [TestMethod]
    [DataRow("[10,5,15,3,7,null,18]", 7, 15, 32)]
    [DataRow("[10,5,15,3,7,13,18,1,null,6]", 6, 10, 23)]
    public void RangeSumBST_GivenTreeWithLowAndHighValues_ReturnsCorrectSum(string rootJsonArray, int low, int high,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?>.DeserializeToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.RangeSumBST(root, low, high);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}