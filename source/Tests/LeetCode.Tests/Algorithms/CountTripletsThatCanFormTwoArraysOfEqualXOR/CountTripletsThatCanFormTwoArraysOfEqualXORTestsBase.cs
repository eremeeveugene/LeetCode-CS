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

using LeetCode.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

namespace LeetCode.Tests.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

public abstract class CountTripletsThatCanFormTwoArraysOfEqualXORTestsBase<T>
    where T : ICountTripletsThatCanFormTwoArraysOfEqualXOR, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 1, 6, 7 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 10)]
    public void CountTriplets_GivenArray_ReturnsExpectedTripletCount(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountTriplets(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}