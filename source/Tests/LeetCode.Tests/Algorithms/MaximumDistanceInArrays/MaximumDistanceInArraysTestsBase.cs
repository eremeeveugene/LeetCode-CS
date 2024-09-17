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

using LeetCode.Algorithms.MaximumDistanceInArrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumDistanceInArrays;

public abstract class MaximumDistanceInArraysTestsBase<T> where T : IMaximumDistanceInArrays, new()
{
    [TestMethod]
    [DataRow("[[1],[1]]", 0)]
    [DataRow("[[1,4],[0,5]]", 4)]
    [DataRow("[[1,2,3],[4,5],[1,2,3]]", 4)]
    public void MaxDistance_WithJsonArrayOfJaggedLists_ReturnsCorrectMaxDistance(string arraysJsonArray,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var arrays = JsonHelper<int>.DeserializeToJaggedList(arraysJsonArray);

        // Act
        var actualResult = solution.MaxDistance(arrays);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}