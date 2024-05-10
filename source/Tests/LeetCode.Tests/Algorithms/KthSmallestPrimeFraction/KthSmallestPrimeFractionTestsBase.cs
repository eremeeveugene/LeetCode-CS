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
    [DataRow(new[] { 1, 7 }, 1, new[] { 1, 7 })]
    [DataRow(new[] { 1, 2, 3, 5 }, 3, new[] { 2, 5 })]
    [DataRow(new[] { 1, 13, 17, 59 }, 6, new[] { 13, 17 })]
    [DataRow(new[] { 1, 7, 23, 29, 47 }, 8, new[] { 23, 47 })]
    [DataRow(new[] { 1, 2, 11, 37, 83, 89 }, 11, new[] { 11, 37 })]
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