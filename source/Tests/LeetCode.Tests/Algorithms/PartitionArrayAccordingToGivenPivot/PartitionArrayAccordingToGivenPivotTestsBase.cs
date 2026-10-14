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

using LeetCode.Algorithms.PartitionArrayAccordingToGivenPivot;

namespace LeetCode.Tests.Algorithms.PartitionArrayAccordingToGivenPivot;

public abstract class PartitionArrayAccordingToGivenPivotTestsBase<T> where T : IPartitionArrayAccordingToGivenPivot, new()
{
    [TestMethod]
    [DataRow(new[] { 9, 12, 5, 10, 14, 3, 10 }, 10, new[] { 9, 5, 3, 10, 10, 12, 14 })]
    [DataRow(new[] { -3, 4, 3, 2 }, 2, new[] { -3, 2, 4, 3 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 1, 2 })]
    [DataRow(new[] { 5 }, 5, new[] { 5 })]
    [DataRow(new[] { 5 }, 1, new[] { 5 })]
    [DataRow(new[] { 5 }, 9, new[] { 5 })]
    [DataRow(new[] { 3, 3, 3 }, 3, new[] { 3, 3, 3 })]
    [DataRow(new[] { 1, 2, 3 }, 2, new[] { 1, 2, 3 })]
    [DataRow(new[] { 3, 2, 1 }, 2, new[] { 1, 2, 3 })]
    [DataRow(new[] { -1000000, 1000000, 0 }, 0, new[] { -1000000, 0, 1000000 })]
    [DataRow(new[] { 1000000, -1000000 }, -1000000, new[] { -1000000, 1000000 })]
    [DataRow(new[] { 4, 5, 6, 1, 2, 3 }, 4, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 2, new[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 10, new[] { 9, 8, 7, 6, 5 })]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 4, new[] { 9, 8, 7, 6, 5 })]
    [DataRow(new[] { 0, 0, 0, 1 }, 0, new[] { 0, 0, 0, 1 })]
    [DataRow(new[] { -5, 5, -5, 5, 0 }, 0, new[] { -5, -5, 0, 5, 5 })]
    [DataRow(new[] { 7, 1, 7, 1, 7, 1 }, 7, new[] { 1, 1, 1, 7, 7, 7 })]
    [DataRow(new[] { 9, -2, 3, 6, -2, 4, 10, -10, -9, -3 }, 4, new[] { -2, 3, -2, -10, -9, -3, 4, 9, 6, 10 })]
    [DataRow(new[] { 5, 8, 0, -9, 0, -1, -8, -1, -1, 7, 1 }, 0, new[] { -9, -1, -8, -1, -1, 0, 0, 5, 8, 7, 1 })]
    [DataRow(new[] { -8, 7, 9, 3, 8, -3, -9, -8 }, -2, new[] { -8, -3, -9, -8, 7, 9, 3, 8 })]
    public void PivotArray_WithUnsortedArrayAndPivot_ReturnsPartitionedArray(int[] nums, int pivot, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PivotArray(nums, pivot);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}