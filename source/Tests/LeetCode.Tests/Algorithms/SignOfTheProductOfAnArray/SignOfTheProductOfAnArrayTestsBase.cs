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

using LeetCode.Algorithms.SignOfTheProductOfAnArray;

namespace LeetCode.Tests.Algorithms.SignOfTheProductOfAnArray;

public abstract class SignOfTheProductOfAnArrayTestsBase<T> where T : ISignOfTheProductOfAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { -1, -2, -3, -4, 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 5, 0, 2, -3 }, 0)]
    [DataRow(new[] { -1, 1, -1, 1, -1 }, -1)]
    public void ArraySign_GivenArrayOfIntegers_ReturnsProductSign(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArraySign(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}