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

using LeetCode.Algorithms.MakeSumDivisibleByP;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MakeSumDivisibleByP;

public abstract class MakeSumDivisibleByPTestsBase<T> where T : IMakeSumDivisibleByP, new()
{
    [TestMethod]
    [DataRow("[3,1,4,2]", 6, 1)]
    [DataRow("[6,3,5,2]", 9, 2)]
    [DataRow("[1,2,3]", 3, 0)]
    public void MinSubarray_WithArrayAndDivisor_ReturnsMinSubarrayToRemove(string numsJsonArray, int p,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinSubarray(nums, p);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}