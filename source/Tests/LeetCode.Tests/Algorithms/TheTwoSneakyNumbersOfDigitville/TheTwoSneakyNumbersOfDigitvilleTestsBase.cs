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

using LeetCode.Algorithms.TheTwoSneakyNumbersOfDigitville;

namespace LeetCode.Tests.Algorithms.TheTwoSneakyNumbersOfDigitville;

public abstract class TheTwoSneakyNumbersOfDigitvilleTestsBase<T> where T : ITheTwoSneakyNumbersOfDigitville, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 1, 0 }, new[] { 0, 1 })]
    [DataRow(new[] { 0, 3, 2, 1, 3, 2 }, new[] { 2, 3 })]
    [DataRow(new[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 }, new[] { 4, 5 })]
    public void GetSneakyNumbers_GivenArrayOfNumbers_ReturnsSneakyNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetSneakyNumbers(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}