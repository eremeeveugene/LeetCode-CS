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

using LeetCode.Algorithms.FindLuckyIntegerInAnArray;

namespace LeetCode.Tests.Algorithms.FindLuckyIntegerInAnArray;

public abstract class FindLuckyIntegerInAnArrayTestsBase<T> where T : IFindLuckyIntegerInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 3)]
    [DataRow(new[] { 2, 2, 2, 3, 3 }, -1)]
    public void FindLucky_WithIntegersArray_ReturnsLargestLuckyIntegerOrMinusOne(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLucky(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}