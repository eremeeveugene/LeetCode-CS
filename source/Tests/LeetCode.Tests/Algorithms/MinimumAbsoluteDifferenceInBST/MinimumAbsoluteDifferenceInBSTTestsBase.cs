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

using LeetCode.Algorithms.MinimumAbsoluteDifferenceInBST;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumAbsoluteDifferenceInBST;

public abstract class MinimumAbsoluteDifferenceInBSTTestsBase<T> where T : IMinimumAbsoluteDifferenceInBST, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void GetMinimumDifference_GivenBST_ReturnsMinimumAbsoluteDifference(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetMinimumDifference(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 4, 2, 6, 1, 3 }, 1];

        yield return [new int?[] { 1, 0, 48, null, null, 12, 49 }, 1];

        yield return [new int?[] { 90, 69, null, 49, 89, null, 52 }, 1];
    }
}
