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

using LeetCode.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;

public abstract class MaximumDifferenceBetweenAdjacentElementsInCircularArrayTestsBase<T>
    where T : IMaximumDifferenceBetweenAdjacentElementsInCircularArray, new()
{
    [TestMethod]
    [DataRow("[1,2,4]", 3)]
    [DataRow("[-5,-10,-5]", 5)]
    public void MaxAdjacentDistance_WithInputArray_ReturnsLargestDifferenceBetweenAdjacentElements(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxAdjacentDistance(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}