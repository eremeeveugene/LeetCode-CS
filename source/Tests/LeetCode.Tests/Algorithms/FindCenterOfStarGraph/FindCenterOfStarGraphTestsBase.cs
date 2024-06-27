using LeetCode.Algorithms.FindCenterOfStarGraph;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindCenterOfStarGraph;

public abstract class FindCenterOfStarGraphTestsBase<T> where T : IFindCenterOfStarGraph, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[4,2]]", 2)]
    [DataRow("[[1,2],[5,1],[1,3],[1,4]]", 1)]
    public void FindCenter_GivenEdgesJsonArray_ReturnsCenterNode(string edgesJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var edges = JsonHelper<int>.JsonArrayToJaggedArray(edgesJsonArray);

        // Act
        var actualResult = solution.FindCenter(edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}