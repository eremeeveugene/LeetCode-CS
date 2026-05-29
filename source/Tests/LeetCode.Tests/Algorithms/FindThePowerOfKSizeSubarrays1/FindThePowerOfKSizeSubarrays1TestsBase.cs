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

using LeetCode.Algorithms.FindThePowerOfKSizeSubarrays1;

namespace LeetCode.Tests.Algorithms.FindThePowerOfKSizeSubarrays1;

public abstract class FindThePowerOfKSizeSubarrays1TestsBase<T> where T : IFindThePowerOfKSizeSubarrays1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 3, 2, 5 }, 3, new[] { 3, 4, -1, -1, -1 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 4, new[] { -1, -1 })]
    [DataRow(new[] { 3, 2, 3, 2, 3, 2 }, 2, new[] { -1, 3, -1, 3, -1 })]
    public void ResultsArray_WithInputArrayAndK_ReturnsTransformedArray(int[] nums, int k,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResultsArray(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}