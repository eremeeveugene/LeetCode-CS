using System.Collections;
using LeetCode.Algorithms.BinaryTreeInorderTraversalTask;
using LeetCode.Core.Models;
using Newtonsoft.Json;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class BinaryTreeInorderTraversalTests
{
    private const string EmptyArray = "[]";

    [TestMethod]
    [DataRow("[1,null,2,3]", "[1,3,2]")]
    [DataRow("[1]", "[1]")]
    [DataRow(EmptyArray, EmptyArray)]
    public void BinaryTreeInorderTraversal_WithValidInput_ReturnsExpectedResult(string inputArrayJson,
        string expectedArrayJson)
    {
        // Arrange
        var expectedResult = Convert(expectedArrayJson);
        var inputArray = Convert(inputArrayJson);
        var inputNode = TreeNode.BuildTree(inputArray);

        // Act
        var actualResult = BinaryTreeInorderTraversal.GetResult(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }

    private IList<int?> Convert(string inputArrayJson)
    {
        if (inputArrayJson == EmptyArray)
            return new List<int?>
            {
                0
            };

        return JsonConvert.DeserializeObject<IList<int?>>(inputArrayJson) ?? throw new InvalidOperationException();
    }
}