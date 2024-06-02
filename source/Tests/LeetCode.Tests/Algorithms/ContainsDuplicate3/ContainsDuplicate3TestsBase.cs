// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ContainsDuplicate3;

namespace LeetCode.Tests.Algorithms.ContainsDuplicate3;

public abstract class ContainsDuplicate3TestsBase<T> where T : IContainsDuplicate3, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1 }, 3, 0, true)]
    [DataRow(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3, false)]
    [DataRow(new[] { 1, 0, 1, 1 }, 1, 2, true)]
    [DataRow(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 1, 0, false)]
    [DataRow(new int[] { }, 2, 1, false)]
    [DataRow(new[] { 1, 2, 3, 1 }, 0, 1, false)]
    [DataRow(new[] { 1, 2, 3, 1 }, 2, -1, false)]
    [DataRow(new[] { -1, -1 }, 1, 0, true)]
    public void ContainsNearbyAlmostDuplicate_WithIndexAndValueDifferences_ReturnsExpectedResult(int[] nums,
        int indexDiff, int valueDiff, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ContainsNearbyAlmostDuplicate(nums, indexDiff, valueDiff);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}