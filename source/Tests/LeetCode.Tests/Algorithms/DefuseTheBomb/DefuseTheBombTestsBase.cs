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

using LeetCode.Algorithms.DefuseTheBomb;

namespace LeetCode.Tests.Algorithms.DefuseTheBomb;

public abstract class DefuseTheBombTestsBase<T> where T : IDefuseTheBomb, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 7, 1, 4 }, 3, new[] { 12, 10, 16, 13 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 0, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 2, 4, 9, 3 }, -2, new[] { 12, 5, 6, 13 })]
    [DataRow(new[] { 7 }, 0, new[] { 0 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2 }, -1, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2, 3 }, 2, new[] { 5, 4, 3 })]
    [DataRow(new[] { 1, 2, 3 }, -2, new[] { 5, 4, 3 })]
    [DataRow(new[] { 5, 5, 5, 5 }, 3, new[] { 15, 15, 15, 15 })]
    [DataRow(new[] { 5, 5, 5, 5 }, -3, new[] { 15, 15, 15, 15 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 2, 3, 4, 5, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -1, new[] { 5, 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 14, 13, 12, 11, 10 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -4, new[] { 14, 13, 12, 11, 10 })]
    [DataRow(new[] { 100, 100, 100 }, 2, new[] { 200, 200, 200 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, 3, new[] { 90, 120, 150, 120, 90, 60 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, -3, new[] { 150, 120, 90, 60, 90, 120 })]
    [DataRow(new[] { 9, 1, 8, 2, 7 }, 2, new[] { 9, 10, 9, 16, 10 })]
    [DataRow(new[] { 9, 1, 8, 2, 7 }, -2, new[] { 9, 16, 10, 9, 10 })]
    [DataRow(new[] { 4, 3, 2, 1 }, 1, new[] { 3, 2, 1, 4 })]
    public void Decrypt_WithCodeArrayAndShiftValue_ReturnsDecryptedArray(int[] code, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Decrypt(code, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}