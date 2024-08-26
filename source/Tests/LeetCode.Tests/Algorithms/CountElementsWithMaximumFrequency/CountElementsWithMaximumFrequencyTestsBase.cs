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

using LeetCode.Algorithms.CountElementsWithMaximumFrequency;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountElementsWithMaximumFrequency;

public abstract class CountElementsWithMaximumFrequencyTestsBase<T> where T : ICountElementsWithMaximumFrequency, new()
{
    [TestMethod]
    [DataRow("[1, 2, 2, 3, 1, 4]", 4)]
    [DataRow("[1, 2, 3, 4, 5]", 5)]
    public void MaxFrequencyElements_GivenArray_ReturnsMaximumElementFrequency(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxFrequencyElements(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}