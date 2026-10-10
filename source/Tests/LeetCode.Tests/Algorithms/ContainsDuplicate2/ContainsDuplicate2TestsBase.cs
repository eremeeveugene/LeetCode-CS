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

using LeetCode.Algorithms.ContainsDuplicate2;

namespace LeetCode.Tests.Algorithms.ContainsDuplicate2;

public abstract class ContainsDuplicate2TestsBase<T> where T : IContainsDuplicate2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1 }, 3, true)]
    [DataRow(new[] { 1, 0, 1, 1 }, 1, true)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    [DataRow(new[] { 1 }, 1, false)]
    [DataRow(new[] { 1, 1 }, 1, true)]
    [DataRow(new[] { 1, 2 }, 1, false)]
    [DataRow(new[] { 1, 2, 1 }, 1, false)]
    [DataRow(new[] { 1, 2, 1 }, 2, true)]
    [DataRow(new[] { 1, 2, 3, 4, 1 }, 3, false)]
    [DataRow(new[] { 1, 2, 3, 4, 1 }, 4, true)]
    [DataRow(new[] { 5, 5, 5 }, 1, true)]
    [DataRow(new[] { 0, 1, 2, 3, 0 }, 5, true)]
    [DataRow(new[] { -1, -1 }, 1, true)]
    [DataRow(new[] { -1, 2, -1 }, 1, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, false)]
    [DataRow(new[] { 9, 8, 7, 9, 8, 7 }, 2, false)]
    [DataRow(new[] { 9, 8, 7, 9, 8, 7 }, 3, true)]
    [DataRow(new[] { 99, 99 }, 100, true)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 3, true)]
    [DataRow(new[] { 4, 1, 2, 3, 1, 5 }, 3, true)]
    [DataRow(new[] { 4, 1, 2, 3, 1, 5 }, 2, false)]
    public void ContainsNearbyDuplicate_WithGivenRange_ChecksForDuplicatesWithinRange(int[] nums, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ContainsNearbyDuplicate(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}