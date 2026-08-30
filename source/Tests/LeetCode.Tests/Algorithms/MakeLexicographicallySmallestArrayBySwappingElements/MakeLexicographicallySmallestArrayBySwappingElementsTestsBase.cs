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

using LeetCode.Algorithms.MakeLexicographicallySmallestArrayBySwappingElements;

namespace LeetCode.Tests.Algorithms.MakeLexicographicallySmallestArrayBySwappingElements;

public abstract class MakeLexicographicallySmallestArrayBySwappingElementsTestsBase<T>
    where T : IMakeLexicographicallySmallestArrayBySwappingElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 3, 9, 8 }, 2, new[] { 1, 3, 5, 8, 9 })]
    [DataRow(new[] { 1, 7, 6, 18, 2, 1 }, 3, new[] { 1, 6, 7, 18, 1, 2 })]
    [DataRow(new[] { 1, 7, 28, 19, 10 }, 3, new[] { 1, 7, 28, 19, 10 })]
    [DataRow(new[] { 5 }, 1, new[] { 5 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 4, 3, 2, 1 }, 1, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 2, 1, 2, 1 }, 1, new[] { 1, 1, 2, 2 })]
    [DataRow(new[] { 1, 10, 1, 10 }, 1, new[] { 1, 10, 1, 10 })]
    [DataRow(new[] { 10, 1, 10, 1 }, 1, new[] { 10, 1, 10, 1 })]
    [DataRow(new[] { 4, 1, 3, 2, 10, 8, 9 }, 1, new[] { 1, 2, 3, 4, 8, 9, 10 })]
    [DataRow(new[] { 10, 4, 1, 9, 3, 2, 8 }, 1, new[] { 8, 1, 2, 9, 3, 4, 10 })]
    [DataRow(new[] { 9, 4, 7, 1, 3 }, 1_000_000_000, new[] { 1, 3, 4, 7, 9 })]
    [DataRow(new[] { 5, 1, 3 }, 2, new[] { 1, 3, 5 })]
    [DataRow(new[] { 5, 1, 4 }, 2, new[] { 4, 1, 5 })]
    [DataRow(new[] { 3, 7, 6, 4, 2 }, 2, new[] { 2, 3, 4, 6, 7 })]
    [DataRow(new[] { 20, 10, 30, 15, 25 }, 5, new[] { 10, 15, 20, 25, 30 })]
    [DataRow(new[] { 20, 10, 31, 15, 25 }, 5, new[] { 10, 15, 31, 20, 25 })]
    [DataRow(new[] { 2, 100, 3, 99, 4, 98 }, 1, new[] { 2, 98, 3, 99, 4, 100 })]
    [DataRow(new[] { 4, 100, 2, 99, 3, 98 }, 1, new[] { 2, 98, 3, 99, 4, 100 })]
    [DataRow(new[] { 8, 3, 5, 1, 7 }, 2, new[] { 1, 3, 5, 7, 8 })]
    [DataRow(new[] { 8, 3, 5, 1, 7 }, 1, new[] { 7, 3, 5, 1, 8 })]
    [DataRow(new[] { 1, 5, 3, 9, 8 }, 1, new[] { 1, 5, 3, 8, 9 })]
    [DataRow(new[] { 9, 8, 1, 3, 5 }, 1, new[] { 8, 9, 1, 3, 5 })]
    [DataRow(new[] { 6, 6, 6, 6 }, 1, new[] { 6, 6, 6, 6 })]
    [DataRow(new[] { 1_000_000_000, 1, 999_999_999, 2 }, 1, new[] { 999_999_999, 1, 1_000_000_000, 2 })]
    public void LexicographicallySmallestArray_WithGivenNumbersAndLimit_ReturnsSmallestObtainableArray(int[] nums, int limit, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LexicographicallySmallestArray(nums, limit);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}