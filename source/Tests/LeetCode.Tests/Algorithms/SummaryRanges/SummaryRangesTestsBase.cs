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

using LeetCode.Algorithms.SummaryRanges;

namespace LeetCode.Tests.Algorithms.SummaryRanges;

public abstract class SummaryRangesTestsBase<T> where T : ISummaryRanges, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 2, 4, 5, 7 }, new[] { "0->2", "4->5", "7" })]
    [DataRow(new[] { 0, 2, 3, 4, 6, 8, 9 }, new[] { "0", "2->4", "6", "8->9" })]
    public void SummaryRanges_WithSequencesOfIntegers_ReturnsCorrectStringRanges(int[] nums, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SummaryRanges(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}