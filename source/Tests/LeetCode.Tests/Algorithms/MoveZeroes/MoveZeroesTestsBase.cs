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

using LeetCode.Algorithms.MoveZeroes;

namespace LeetCode.Tests.Algorithms.MoveZeroes;

public abstract class MoveZeroesTestsBase<T> where T : IMoveZeroes, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 0, 0, 1 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 0 }, new[] { 1, 0 })]
    [DataRow(new[] { 0, 1 }, new[] { 1, 0 })]
    [DataRow(new[] { 0, 0, 0, 1 }, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 1, 0, 0, 0 }, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 1, 0, 2, 0, 3, 0 }, new[] { 1, 2, 3, 0, 0, 0 })]
    [DataRow(new[] { -1, 0, -2, 0, -3 }, new[] { -1, -2, -3, 0, 0 })]
    [DataRow(new[] { 0, -2147483648, 0, 2147483647 }, new[] { -2147483648, 2147483647, 0, 0 })]
    [DataRow(new[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 }, new[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 })]
    [DataRow(new[] { 0, 0, 1, 1, 0, 0, 2, 2 }, new[] { 1, 1, 2, 2, 0, 0, 0, 0 })]
    [DataRow(new[] { 5, 5, 5, 0 }, new[] { 5, 5, 5, 0 })]
    [DataRow(new[] { 0, 5, 5, 5 }, new[] { 5, 5, 5, 0 })]
    [DataRow(new[] { 7, 0, 7, 0, 7 }, new[] { 7, 7, 7, 0, 0 })]
    [DataRow(new[] { 0, 1, 0, 2, 0, 3, 0, 4 }, new[] { 1, 2, 3, 4, 0, 0, 0, 0 })]
    [DataRow(new[] { 9, 8, 7, 6, 0 }, new[] { 9, 8, 7, 6, 0 })]
    [DataRow(new[] { 0, 9, 8, 7, 6 }, new[] { 9, 8, 7, 6, 0 })]
    public void MoveZeroes_WhenCalled_MovesAllZeroesToEnd(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.MoveZeroes(nums);

        // Assert
        Assert.AreSequenceEqual(nums, expectedResult);
    }
}