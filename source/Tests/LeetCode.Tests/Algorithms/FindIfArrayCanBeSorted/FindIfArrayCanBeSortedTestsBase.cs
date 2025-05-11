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

using LeetCode.Algorithms.FindIfArrayCanBeSorted;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindIfArrayCanBeSorted;

public abstract class FindIfArrayCanBeSortedTestsBase<T> where T : IFindIfArrayCanBeSorted, new()
{
    [TestMethod]
    [DataRow("[8,4,2,30,15]", true)]
    [DataRow("[1,2,3,4,5]", true)]
    [DataRow("[3,16,8,4,2]", false)]
    public void CanSortArray_WithUnsortedOrSortedArray_ReturnsIfArrayCanBeSorted(string numsJson,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CanSortArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}