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

using LeetCode.Algorithms.LargestNumberAtLeastTwiceOfOthers;

namespace LeetCode.Tests.Algorithms.LargestNumberAtLeastTwiceOfOthers;

public abstract class LargestNumberAtLeastTwiceOfOthersTestsBase<T> where T : ILargestNumberAtLeastTwiceOfOthers, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 6, 1, 0 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, -1)]
    public void DominantIndex_WithIntegerArrayContainingUniqueLargest_ReturnsIndexOfLargestElementOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DominantIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}