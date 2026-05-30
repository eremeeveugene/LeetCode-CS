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

using LeetCode.Algorithms.TwoOutOfThree;

namespace LeetCode.Tests.Algorithms.TwoOutOfThree;

public abstract class TwoOutOfThreeTestsBase<T> where T : ITwoOutOfThree, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 3, 2 }, new[] { 2, 3 }, new[] { 3 }, new[] { 3, 2 })]
    [DataRow(new[] { 3, 1 }, new[] { 2, 3 }, new[] { 1, 2 }, new[] { 2, 3, 1 })]
    [DataRow(new[] { 1, 2, 2 }, new[] { 4, 3, 3 }, new[] { 5 }, new int[] { })]
    public void TwoOutOfThree_WithThreeIntegerArrays_ReturnsValuesPresentInAtLeastTwoArrays(int[] nums1, int[] nums2, int[] nums3, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoOutOfThree(nums1, nums2, nums3);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToList());
    }
}