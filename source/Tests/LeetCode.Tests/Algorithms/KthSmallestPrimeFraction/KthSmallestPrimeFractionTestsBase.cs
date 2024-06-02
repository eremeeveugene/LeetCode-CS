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

using LeetCode.Algorithms.KthSmallestPrimeFraction;

namespace LeetCode.Tests.Algorithms.KthSmallestPrimeFraction;

public abstract class KthSmallestPrimeFractionTestsBase<T> where T : IKthSmallestPrimeFraction, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 7 }, 1, new[] { 1, 7 })] // Basic case
    [DataRow(new[] { 1, 2, 3, 5 }, 3, new[] { 2, 5 })] // Case with k in the middle
    [DataRow(new[] { 1, 13, 17, 59 }, 6, new[] { 13, 17 })] // Larger k value
    [DataRow(new[] { 1, 7, 23, 29, 47 }, 8, new[] { 23, 47 })] // Different array with a larger k
    [DataRow(new[] { 1, 2, 11, 37, 83, 89 }, 11, new[] { 11, 37 })] // Different array and k
    [DataRow(new[] { 1, 2 }, 1, new[] { 1, 2 })] // Smallest possible array length
    [DataRow(new[] { 1, 2, 3, 5 }, 1, new[] { 1, 5 })] // Edge case with k = 1
    [DataRow(new[] { 1, 2, 3, 5 }, 6, new[] { 2, 3 })] // Edge case with k equal to the total number of fractions
    [DataRow(new[] { 1, 3, 5, 7, 11, 13 }, 10, new[] { 5, 11 })] // Larger array with k in the middle
    [DataRow(new[] { 1, 2, 3, 5, 7, 11 }, 15, new[] { 5, 7 })] // Larger k value
    public void KthSmallestPrimeFraction_GivenArrayAndK_ReturnsExpectedResult(int[] arr, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.KthSmallestPrimeFraction(arr, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}