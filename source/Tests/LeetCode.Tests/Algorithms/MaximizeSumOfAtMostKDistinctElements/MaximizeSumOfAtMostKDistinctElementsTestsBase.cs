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

using LeetCode.Algorithms.MaximizeSumOfAtMostKDistinctElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximizeSumOfAtMostKDistinctElements;

public abstract class MaximizeSumOfAtMostKDistinctElementsTestsBase<T>
    where T : IMaximizeSumOfAtMostKDistinctElements, new()
{
    [TestMethod]
    [DataRow("[84,93,100,77,90]", 3, "[100,93,90]")]
    [DataRow("[84,93,100,77,93]", 3, "[100,93,84]")]
    [DataRow("[1,1,1,2,2,2]", 6, "[2,1]")]
    public void MaxKDistinct_WithNumsArrayAndLimitK_ReturnsKOrFewerDistinctNumbersWithMaxSumInDescendingOrder(
        string numsJson, int k, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxKDistinct(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}