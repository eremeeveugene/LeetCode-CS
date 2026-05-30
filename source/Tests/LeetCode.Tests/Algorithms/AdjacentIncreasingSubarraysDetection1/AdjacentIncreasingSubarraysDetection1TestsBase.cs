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

using LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection1;

namespace LeetCode.Tests.Algorithms.AdjacentIncreasingSubarraysDetection1;

public abstract class AdjacentIncreasingSubarraysDetection1TestsBase<T> where T : IAdjacentIncreasingSubarraysDetection1, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 }, 5, false)]
    public void HasIncreasingSubarrays_WithGivenNumsAndK_ReturnsTrueIfTwoAdjacentStrictlyIncreasingSubarraysExist(int[] nums, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasIncreasingSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}