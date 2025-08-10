// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReorderedPowerOfTwo;

namespace LeetCode.Tests.Algorithms.ReorderedPowerOfTwo;

public abstract class ReorderedPowerOfTwoTestsBase<T> where T : IReorderedPowerOfTwo, new()
{
    [TestMethod]
    [DataRow(1, true)]
    [DataRow(2, true)]
    [DataRow(4, true)]
    [DataRow(8, true)]
    [DataRow(10, false)]
    [DataRow(16, true)]
    [DataRow(61, true)]
    [DataRow(100, false)]
    [DataRow(8001, false)]
    [DataRow(131072, true)]
    [DataRow(27131072, false)]
    [DataRow(368712509, true)]
    [DataRow(842717231, true)]
    public void ReorderedPowerOf2_WithGivenInteger_ReturnsTrueIfPermutationIsPowerOfTwo(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReorderedPowerOf2(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}