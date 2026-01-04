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

using LeetCode.Algorithms.SumOfAllOddLengthSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SumOfAllOddLengthSubarrays;

public abstract class SumOfAllOddLengthSubarraysTestsBase<T> where T : ISumOfAllOddLengthSubarrays, new()
{
    [TestMethod]
    [DataRow("[1,2]", 3)]
    [DataRow("[1,4,2,5,3]", 58)]
    [DataRow("[10,11,12]", 66)]
    public void SumOddLengthSubarrays_WithIntegersArray_ReturnsSumOfAllOddLengthSubarrays(string arrJson,
        int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.SumOddLengthSubarrays(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}