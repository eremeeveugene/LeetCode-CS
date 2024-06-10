// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.HeightChecker;

namespace LeetCode.Tests.Algorithms.HeightChecker;

public abstract class HeightCheckerTestsBase<T> where T : IHeightChecker, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 1, 4, 2, 1, 3 }, 3)]
    public void HeightChecker_WithGivenArray_ReturnsCountOfIndicesWhereHeightsDoNotMatch(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HeightChecker(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}