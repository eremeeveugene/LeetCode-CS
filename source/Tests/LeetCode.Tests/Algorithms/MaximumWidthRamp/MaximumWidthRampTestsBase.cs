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

using LeetCode.Algorithms.MaximumWidthRamp;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumWidthRamp;

public abstract class MaximumWidthRampTestsBase<T> where T : IMaximumWidthRamp, new()
{
    [TestMethod]
    [DataRow("[6,0,8,2,1,5]", 4)]
    [DataRow("[9,8,1,0,1,9,4,0,4,1]", 7)]
    [DataRow("[29,28,28,26,25,24,9,23,21,9,18,17,14,12,3,11,10,8,8,10,22,6,5,20,5,2,1,1,1,0]", 17)]
    public void MaxWidthRamp_WithArrayOfIntegers_ReturnsMaxWidth(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxWidthRamp(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}