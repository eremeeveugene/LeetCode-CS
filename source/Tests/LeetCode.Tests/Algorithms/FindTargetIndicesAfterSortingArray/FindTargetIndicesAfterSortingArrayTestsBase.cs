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

using LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;

namespace LeetCode.Tests.Algorithms.FindTargetIndicesAfterSortingArray;

public abstract class FindTargetIndicesAfterSortingArrayTestsBase<T>
    where T : IFindTargetIndicesAfterSortingArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 3, new[] { 3 })]
    [DataRow(new[] { 1, 2, 5, 2, 3 }, 5, new[] { 4 })]
    public void TargetIndices_WithArrayAndTarget_ReturnsListOfTargetIndices(int[] nums, int target,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TargetIndices(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}