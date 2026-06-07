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

using LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;

namespace LeetCode.Tests.Algorithms.FindTargetIndicesAfterSortingArray;

public abstract class FindTargetIndicesAfterSortingArrayTestsBase<T> where T : IFindTargetIndicesAfterSortingArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 3, new[] { 3 })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 5, new[] { 4 })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 6, new int[] { })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 1, new[] { 0 })]
    [DataRow(new[] { 5, 5, 5 }, 5, new[] { 0, 1, 2 })]
    [DataRow(new[] { 1 }, 1, new[] { 0 })]
    [DataRow(new[] { 1 }, 2, new int[] { })]
    [DataRow(new[] { 3, 3, 3, 3 }, 3, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 0 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 2 })]
    [DataRow(new[] { 2, 2, 2, 2 }, 2, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 1, 3, 2, 4 }, 2, new[] { 1 })]
    [DataRow(new[] { 10, 10, 10 }, 10, new[] { 0, 1, 2 })]
    [DataRow(new[] { 1, 2, 3 }, 4, new int[] { })]
    [DataRow(new[] { 5, 1, 3 }, 3, new[] { 1 })]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 4, 3, 2, 1 }, 2, new[] { 1 })]
    [DataRow(new[] { 6, 5, 4 }, 5, new[] { 1 })]
    public void TargetIndices_WithArrayAndTarget_ReturnsListOfTargetIndices(int[] nums, int target, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TargetIndices(nums, target).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}