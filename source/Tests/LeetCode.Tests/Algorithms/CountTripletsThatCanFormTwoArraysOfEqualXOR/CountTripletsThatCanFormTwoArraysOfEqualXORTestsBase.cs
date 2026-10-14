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

using LeetCode.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

namespace LeetCode.Tests.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

public abstract class CountTripletsThatCanFormTwoArraysOfEqualXORTestsBase<T> where T : ICountTripletsThatCanFormTwoArraysOfEqualXOR, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 1, 6, 7 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 10)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 5, 5 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 3, 3, 3 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 5)]
    [DataRow(new[] { 7, 7, 7, 7 }, 6)]
    [DataRow(new[] { 100000000, 100000000, 100000000 }, 2)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 9)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 4 }, 19)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 3)]
    [DataRow(new[] { 8, 4, 2, 1, 15 }, 4)]
    [DataRow(new[] { 6, 6, 1, 1 }, 5)]
    [DataRow(new[] { 2, 4, 6, 2, 4, 6 }, 13)]
    [DataRow(new[] { 10, 20, 30, 10, 20, 30, 10 }, 20)]
    [DataRow(new[] { 5, 4, 1, 3, 6, 2 }, 5)]
    [DataRow(new[] { 1, 8, 7, 2, 2, 6, 1 }, 5)]
    public void CountTriplets_WithArrayOfIntegers_ReturnsNumberOfEqualXorTriplets(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountTriplets(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}