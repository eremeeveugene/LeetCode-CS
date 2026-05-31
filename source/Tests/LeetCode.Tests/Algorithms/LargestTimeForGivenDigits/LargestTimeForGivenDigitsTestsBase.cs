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
    [DataRow(new[] { 0, 0, 0, 0 }, "00:00")]
    [DataRow(new[] { 2, 3, 5, 9 }, "23:59")]
    [DataRow(new[] { 0, 1, 2, 3 }, "23:10")]
    [DataRow(new[] { 9, 9, 9, 9 }, "")]
    [DataRow(new[] { 2, 4, 5, 9 }, "")]
    [DataRow(new[] { 0, 0, 0, 1 }, "10:00")]
    [DataRow(new[] { 2, 0, 6, 9 }, "09:26")]
    [DataRow(new[] { 1, 9, 8, 1 }, "19:18")]
    [DataRow(new[] { 0, 2, 3, 5 }, "23:50")]
    [DataRow(new[] { 1, 1, 1, 1 }, "11:11")]
    [DataRow(new[] { 0, 0, 1, 5 }, "15:00")]
    [DataRow(new[] { 2, 3, 4, 5 }, "23:54")]
    [DataRow(new[] { 7, 6, 5, 4 }, "")]
    [DataRow(new[] { 0, 0, 2, 3 }, "23:00")]
    [DataRow(new[] { 1, 2, 0, 0 }, "21:00")]
    [DataRow(new[] { 0, 1, 2, 9 }, "21:09")]
    [DataRow(new[] { 2, 2, 0, 0 }, "22:00")]
    [DataRow(new[] { 0, 0, 5, 9 }, "09:50")]
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