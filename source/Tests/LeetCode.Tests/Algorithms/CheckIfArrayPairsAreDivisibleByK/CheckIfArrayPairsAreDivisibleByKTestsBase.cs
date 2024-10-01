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

using LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfArrayPairsAreDivisibleByK;

public abstract class CheckIfArrayPairsAreDivisibleByKTestsBase<T> where T : ICheckIfArrayPairsAreDivisibleByK, new()
{
    [TestMethod]
    [DataRow("[0,0,0,0]", 100000, true)]
    [DataRow("[1,2,3,4,5,10,6,7,8,9]", 5, true)]
    [DataRow("[1,2,3,4,5,6]", 7, true)]
    [DataRow("[1,2,3,4,5,6]", 10, false)]
    [DataRow("[0,5,10,0]", 5, true)]
    [DataRow("[987654321,-987654321,765432100,-765432100]", 99999, true)]
    [DataRow("[-1,0,-2,2,-3,3]", 4, false)]
    [DataRow("[-2,-4,-9,-3,-1,-17]", 6, true)]
    public void CanArrange_WithArrayAndDivisor_ReturnsIfPairsCanBeArranged(string arrJsonArray, int k,
        bool expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CanArrange(arr, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}