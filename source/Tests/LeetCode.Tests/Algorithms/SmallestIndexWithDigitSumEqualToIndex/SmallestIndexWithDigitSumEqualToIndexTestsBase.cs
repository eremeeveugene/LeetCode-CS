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

using LeetCode.Algorithms.SmallestIndexWithDigitSumEqualToIndex;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SmallestIndexWithDigitSumEqualToIndex;

public abstract class SmallestIndexWithDigitSumEqualToIndexTestsBase<T>
    where T : ISmallestIndexWithDigitSumEqualToIndex, new()
{
    [TestMethod]
    [DataRow("[1,3,2]", 2)]
    [DataRow("[1,10,11]", 1)]
    [DataRow("[1,2,3]", -1)]
    public void SmallestIndex_WithGivenArray_ReturnsCorrectIndexOrMinusOne(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.SmallestIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}