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

using LeetCode.Algorithms.FindKthBitInNthBinaryString;

namespace LeetCode.Tests.Algorithms.FindKthBitInNthBinaryString;

public abstract class FindKthBitInNthBinaryStringTestsBase<T> where T : IFindKthBitInNthBinaryString, new()
{
    [TestMethod]
    [DataRow(3, 1, '0')]
    [DataRow(4, 11, '1')]
    public void FindKthBit_WithNAndK_ReturnsCorrectBit(int n, int k, char expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindKthBit(n, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}