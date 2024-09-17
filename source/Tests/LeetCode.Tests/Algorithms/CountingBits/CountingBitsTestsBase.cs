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

using LeetCode.Algorithms.CountingBits;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountingBits;

public abstract class CountingBitsTestsBase<T> where T : ICountingBits, new()
{
    [TestMethod]
    [DataRow(2, "[0, 1, 1]")]
    [DataRow(5, "[0, 1, 1, 2, 1, 2]")]
    public void CountBits_WithNumber_ReturnsBitCountsUpToN(int n, string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountBits(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}