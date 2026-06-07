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

using LeetCode.Algorithms.SummaryRanges;

namespace LeetCode.Tests.Algorithms.SummaryRanges;

public abstract class SummaryRangesTestsBase<T> where T : ISummaryRanges, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 2, 4, 5, 7 }, new[] { "0->2", "4->5", "7" })]
    [DataRow(new[] { 0, 2, 3, 4, 6, 8, 9 }, new[] { "0", "2->4", "6", "8->9" })]
    [DataRow(new int[] { }, new string[] { })]
    [DataRow(new[] { 0 }, new[] { "0" })]
    [DataRow(new[] { -1 }, new[] { "-1" })]
    [DataRow(new[] { 1, 2, 3 }, new[] { "1->3" })]
    [DataRow(new[] { 1, 3, 5 }, new[] { "1", "3", "5" })]
    [DataRow(new[] { -3, -2, -1, 0, 1 }, new[] { "-3->1" })]
    [DataRow(new[] { -5, -4, -2, -1, 0 }, new[] { "-5->-4", "-2->0" })]
    [DataRow(new[] { 0, 1 }, new[] { "0->1" })]
    [DataRow(new[] { 0, 2 }, new[] { "0", "2" })]
    [DataRow(new[] { -2147483648 }, new[] { "-2147483648" })]
    [DataRow(new[] { 2147483647 }, new[] { "2147483647" })]
    [DataRow(new[] { 1, 2, 3, 5, 6, 7, 9 }, new[] { "1->3", "5->7", "9" })]
    [DataRow(new[] { -10, -9, -8, -5, -3, -2, -1 }, new[] { "-10->-8", "-5", "-3->-1" })]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, new[] { "0->5" })]
    [DataRow(new[] { 10, 11, 12, 14 }, new[] { "10->12", "14" })]
    [DataRow(new[] { 5 }, new[] { "5" })]
    public void SummaryRanges_WithSortedUniqueArray_ReturnsListOfMinimalConsecutiveRanges(int[] nums, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SummaryRanges(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}