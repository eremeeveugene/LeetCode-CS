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

using LeetCode.Algorithms.BinarySearch;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BinarySearch;

public abstract class BinarySearchTestsBase<T> where T : IBinarySearch, new()
{
    [TestMethod]
    [DataRow("[0]", 0, 0)]
    [DataRow("[-1, 0, 3, 5, 9, 12]", 9, 4)]
    [DataRow("[-1, 0, 3, 5, 9, 12]", 2, -1)]
    public void Search_WithTargetInArray_ReturnsCorrectIndexOrMinusOne(string numsJsonArray, int target,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Search(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}