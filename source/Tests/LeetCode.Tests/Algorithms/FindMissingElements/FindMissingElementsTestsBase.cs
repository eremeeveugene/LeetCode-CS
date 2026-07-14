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

using LeetCode.Algorithms.FindMissingElements;

namespace LeetCode.Tests.Algorithms.FindMissingElements;

public abstract class FindMissingElementsTestsBase<T> where T : IFindMissingElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 2, 5 }, new[] { 3 })]
    [DataRow(new[] { 7, 8, 6, 9 }, new int[] { })]
    [DataRow(new[] { 5, 1 }, new[] { 2, 3, 4 })]
    public void FindMissingElements_WithArrayContainingGaps_ReturnsMissingSequentialElements(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMissingElements(nums).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}