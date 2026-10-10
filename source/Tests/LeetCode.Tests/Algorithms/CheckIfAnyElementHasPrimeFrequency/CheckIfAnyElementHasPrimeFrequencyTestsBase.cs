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

using LeetCode.Algorithms.CheckIfAnyElementHasPrimeFrequency;

namespace LeetCode.Tests.Algorithms.CheckIfAnyElementHasPrimeFrequency;

public abstract class CheckIfAnyElementHasPrimeFrequencyTestsBase<T> where T : ICheckIfAnyElementHasPrimeFrequency, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 4 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, false)]
    [DataRow(new[] { 2, 2, 2, 4, 4 }, true)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 1, 1, 1 }, true)]
    [DataRow(new[] { 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, true)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7 }, true)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, false)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, false)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, false)]
    [DataRow(new[] { 100, 100, 100 }, true)]
    [DataRow(new[] { 1, 2, 3 }, false)]
    [DataRow(new[] { 1, 1, 2, 2, 2, 2 }, true)]
    [DataRow(new[] { 1, 2, 2, 2, 2 }, false)]
    [DataRow(new[] { 3, 3, 3, 4, 4, 4, 4 }, true)]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, true)]
    [DataRow(new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 }, false)]
    public void CheckPrimeFrequency_WithIntegerArray_ReturnsTrueIfAnyElementHasPrimeFrequency(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckPrimeFrequency(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}