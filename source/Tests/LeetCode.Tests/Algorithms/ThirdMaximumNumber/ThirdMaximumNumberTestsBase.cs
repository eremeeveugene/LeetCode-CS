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

using LeetCode.Algorithms.ThirdMaximumNumber;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ThirdMaximumNumber;

public abstract class ThirdMaximumNumberTestsBase<T> where T : IThirdMaximumNumber, new()
{
    [TestMethod]
    [DataRow("[3, 2, 1]", 1)]
    [DataRow("[1, 2]", 2)]
    [DataRow("[1, 1, 2]", 2)]
    [DataRow("[2, 2, 3, 1]", 1)]
    [DataRow("[2, 2, 3, 1]", 1)]
    [DataRow("[14]", 14)]
    [DataRow("[1, 2, -2147483648]", -2147483648)]
    [DataRow("[1, -2147483648, 2]", -2147483648)]
    public void ThirdMax_WithIntArray_ReturnsThirdMaximumOrMaximum(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ThirdMax(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}