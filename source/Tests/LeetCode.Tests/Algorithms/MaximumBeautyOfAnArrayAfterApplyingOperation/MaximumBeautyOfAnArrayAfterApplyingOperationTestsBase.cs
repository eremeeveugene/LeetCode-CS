// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

public abstract class MaximumBeautyOfAnArrayAfterApplyingOperationTestsBase<T>
    where T : IMaximumBeautyOfAnArrayAfterApplyingOperation, new()
{
    [TestMethod]
    [DataRow("[4,6,1,2]", 2, 3)]
    [DataRow("[1,1,1,1]", 10, 4)]
    public void MaximumBeauty_WithArrayAndK_ReturnsMaximizedBeauty(string numsJsonArray, int k, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumBeauty(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}