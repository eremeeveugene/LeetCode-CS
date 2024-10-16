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

using LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SmallestRangeCoveringElementsFromKLists;

public abstract class SmallestRangeCoveringElementsFromKListsTestsBase<T>
    where T : ISmallestRangeCoveringElementsFromKLists, new()
{
    [TestMethod]
    [DataRow("[[10],[11]]", "[10,11]")]
    [DataRow("[[4,10,15,24,26],[0,9,12,20],[5,18,22,30]]", "[20,24]")]
    [DataRow("[[1,2,3],[1,2,3],[1,2,3]]", "[1,1]")]
    public void SmallestRange_WithNestedIntegerArrays_ReturnsCorrectRange(string numsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToJaggedList(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SmallestRange(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}