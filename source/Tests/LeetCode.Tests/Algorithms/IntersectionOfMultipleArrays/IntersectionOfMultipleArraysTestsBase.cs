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

using LeetCode.Algorithms.IntersectionOfMultipleArrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.IntersectionOfMultipleArrays;

public abstract class IntersectionOfMultipleArraysTestsBase<T> where T : IIntersectionOfMultipleArrays, new()
{
    [TestMethod]
    [DataRow("[[3,1,2,4,5],[1,2,3,4],[3,4,5,6]]", "[3,4]")]
    [DataRow("[[1,2,3],[4,5,6]]", "[]")]
    public void Intersection_WithMultipleNumsArrays_ReturnsCommonElementsAcrossAllArrays(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[][]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Intersection(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}