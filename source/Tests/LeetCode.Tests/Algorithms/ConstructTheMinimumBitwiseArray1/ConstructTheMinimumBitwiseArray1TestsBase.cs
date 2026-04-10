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

using LeetCode.Algorithms.ConstructTheMinimumBitwiseArray1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ConstructTheMinimumBitwiseArray1;

public abstract class ConstructTheMinimumBitwiseArray1TestsBase<T> where T : IConstructTheMinimumBitwiseArray1, new()
{
    [TestMethod]
    [DataRow("[2,3,5,7]", "[-1,1,4,3]")]
    [DataRow("[11,13,31]", "[9,12,15]")]
    public void MinBitwiseArray_WithPrimeNumbersArray_ReturnsArrayWithMinimizedBitwiseValuesOrNegativeOne(
        string numsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinBitwiseArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}