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

using LeetCode.Algorithms.FindTriangularSumOfAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTriangularSumOfAnArray;

public abstract class FindTriangularSumOfAnArrayTestsBase<T> where T : IFindTriangularSumOfAnArray, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5]", 8)]
    [DataRow("[5]", 5)]
    public void TriangularSum_WithNums_ReturnsTriangularSumOfNums(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.TriangularSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}