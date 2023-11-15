using LeetCode.Algorithms.BinaryTreeInorderTraversalTask;
using LeetCode.Core.Models;
using Newtonsoft.Json;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class BinaryTreeInorderTraversalTests
{
    [TestMethod]
    [DataRow("[1,null,2,3]", "[1,3,2]")]
    public void t(string inputArrayJson, string expectedArrayJson)
    {
        // Arrange
        var expectedResult = JsonConvert.DeserializeObject<IList<int>>(expectedArrayJson) ??
                             throw new InvalidOperationException();
        var inputArray = JsonConvert.DeserializeObject<int?[]>(inputArrayJson) ??
                         throw new InvalidOperationException();
        var inputNode = TreeNode.BuildTree(inputArray);

        // Act
        var actualResult = BinaryTreeInorderTraversal.GetResult(inputNode);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }
}