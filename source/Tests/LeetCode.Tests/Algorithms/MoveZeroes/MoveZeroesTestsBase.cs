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

using LeetCode.Algorithms.MoveZeroes;

namespace LeetCode.Tests.Algorithms.MoveZeroes;

public abstract class MoveZeroesTestsBase<T> where T : IMoveZeroes, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 0, 0, 1 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    public void MoveZeroes_WhenCalled_MovesAllZeroesToEnd(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.MoveZeroes(nums);

        // Assert
        CollectionAssert.AreEqual(nums, expectedResult);
    }
}