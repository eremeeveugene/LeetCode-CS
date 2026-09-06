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

using LeetCode.Algorithms.SmallestStableIndex2;

namespace LeetCode.Tests.Algorithms.SmallestStableIndex2;

[TestClass]
public sealed class SmallestStableIndex2PrefixSumTests : SmallestStableIndex2TestsBase<SmallestStableIndex2PrefixSum>
{
    [TestMethod]
    public void FirstStableIndex_WithMaximumLengthArray_ReturnsLastIndex()
    {
        // Arrange
        var nums = new int[100_000];
        nums[0] = 1_000_000_000;
        nums[^1] = 1_000_000_000;
        var solution = new SmallestStableIndex2PrefixSum();

        // Act
        var actualResult = solution.FirstStableIndex(nums, 0);

        // Assert
        Assert.AreEqual(nums.Length - 1, actualResult);
    }
}
