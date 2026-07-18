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
    [DataRow(new[] { 1 }, new[] { 1 }, new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1 }, new[] { 2 }, new[] { 3 }, new int[] { })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 1, 2 })]
    [DataRow(new[] { 5 }, new[] { 5 }, new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 1, 5, 9 }, new[] { 1, 5 })]
    [DataRow(new[] { 1 }, new[] { 1, 2 }, new[] { 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 10 }, new[] { 10, 20 }, new[] { 30 }, new[] { 10 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 2, 2 }, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new int[] { })]
    [DataRow(new[] { 7, 8 }, new[] { 7, 9 }, new[] { 8, 9 }, new[] { 7, 8, 9 })]
    [DataRow(new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 4, 4, 4 }, new[] { 4 }, new[] { 5 }, new[] { 4 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 2, 3 })]
    [DataRow(new[] { 6, 7 }, new[] { 6, 8 }, new[] { 7, 8 }, new[] { 6, 7, 8 })]
    [DataRow(new[] { 100 }, new[] { 100, 200 }, new[] { 300 }, new[] { 100 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 2, 3 })]
    public void TwoOutOfThree_WithThreeIntegerArrays_ReturnsValuesPresentInAtLeastTwoArrays(
        int[] nums1,
        int[] nums2,
        int[] nums3,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoOutOfThree(nums1, nums2, nums3);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}