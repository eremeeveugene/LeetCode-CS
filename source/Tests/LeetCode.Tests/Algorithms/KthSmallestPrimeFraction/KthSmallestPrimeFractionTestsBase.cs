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

using LeetCode.Algorithms.KthSmallestPrimeFraction;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.KthSmallestPrimeFraction;

public abstract class KthSmallestPrimeFractionTestsBase<T> where T : IKthSmallestPrimeFraction, new()
{
    [TestMethod]
    [DataRow("[1, 7]", 1, "[1, 7]")]
    [DataRow("[1, 2, 3, 5]", 3, "[2, 5]")]
    [DataRow("[1, 13, 17, 59]", 6, "[13, 17]")]
    [DataRow("[1, 7, 23, 29, 47]", 8, "[23, 47]")]
    [DataRow("[1, 2, 11, 37, 83, 89]", 11, "[11, 37]")]
    [DataRow("[1, 2]", 1, "[1, 2]")]
    [DataRow("[1, 2, 3, 5]", 1, "[1, 5]")]
    [DataRow("[1, 2, 3, 5]", 6, "[2, 3]")]
    [DataRow("[1, 3, 5, 7, 11, 13]", 10, "[5, 11]")]
    [DataRow("[1, 2, 3, 5, 7, 11]", 15, "[5, 7]")]
    public void KthSmallestPrimeFraction_GivenArrayAndK_ReturnsExpectedResult(string arrJsonArray, int k,
        string expectedResultJsonArray)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.KthSmallestPrimeFraction(arr, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}