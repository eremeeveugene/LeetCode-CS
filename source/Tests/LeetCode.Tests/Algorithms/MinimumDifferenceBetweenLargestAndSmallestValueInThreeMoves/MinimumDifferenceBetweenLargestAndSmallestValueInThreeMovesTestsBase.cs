﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;

public abstract class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMovesTestsBase<T>
    where T : IMinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves, new()
{
    [TestMethod]
    [DataRow("[5,3,2,4]", 0)]
    [DataRow("[1,5,0,10,14]", 1)]
    [DataRow("[3,100,20]", 0)]
    [DataRow("[6,6,0,1,1,4,6]", 2)]
    public void MinDifference_WithGivenNumsArray_ReturnsExpectedResult(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}