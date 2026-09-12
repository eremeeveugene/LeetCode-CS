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

using LeetCode.Algorithms.CountCommasInRange2;

namespace LeetCode.Tests.Algorithms.CountCommasInRange2;

public abstract class CountCommasInRange2TestsBase<T> where T : ICountCommasInRange2, new()
{
    [TestMethod]
    [DataRow(1_002L, 3L)]
    [DataRow(998L, 0L)]
    [DataRow(1L, 0L)]
    [DataRow(9L, 0L)]
    [DataRow(10L, 0L)]
    [DataRow(99L, 0L)]
    [DataRow(100L, 0L)]
    [DataRow(999L, 0L)]
    [DataRow(1_000L, 1L)]
    [DataRow(1_001L, 2L)]
    [DataRow(9_999L, 9_000L)]
    [DataRow(10_000L, 9_001L)]
    [DataRow(100_000L, 99_001L)]
    [DataRow(999_999L, 999_000L)]
    [DataRow(1_000_000L, 999_002L)]
    [DataRow(1_000_001L, 999_004L)]
    [DataRow(1_234_567L, 1_468_136L)]
    [DataRow(999_999_999L, 1_998_999_000L)]
    [DataRow(1_000_000_000L, 1_998_999_003L)]
    [DataRow(1_000_000_001L, 1_998_999_006L)]
    [DataRow(2_147_483_647L, 5_441_449_944L)]
    [DataRow(999_999_999_999L, 2_998_998_999_000L)]
    [DataRow(1_000_000_000_000L, 2_998_998_999_004L)]
    [DataRow(1_000_000_000_001L, 2_998_998_999_008L)]
    [DataRow(1_234_567_890_123L, 3_937_270_559_496L)]
    [DataRow(999_999_999_999_999L, 3_998_998_998_999_000L)]
    [DataRow(1_000_000_000_000_000L, 3_998_998_998_999_005L)]
    public void CountCommas_WithGivenUpperBound_ReturnsTotalNumberOfCommas(long n, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountCommas(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}