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

using LeetCode.Algorithms.LargestTimeForGivenDigits;

namespace LeetCode.Tests.Algorithms.LargestTimeForGivenDigits;

public abstract class LargestTimeForGivenDigitsTestsBase<T> where T : ILargestTimeForGivenDigits, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, "23:41")]
    [DataRow(new[] { 5, 5, 5, 5 }, "")]
    public void LargestTimeFromDigits_WithFourDigitArray_ReturnsLatestValid24HourTimeOrEmptyString(int[] arr, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestTimeFromDigits(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}