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

using LeetCode.Algorithms.LargestNumber;

namespace LeetCode.Tests.Algorithms.LargestNumber;

public abstract class LargestNumberTestsBase<T> where T : ILargestNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 0, 0 }, "0")]
    [DataRow(new[] { 10, 2 }, "210")]
    [DataRow(new[] { 3, 30, 34, 5, 9 }, "9534330")]
    [DataRow(new[] { 34323, 3432 }, "343234323")]
    [DataRow(new[] { 121, 12 }, "12121")]
    [DataRow(new[] { 121, 12, 120 }, "12121120")]
    [DataRow(new[] { 1, 11, 111, 1112 }, "1112111111")]
    [DataRow(new[] { 999999, 999999998, 999999997 }, "999999999999998999999997")]
    public void LargestNumber_WithArrayOfIntegers_ReturnsMaxConcatenatedNumber(int[] nums, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}