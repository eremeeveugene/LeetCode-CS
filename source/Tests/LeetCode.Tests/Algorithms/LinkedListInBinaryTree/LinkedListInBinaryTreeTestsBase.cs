using LeetCode.Algorithms.LinkedListInBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListInBinaryTree;

public abstract class LinkedListInBinaryTreeTestsBase<T> where T : ILinkedListInBinaryTree, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, "[1]", true)]
    [DataRow(new[] { 4, 2, 8 }, "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [DataRow(new[] { 1, 4, 2, 6 }, "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [DataRow(new[] { 1, 4, 2, 6, 8 }, "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", false)]
    [DataRow(new[] { 1, 10 }, "[1,null,1,10,1,9]", true)]
    [DataRow(new[] { 2, 2, 1 }, "[2,null,2,null,2,null,1]", true)]
    public void IsSubPath_WithLinkedListAndBinaryTree_ReturnsIfLinkedListIsSubPath(int[] headArray,
        string rootJsonArray, bool expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray) ?? throw new InvalidOperationException(
            $"Failed to convert headArray to ListNode. Input array: [{string.Join(",", headArray)}]");

        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray) ?? throw new InvalidOperationException(
            $"Failed to build binary tree from rootJsonArray. Input JSON array: {rootJsonArray}");

        var solution = new T();

        // Act
        var actualResult = solution.IsSubPath(head, root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}