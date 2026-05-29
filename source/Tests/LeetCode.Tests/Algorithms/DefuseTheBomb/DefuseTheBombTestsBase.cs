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
    public void Decrypt_WithCodeArrayAndShiftValue_ReturnsDecryptedArray(int[] code, int k,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Decrypt(code, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}