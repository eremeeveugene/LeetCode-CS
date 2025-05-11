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

using LeetCode.Algorithms.FindThePowerOfKSizeSubarrays1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindThePowerOfKSizeSubarrays1;

public abstract class FindThePowerOfKSizeSubarrays1TestsBase<T> where T : IFindThePowerOfKSizeSubarrays1, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,3,2,5]", 3, "[3,4,-1,-1,-1]")]
    [DataRow("[2,2,2,2,2]", 4, "[-1,-1]")]
    [DataRow("[3,2,3,2,3,2]", 2, "[-1,3,-1,3,-1]")]
    public void ResultsArray_WithInputArrayAndK_ReturnsTransformedArray(string numsJson, int k,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ResultsArray(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}