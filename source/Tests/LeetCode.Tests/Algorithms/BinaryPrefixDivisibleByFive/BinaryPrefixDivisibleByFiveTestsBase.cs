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

using LeetCode.Algorithms.BinaryPrefixDivisibleByFive;

namespace LeetCode.Tests.Algorithms.BinaryPrefixDivisibleByFive;

public abstract class BinaryPrefixDivisibleByFiveTestsBase<T> where T : IBinaryPrefixDivisibleByFive, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 1 }, new[] { true, false, false })]
    [DataRow(new[] { 1, 1, 1 }, new[] { false, false, false })]
    [DataRow(new[] { 0 }, new[] { true })]
    [DataRow(new[] { 1 }, new[] { false })]
    [DataRow(new[] { 0, 0 }, new[] { true, true })]
    [DataRow(new[] { 1, 0 }, new[] { false, false })]
    [DataRow(new[] { 1, 0, 1 }, new[] { false, false, true })]
    [DataRow(new[] { 1, 1, 0 }, new[] { false, false, false })]
    [DataRow(new[] { 1, 1, 0, 0 }, new[] { false, false, false, false })]
    [DataRow(new[] { 1, 0, 1, 0 }, new[] { false, false, true, true })]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, new[] { false, false, true, true, false })]
    [DataRow(new[] { 0, 0, 0, 0 }, new[] { true, true, true, true })]
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { false, false, false, false })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { false, false, false, true })]
    [DataRow(new[] { 1, 1, 1, 1, 0 }, new[] { false, false, false, true, true })]
    [DataRow(new[] { 1, 0, 1, 1, 1 }, new[] { false, false, true, false, false })]
    [DataRow(new[] { 0, 1, 0 }, new[] { true, false, false })]
    [DataRow(new[] { 1, 0, 0, 0 }, new[] { false, false, false, false })]
    [DataRow(new[] { 1, 1, 0, 1 }, new[] { false, false, false, false })]
    [DataRow(new[] { 1, 0, 1, 0, 0 }, new[] { false, false, true, true, true })]
    [DataRow(new[] { 1, 1, 0, 0, 1, 1 }, new[] { false, false, false, false, true, false })]
    [DataRow(new[] { 0, 1, 0, 1 }, new[] { true, false, false, true })]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, new[] { false, false, false, true, false, false, false, true })]
    public void PrefixesDivBy5_WithNumsArray_ReturnsTrueIfPrefixDivisibleBy5(int[] nums, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PrefixesDivBy5(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}