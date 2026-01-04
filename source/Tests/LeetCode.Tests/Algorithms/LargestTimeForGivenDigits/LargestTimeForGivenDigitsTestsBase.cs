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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestTimeForGivenDigits;

public abstract class LargestTimeForGivenDigitsTestsBase<T> where T : ILargestTimeForGivenDigits, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4]", "23:41")]
    [DataRow("[5,5,5,5]", "")]
    public void LargestTimeFromDigits_WithFourDigitArray_ReturnsLatestValid24HourTimeOrEmptyString(string arrJson,
        string expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.LargestTimeFromDigits(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}