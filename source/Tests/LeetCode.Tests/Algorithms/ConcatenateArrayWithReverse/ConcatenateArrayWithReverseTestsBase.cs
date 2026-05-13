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

using LeetCode.Algorithms.ConcatenateArrayWithReverse;

namespace LeetCode.Tests.Algorithms.ConcatenateArrayWithReverse;

public abstract class ConcatenateArrayWithReverseTestsBase<T> where T : IConcatenateArrayWithReverse, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 3, 2, 1 })]
    [DataRow(new[] { 5 }, new[] { 5, 5 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2, 2, 1 })]
    [DataRow(new[] { 100, 1 }, new[] { 100, 1, 1, 100 })]
    [DataRow(new[] { 1, 100 }, new[] { 1, 100, 100, 1 })]
    [DataRow(new[] { 7, 7, 7 }, new[] { 7, 7, 7, 7, 7, 7 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 1, 1, 2, 2, 2, 2, 1, 1 })]
    [DataRow(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [DataRow(new[] { 10, 20, 30 }, new[] { 10, 20, 30, 30, 20, 10 })]
    [DataRow(new[] { 100, 99, 98 }, new[] { 100, 99, 98, 98, 99, 100 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 4, 3, 2, 1 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 1, 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 100, 1, 100 }, new[] { 1, 100, 1, 100, 100, 1, 100, 1 })]
    [DataRow(new[] { 50, 25, 75, 100 }, new[] { 50, 25, 75, 100, 100, 75, 25, 50 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, new[] { 2, 4, 6, 8, 10, 10, 8, 6, 4, 2 })]
    [DataRow(new[] { 100, 100, 1, 1, 50 }, new[] { 100, 100, 1, 1, 50, 50, 1, 1, 100, 100 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1 })]
    public void ConcatWithReverse_WithGivenNums_ReturnsArrayWithOriginalElementsFollowedByReversedElements(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConcatWithReverse(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}