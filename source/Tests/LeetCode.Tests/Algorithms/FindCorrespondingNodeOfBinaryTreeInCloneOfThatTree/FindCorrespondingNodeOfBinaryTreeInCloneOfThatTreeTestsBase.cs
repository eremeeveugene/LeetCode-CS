// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;

public abstract class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeTestsBase<T>
    where T : IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void GetTargetCopy_GivenOriginalAndClonedTree_ReturnsCorrespondingNode(int?[] treeArray, int targetValue, int expectedResultValue)
    {
        // Arrange
        var original = TreeNode.ToTreeNodeOrThrow(treeArray);
        var cloned = TreeNode.ToTreeNodeOrThrow(treeArray);

        TreeNode? target = null;

        var targetStack = new Stack<TreeNode>();

        targetStack.Push(original);

        while (targetStack.Count > 0)
        {
            var node = targetStack.Pop();

            if (node.val == targetValue)
            {
                target = node;

                break;
            }

            if (node.left != null)
            {
                targetStack.Push(node.left);
            }

            if (node.right != null)
            {
                targetStack.Push(node.right);
            }
        }

        TreeNode? expectedResult = null;

        var expectedResultStack = new Stack<TreeNode>();

        expectedResultStack.Push(cloned);

        while (expectedResultStack.Count > 0)
        {
            var node = expectedResultStack.Pop();

            if (node.val == expectedResultValue)
            {
                expectedResult = node;

                break;
            }

            if (node.left != null)
            {
                expectedResultStack.Push(node.left);
            }

            if (node.right != null)
            {
                expectedResultStack.Push(node.right);
            }
        }

        var solution = new T();

        // Act
        var actualResult = solution.GetTargetCopy(original, cloned, target);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 7 }, 7, 7];

        yield return [new int?[] { 7, 4, 3, null, null, 6, 19 }, 3, 3];

        yield return [new int?[] { 8, null, 6, null, 5, null, 4, null, 3, null, 2, null, 1 }, 4, 4];

        yield return [new int?[] { 5, 3, 8 }, 5, 5];

        yield return [new int?[] { 1, 2, 3 }, 2, 2];

        yield return [new int?[] { 1, 2, 3 }, 3, 3];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 4, 4];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 7, 7];

        yield return [new int?[] { 10, 5, 20, 3, 7, 15, 25 }, 20, 20];

        yield return [new int?[] { 10, 5, 20, 3, 7, 15, 25 }, 5, 5];

        yield return [new int?[] { 10, 5, 20, 3, 7, 15, 25 }, 3, 3];

        yield return [new int?[] { 10, 5, 20, 3, 7, 15, 25 }, 25, 25];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, 4, 4];

        yield return [new int?[] { 4, 3, null, 2, null, 1 }, 1, 1];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, 3, 3];

        yield return [new int?[] { 100, 50, 150, 25, 75, 125, 175 }, 100, 100];

        yield return [new int?[] { 100, 50, 150, 25, 75, 125, 175 }, 125, 125];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 6, 6];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, 8];

        yield return [new int?[] { 2, 1, 3 }, 1, 1];

        yield return [new int?[] { 50, 25, 75 }, 75, 75];
    }
}