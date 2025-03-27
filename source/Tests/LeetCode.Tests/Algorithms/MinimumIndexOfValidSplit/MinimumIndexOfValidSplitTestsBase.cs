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

using LeetCode.Algorithms.MinimumIndexOfValidSplit;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumIndexOfValidSplit;

public abstract class MinimumIndexOfValidSplitTestsBase<T> where T : IMinimumIndexOfValidSplit, new()
{
    [TestMethod]
    [DataRow("[1,2,2,2]", 2)]
    [DataRow("[2,1,3,1,1,1,7,1,2,1]", 4)]
    [DataRow("[3,3,3,3,7,2,2]", -1)]
    public void MinimumIndex_WithMajorityElementInArray_ReturnsMinimumIndexOfValidSplit(string numsJsonArray,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}