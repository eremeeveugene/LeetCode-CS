using LeetCode.Algorithms.FindEventualSafeStates;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindEventualSafeStates;

public abstract class FindEventualSafeStatesTestsBase<T> where T : IFindEventualSafeStates, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[5],[0],[5],[],[]]", "[2,4,5,6]")]
    [DataRow("[[1,2,3,4],[1,2],[3,4],[0,4],[]]", "[4]")]
    public void EventualSafeNodes_WithGraphContainingCyclesAndTerminalNodes_ReturnsOnlySafeNodesInAscendingOrder(
        string graphJson, string expectedResultJson)
    {
        // Arrange
        var graph = JsonHelper<int[][]>.Parse(graphJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.EventualSafeNodes(graph).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}