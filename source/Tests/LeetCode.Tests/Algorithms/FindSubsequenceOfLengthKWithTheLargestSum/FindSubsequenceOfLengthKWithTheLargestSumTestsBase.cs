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

using LeetCode.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;

public abstract class FindSubsequenceOfLengthKWithTheLargestSumTestsBase<T>
    where T : IFindSubsequenceOfLengthKWithTheLargestSum, new()
{
    [TestMethod]
    [DataRow("[2,1,3,3]", 2, "[3,3]")]
    [DataRow("[-1,-2,3,4]", 3, "[-1,3,4]")]
    [DataRow("[3,4,3,3]", 2, "[3,4]")]
    public void MaxSubsequence_WithGivenArrayAndK_ReturnsSubsequenceWithLargestSum(string numsJson, int k,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxSubsequence(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}