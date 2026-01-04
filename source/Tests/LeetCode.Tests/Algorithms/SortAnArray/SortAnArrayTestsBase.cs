// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.SortAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortAnArray;

public abstract class SortAnArrayTestsBase<T> where T : ISortAnArray, new()
{
    [TestMethod]
    [DataRow("[5,2,3,1]", "[1,2,3,5]")]
    [DataRow("[5,1,1,2,0,0]", "[0,0,1,1,2,5]")]
    public void SortArray_WithUnsortedArray_ReturnsSortedArray(string numsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        solution.SortArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, nums);
    }
}