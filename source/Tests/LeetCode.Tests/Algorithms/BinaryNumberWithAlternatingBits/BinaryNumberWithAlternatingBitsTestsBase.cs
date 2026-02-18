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

using LeetCode.Algorithms.BinaryNumberWithAlternatingBits;

namespace LeetCode.Tests.Algorithms.BinaryNumberWithAlternatingBits;

public abstract class BinaryNumberWithAlternatingBitsTestsBase<T> where T : IBinaryNumberWithAlternatingBits, new()
{
    [TestMethod]
    [DataRow(5, true)]
    [DataRow(7, false)]
    [DataRow(11, false)]
    public void HasAlternatingBits_WithGivenPositiveInteger_ReturnsTrueIfAdjacentBitsAlternate(int n,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasAlternatingBits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}