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

using LeetCode.Algorithms.LargestPositiveIntegerThatExistsWithItsNegative;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestPositiveIntegerThatExistsWithItsNegative;

public abstract class LargestPositiveIntegerThatExistsWithItsNegativeTestsBase<T>
    where T : ILargestPositiveIntegerThatExistsWithItsNegative, new()
{
    [TestMethod]
    [DataRow("[1]", -1)]
    [DataRow("[-1, 2, -3, 3]", 3)]
    [DataRow("[-1, 10, 6, 7, -7, 1]", 7)]
    [DataRow("[-10, 8, 6, 7, -2, -3]", -1)]
    public void FindMaxK_WithIntegerArray_ReturnsLargestKWhereBothKAndNegativeKExist(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindMaxK(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}