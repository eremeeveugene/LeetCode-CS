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

using LeetCode.Algorithms.MaximumValueOfAnOrderedTriplet1;

namespace LeetCode.Tests.Algorithms.MaximumValueOfAnOrderedTriplet1;

public abstract class MaximumValueOfAnOrderedTriplet1TestsBase<T> where T : IMaximumValueOfAnOrderedTriplet1, new()
{
    [TestMethod]
    [DataRow(new[] { 12, 6, 1, 2, 7 }, 77L)]
    [DataRow(new[] { 1, 10, 3, 4, 19 }, 133L)]
    [DataRow(new[] { 1, 2, 3 }, 0L)]
    [DataRow(new[] { 1000000, 1, 1000000 }, 999999000000L)]
    [DataRow(new[] { 1, 1, 1 }, 0L)]
    [DataRow(new[] { 3, 2, 1 }, 1L)]
    [DataRow(new[] { 2, 3, 1, 5, 4 }, 10L)]
    [DataRow(new[] { 1000000, 1000000, 1000000 }, 0L)]
    [DataRow(new[] { 5, 1, 5, 1, 5 }, 20L)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5 }, 20L)]
    [DataRow(new[] { 2, 1, 3, 1, 4 }, 8L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0L)]
    [DataRow(new[] { 100, 1, 1, 100 }, 9900L)]
    [DataRow(new[] { 7, 3, 9, 2, 8 }, 56L)]
    [DataRow(new[] { 1, 1000000, 1, 1000000 }, 999999000000L)]
    [DataRow(new[] { 999999, 500000, 1000000 }, 499999000000L)]
    [DataRow(new[] { 8, 6, 4, 2, 10 }, 60L)]
    [DataRow(new[] { 4, 3, 2, 1 }, 2L)]
    [DataRow(new[] { 20, 1, 15, 2, 10, 3 }, 285L)]
    [DataRow(new[] { 9, 1, 9, 1, 9, 1 }, 72L)]
    public void MaximumTripletValue_WithIntegerArray_ReturnsMaximumTripletValue(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumTripletValue(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}