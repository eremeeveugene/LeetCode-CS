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
    [DataRow(1, true)]
    [DataRow(2, true)]
    [DataRow(3, false)]
    [DataRow(4, false)]
    [DataRow(6, false)]
    [DataRow(8, false)]
    [DataRow(9, false)]
    [DataRow(10, true)]
    [DataRow(21, true)]
    [DataRow(42, true)]
    [DataRow(85, true)]
    [DataRow(170, true)]
    [DataRow(341, true)]
    [DataRow(1365, true)]
    [DataRow(12, false)]
    [DataRow(15, false)]
    [DataRow(100, false)]
    [DataRow(1431655765, true)]
    [DataRow(715827882, true)]
    [DataRow(2147483647, false)]
    public void HasAlternatingBits_WithGivenPositiveInteger_ReturnsTrueIfAdjacentBitsAlternate(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasAlternatingBits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}