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

using LeetCode.Algorithms.SumOfRootToLeafBinaryNumbers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SumOfRootToLeafBinaryNumbers;

public abstract class SumOfRootToLeafBinaryNumbersTestsBase<T> where T : ISumOfRootToLeafBinaryNumbers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumRootToLeaf_WithBinaryTreeInput_ReturnsSumOfRootToLeafBinaryNumbers(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.SumRootToLeaf(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 0 }, 0];

        yield return [new int?[] { 1, 0, 1, 0, 1, 0, 1 }, 22];

        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 1, null, 0 }, 2];

        yield return [new int?[] { 1, 0 }, 2];

        yield return [new int?[] { 1, 1 }, 3];

        yield return [new int?[] { 1, null, 1 }, 3];

        yield return [new int?[] { 0, 0, 0 }, 0];

        yield return [new int?[] { 1, 1, 1 }, 6];

        yield return [new int?[] { 1, 0, 1 }, 5];

        yield return [new int?[] { 0, 0, 1 }, 1];

        yield return [new int?[] { 0, 1 }, 1];

        yield return [new int?[] { 0, null, 1 }, 1];

        yield return [new int?[] { 1, null, 1, null, 1 }, 7];

        yield return [new int?[] { 1, 1, null, 1 }, 7];

        yield return [new int?[] { 1, 1, 0, 1, 1, 0, 1 }, 23];

        yield return [new int?[] { 1, 1, 1, 0, 1, 0, 1 }, 26];

        yield return [new int?[] { 1, 0, 0, 1, 1, 1, 1 }, 20];

        yield return [new int?[] { 1, 0, 1, null, null, 0, 1 }, 15];

        yield return [new int?[] { 1, 0, 1, 0, 1 }, 12];
    }
}