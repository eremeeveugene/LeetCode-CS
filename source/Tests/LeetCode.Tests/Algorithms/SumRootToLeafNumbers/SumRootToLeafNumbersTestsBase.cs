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

using LeetCode.Algorithms.SumRootToLeafNumbers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumRootToLeafNumbers;

public abstract class SumRootToLeafNumbersTestsBase<T> where T : ISumRootToLeafNumbers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumNumbers_WithDigitBinaryTree_ReturnsSumOfAllRootToLeafPathNumbers(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.SumNumbers(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 1, 2 }, 12];

        yield return [new int?[] { 1, 2, 3 }, 25];

        yield return [new int?[] { 4, 9, 0, 5, 1 }, 1026];

        yield return [new int?[] { 0 }, 0];

        yield return [new int?[] { 9 }, 9];

        yield return [new int?[] { 1, 0, 0 }, 20];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, 262];

        yield return [new int?[] { 1, null, 2 }, 12];

        yield return [new int?[] { 1, null, 2, null, null, null, 3 }, 123];

        yield return [new int?[] { 5, 3, 7 }, 110];

        yield return [new int?[] { 1, 0, 1 }, 21];

        yield return [new int?[] { 2, 3, null, 4 }, 234];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, 259];

        yield return [new int?[] { 6, 1, 2, 3, 4 }, 1289];

        yield return [new int?[] { 9, 5, null, 1, 2 }, 1903];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 522];
    }
}