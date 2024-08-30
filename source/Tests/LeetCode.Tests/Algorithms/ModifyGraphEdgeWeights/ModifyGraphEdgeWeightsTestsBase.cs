using LeetCode.Algorithms.ModifyGraphEdgeWeights;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ModifyGraphEdgeWeights;

public abstract class ModifyGraphEdgeWeightsTestsBase<T> where T : IModifyGraphEdgeWeights, new()
{
    [TestMethod]
    [DataRow(3, "[[0,1,-1],[0,2,5]]", 0, 2, 6, "[]")]
    [DataRow(4, "[[1,0,4],[1,2,3],[2,3,5],[0,3,-1]]", 0, 2, 6, "[[1,0,4],[1,2,3],[2,3,5],[0,3,1]]")]
    [DataRow(5, "[[4,1,-1],[2,0,-1],[0,3,-1],[4,3,-1]]", 0, 1, 5, "[[4,1,1],[2,0,3],[0,3,3],[4,3,1]]")]
    public void ModifiedGraphEdges_WithGivenParameters_ReturnsModifiedEdges(int n, string edgesJsonArray, int source,
        int destination, int target, string expectedResultJsonArray)
    {
        // Arrange
        var edges = JsonHelper<int>.JsonArrayToJaggedArray(edgesJsonArray);
        var expectedResult = JsonHelper<int>.JsonArrayToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ModifiedGraphEdges(n, edges, source, destination, target);

        // Assert
        JaggedArrayAssert.AreEquivalent(expectedResult, actualResult);
    }
}