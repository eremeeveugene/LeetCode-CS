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

using LeetCode.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

public abstract class AbsoluteDifferenceBetweenMaximumAndMinimumKElementsTestsBase<T>
    where T : IAbsoluteDifferenceBetweenMaximumAndMinimumKElements, new()
{
    [TestMethod]
    [DataRow("[5,2,2,4]", 2, 5)]
    [DataRow("[100]", 1, 0)]
    public void AbsDifference_WithKSmallestAndKLargestElements_ReturnsAbsoluteDifferenceOfTheirSums(string numsJson,
        int k, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.AbsDifference(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}