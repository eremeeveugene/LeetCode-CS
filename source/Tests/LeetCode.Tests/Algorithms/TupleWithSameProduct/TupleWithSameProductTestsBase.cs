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

using LeetCode.Algorithms.TupleWithSameProduct;

namespace LeetCode.Tests.Algorithms.TupleWithSameProduct;

public abstract class TupleWithSameProductTestsBase<T> where T : ITupleWithSameProduct, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 4, 6 }, 8)]
    [DataRow(new[] { 1, 2, 4, 5, 10 }, 16)]
    [DataRow(new[] { 2, 3, 4, 6, 8, 12 }, 40)]
    public void TupleSameProduct_GivenArrayOfNumbers_ReturnsTupleCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TupleSameProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}