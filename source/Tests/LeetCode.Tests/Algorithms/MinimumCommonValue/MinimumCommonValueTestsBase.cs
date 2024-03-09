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

using LeetCode.Algorithms.MinimumCommonValue;

namespace LeetCode.Tests.Algorithms.MinimumCommonValue;

public abstract class MinimumCommonValueTestsBase<T> where T : IMinimumCommonValue, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 2, 4 }, 2)]
    [DataRow(new[] { 1, 2, 3, 6 }, new[] { 2, 3, 4, 5 }, 2)]
    public void GetCommon_WithTwoArrays_ReturnsCountOfCommonElements(int[] nums1, int[] nums2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetCommon(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}