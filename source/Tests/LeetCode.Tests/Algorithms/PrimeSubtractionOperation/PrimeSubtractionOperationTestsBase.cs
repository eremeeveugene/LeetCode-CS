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

using LeetCode.Algorithms.PrimeSubtractionOperation;

namespace LeetCode.Tests.Algorithms.PrimeSubtractionOperation;

public abstract class PrimeSubtractionOperationTestsBase<T> where T : IPrimeSubtractionOperation, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 9, 6, 10 }, true)]
    [DataRow(new[] { 6, 8, 11, 12 }, true)]
    [DataRow(new[] { 5, 8, 3 }, false)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2 }, true)]
    [DataRow(new[] { 1000 }, true)]
    [DataRow(new[] { 1, 1 }, false)]
    [DataRow(new[] { 2, 2 }, false)]
    [DataRow(new[] { 3, 2 }, true)]
    [DataRow(new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 999, 1000 }, true)]
    [DataRow(new[] { 1000, 1000 }, true)]
    [DataRow(new[] { 1000, 999 }, true)]
    [DataRow(new[] { 5, 5, 5 }, true)]
    [DataRow(new[] { 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 10, 9, 8, 7 }, true)]
    [DataRow(new[] { 3, 3, 3, 3 }, false)]
    [DataRow(new[] { 7, 1000, 2 }, false)]
    [DataRow(new[] { 20, 12, 13 }, true)]
    [DataRow(new[] { 100, 50, 25 }, true)]
    [DataRow(new[] { 1000, 1000, 1000 }, true)]
    [DataRow(new[] { 13, 11 }, true)]
    [DataRow(new[] { 4, 3 }, true)]
    [DataRow(new[] { 6, 5, 4 }, true)]
    [DataRow(new[] { 1, 100, 1 }, false)]
    [DataRow(new[] { 12, 10, 11 }, true)]
    public void PrimeSubOperation_WithInputArray_ReturnsTrueIfPrimeSubsequencePossible(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PrimeSubOperation(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}