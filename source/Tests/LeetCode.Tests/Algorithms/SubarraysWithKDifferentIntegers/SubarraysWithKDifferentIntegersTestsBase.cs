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

using LeetCode.Algorithms.SubarraysWithKDifferentIntegers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SubarraysWithKDifferentIntegers;

public abstract class SubarraysWithKDifferentIntegersTestsBase<T> where T : ISubarraysWithKDifferentIntegers, new()
{
    [TestMethod]
    [DataRow("[1,2,1,2,3]", 2, 7)]
    [DataRow("[1,2,1,3,4]", 3, 3)]
    public void SubarraysWithKDistinct_GivenNumsAndK_ReturnsExpectedResult(string numsJsonArray, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SubarraysWithKDistinct(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}