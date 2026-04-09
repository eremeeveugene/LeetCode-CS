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

using LeetCode.Algorithms.DivideArrayIntoArraysWithMaxDifference;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DivideArrayIntoArraysWithMaxDifference;

public abstract class DivideArrayIntoArraysWithMaxDifferenceTestsBase<T>
    where T : IDivideArrayIntoArraysWithMaxDifference, new()
{
    [TestMethod]
    [DataRow("[1,3,4,8,7,9,3,5,1]", 2, "[[1,1,3],[3,4,5],[7,8,9]]")]
    [DataRow("[2,4,2,2,5,2]", 2, "[]")]
    [DataRow("[4,2,9,8,2,12,7,12,10,5,8,5,5,7,9,2,5,11]", 14, "[[2,2,2],[4,5,5],[5,5,7],[7,8,8],[9,9,10],[11,12,12]]")]
    public void DivideArray_WithVariousInputs_ReturnsCorrectTripletGroupingOrEmptyArray(string numsJson, int k,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.DivideArray(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}