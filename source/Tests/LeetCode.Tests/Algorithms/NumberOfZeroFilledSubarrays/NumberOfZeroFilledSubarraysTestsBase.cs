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

using LeetCode.Algorithms.NumberOfZeroFilledSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfZeroFilledSubarrays;

public abstract class NumberOfZeroFilledSubarraysTestsBase<T> where T : INumberOfZeroFilledSubarrays, new()
{
    [TestMethod]
    [DataRow("[1,3,0,0,2,0,0,4]", 6)]
    [DataRow("[0,0,0,2,0,0]", 9)]
    [DataRow("[2,10,2019]", 0)]
    [DataRow("[0,0,0,0,0]", 15)]
    public void ZeroFilledSubarray_WithNumsArray_ReturnsCountOfZeroFilledSubarrays(string numsJson,
        long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.ZeroFilledSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}