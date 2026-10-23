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

using LeetCode.Algorithms.RearrangeArrayByRemovingDistinctValues;

namespace LeetCode.Tests.Algorithms.RearrangeArrayByRemovingDistinctValues;

public abstract class RearrangeArrayByRemovingDistinctValuesTestsBase<T> where T : IRearrangeArrayByRemovingDistinctValues, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 3, 2, 1, 3 }, new[] { 1, 2, 3, 1, 3, 3 })]
    [DataRow(new[] { 7, 7, 4, 4, 4 }, new[] { 4, 7, 4, 7, 4 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 100 }, new[] { 100 })]
    [DataRow(new[] { 5, 5 }, new[] { 5, 5 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 })]
    [DataRow(new[] { 1, 100 }, new[] { 1, 100 })]
    [DataRow(new[] { 100, 1, 100 }, new[] { 1, 100, 100 })]
    [DataRow(new[] { 2, 2, 1 }, new[] { 1, 2, 2 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1, 2, 1 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 1, 2, 1, 2 })]
    [DataRow(new[] { 4, 3, 2, 1, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 1, 2, 3, 4 })]
    [DataRow(new[] { 5, 3, 5, 3, 5 }, new[] { 3, 5, 3, 5, 5 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, new[] { 1, 2, 3, 2, 3, 3 })]
    [DataRow(new[] { 3, 3, 3, 2, 2, 1 }, new[] { 1, 2, 3, 2, 3, 3 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, new[] { 10, 20, 30, 40, 50 })]
    [DataRow(new[] { 50, 40, 30, 20, 10 }, new[] { 10, 20, 30, 40, 50 })]
    [DataRow(new[] { 8, 1, 8, 1, 8, 1, 8 }, new[] { 1, 8, 1, 8, 1, 8, 8 })]
    [DataRow(new[] { 6, 6, 6, 2 }, new[] { 2, 6, 6, 6 })]
    [DataRow(new[] { 2, 6, 6, 6, 4, 4 }, new[] { 2, 4, 6, 4, 6, 6 })]
    [DataRow(new[] { 99, 1, 50, 1, 99, 1 }, new[] { 1, 50, 99, 1, 99, 1 })]
    [DataRow(new[] { 7, 3, 7, 5, 3, 7, 5, 3 }, new[] { 3, 5, 7, 3, 5, 7, 3, 7 })]
    public void RearrangeArray_WithNums_ReturnsRearrangedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RearrangeArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}