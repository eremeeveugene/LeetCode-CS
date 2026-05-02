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

using LeetCode.Algorithms.ZeroArrayTransformation3;

namespace LeetCode.Tests.Algorithms.ZeroArrayTransformation3;

public abstract class ZeroArrayTransformation3TestsBase<T> where T : IZeroArrayTransformation3, new()
{
    [TestMethod]
    [DynamicData(nameof(TestData))]
    public void MaxRemoval_WithGivenNumsAndQueries_ReturnsMaximumRemovablePrefixLength(int[] nums, int[][] queries, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxRemoval(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 2, 0, 2 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 1, 1 } }, 1];

        yield return [new[] { 1, 1, 1, 1 }, new[] { new[] { 1, 3 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 2 } }, 2];

        yield return [new[] { 1, 2, 3, 4 }, new[] { new[] { 0, 3 } }, -1];
    }
}