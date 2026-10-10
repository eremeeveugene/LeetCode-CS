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

using LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;

namespace LeetCode.Tests.Algorithms.FindAllKDistantIndicesInAnArray;

public abstract class FindAllKDistantIndicesInAnArrayTestsBase<T> where T : IFindAllKDistantIndicesInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 4, 9, 1, 3, 9, 5 }, 9, 1, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 2, 2, new[] { 0, 1, 2, 3, 4 })]
    [DataRow(new[] { 1 }, 1, 1, new[] { 0 })]
    [DataRow(new[] { 1 }, 2, 1, new int[0])]
    [DataRow(new[] { 1, 2, 3 }, 4, 1, new int[0])]
    [DataRow(new[] { 5, 1, 5 }, 5, 0, new[] { 0, 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, 0, new[] { 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 1, new[] { 0, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 1, new[] { 3, 4 })]
    [DataRow(new[] { 7, 7, 7 }, 7, 1, new[] { 0, 1, 2 })]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1 }, 2, 2, new[] { 0, 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 5, 1, 3, 1 }, 4, 4, new int[0])]
    [DataRow(new[] { 4, 2, 1, 4, 1, 4, 4, 5, 1 }, 6, 8, new int[0])]
    [DataRow(new[] { 2, 5, 1, 3, 1, 1 }, 1, 6, new[] { 0, 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 4, 2, 4, 1, 5, 2, 4, 4, 5 }, 2, 6, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [DataRow(new[] { 2, 4, 3, 1, 4 }, 5, 1, new int[0])]
    [DataRow(new[] { 3, 1, 3, 5 }, 4, 2, new int[0])]
    [DataRow(new[] { 3, 5, 4, 5, 4, 5 }, 1, 4, new int[0])]
    [DataRow(new[] { 4, 4, 2, 3, 5 }, 6, 3, new int[0])]
    [DataRow(new[] { 4, 5, 1 }, 2, 3, new int[0])]
    [DataRow(new[] { 3, 4, 1, 4, 1, 3, 5, 5 }, 5, 7, new[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
    public void FindKDistantIndices_WithKeyAndDistance_ReturnsAllIndicesWithinKDistanceOfKey(int[] nums, int key, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindKDistantIndices(nums, key, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}