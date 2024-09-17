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

using LeetCode.Algorithms.NeitherMinimumNorMaximum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NeitherMinimumNorMaximum;

public abstract class NeitherMinimumNorMaximumTestsBase<T> where T : INeitherMinimumNorMaximum, new()
{
    [TestMethod]
    [DataRow("[3,2,1,4]", 2)]
    [DataRow("[1,2]", -1)]
    [DataRow("[2,1,3]", 2)]
    [DataRow("[3,30,24]", 24)]
    public void FindNonMinOrMax_WithIntArray_ReturnsNonExtremeValue(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindNonMinOrMax(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}