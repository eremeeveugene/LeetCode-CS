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

using LeetCode.Algorithms.ReverseBits;

namespace LeetCode.Tests.Algorithms.ReverseBits;

public abstract class ReverseBitsTestsBase<T> where T : IReverseBits, new()
{
    [TestMethod]
    [DataRow(43261596, 964176192)]
    [DataRow(2147483644, 1073741822)]
    [DataRow(0, 0)]
    [DataRow(1, int.MinValue)]
    [DataRow(2, 1073741824)]
    [DataRow(3, -1073741824)]
    [DataRow(-1, -1)]
    [DataRow(int.MinValue, 1)]
    [DataRow(int.MaxValue, -2)]
    [DataRow(255, -16777216)]
    [DataRow(65535, -65536)]
    [DataRow(16777216, 128)]
    [DataRow(1431655765, -1431655766)]
    [DataRow(-1431655766, 1431655765)]
    [DataRow(1073741824, 2)]
    [DataRow(12345678, 1921400064)]
    [DataRow(-12345678, 1299825407)]
    [DataRow(4, 536870912)]
    [DataRow(8, 268435456)]
    [DataRow(1024, 2097152)]
    public void ReverseBits_WithBinaryRepresentation_ReversesBitsOf32BitUnsignedInteger(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseBits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}