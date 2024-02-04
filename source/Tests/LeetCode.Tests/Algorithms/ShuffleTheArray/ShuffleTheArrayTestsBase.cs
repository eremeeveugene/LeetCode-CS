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

using LeetCode.Algorithms.ShuffleTheArray;

namespace LeetCode.Tests.Algorithms.ShuffleTheArray;

public abstract class ShuffleTheArrayTestsBase<T> where T : IShuffleTheArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 5, 1, 3, 4, 7 }, 3, new[] { 2, 3, 5, 4, 1, 7 })]
    [DataRow(new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
    [DataRow(new[] { 1, 1, 2, 2 }, 2, new[] { 1, 2, 1, 2 })]
    public void Shuffle_WithArrayAndSplitIndex_ReturnsShuffledArray(int[] nums, int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Shuffle(nums, n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}