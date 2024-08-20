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

using LeetCode.Algorithms.ContiguousArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ContiguousArray;

public abstract class ContiguousArrayTestsBase<T> where T : IContiguousArray, new()
{
    [TestMethod]
    [DataRow("[0, 1]", 2)]
    [DataRow("[0, 1, 0]", 2)]
    [DataRow("[0, 1, 1, 0]", 4)]
    [DataRow("[0, 1, 1, 0, 1, 1, 1, 0]", 4)]
    [DataRow("[0, 0, 0, 0, 1, 1, 1, 1]", 8)]
    [DataRow("[0, 1, 1, 0, 1, 1, 1, 0, 0]", 6)]
    [DataRow("[0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1]", 16)]
    [DataRow("[0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0]", 16)]
    public void FindMaxLength_GivenArrayOfBinary_ReturnsLongestContiguousArrayLength(string numsJsonArray,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMaxLength(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}