// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountGoodTriplets;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountGoodTriplets;

public abstract class CountGoodTripletsTestsBase<T> where T : ICountGoodTriplets, new()
{
    [TestMethod]
    [DataRow("[3,0,1,1,9,7]", 7, 2, 3, 4)]
    [DataRow("[1,1,2,2,3]", 0, 0, 1, 0)]
    public void CountGoodTriplets_WithGivenArrayAndConstraints_ReturnsNumberOfValidTriplets(string arrJson, int a,
        int b, int c, int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountGoodTriplets(arr, a, b, c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}