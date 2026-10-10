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

using LeetCode.Algorithms.BuildArrayFromPermutation;

namespace LeetCode.Tests.Algorithms.BuildArrayFromPermutation;

public abstract class BuildArrayFromPermutationTestsBase<T> where T : IBuildArrayFromPermutation, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 2, 1, 5, 3, 4 }, new[] { 0, 1, 2, 4, 5, 3 })]
    [DataRow(new[] { 5, 0, 1, 2, 3, 4 }, new[] { 4, 5, 0, 1, 2, 3 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 0, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 1, 0 }, new[] { 0, 1 })]
    [DataRow(new[] { 0, 1, 2 }, new[] { 0, 1, 2 })]
    [DataRow(new[] { 2, 1, 0 }, new[] { 0, 1, 2 })]
    [DataRow(new[] { 1, 2, 0 }, new[] { 2, 0, 1 })]
    [DataRow(new[] { 2, 0, 1 }, new[] { 1, 2, 0 })]
    [DataRow(new[] { 1, 0, 3, 2 }, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 3, 2, 1, 0 }, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 0 }, new[] { 2, 3, 0, 1 })]
    [DataRow(new[] { 3, 0, 1, 2 }, new[] { 2, 3, 0, 1 })]
    [DataRow(new[] { 0, 2, 1, 3 }, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 4, 3, 2, 1, 0 }, new[] { 0, 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 0 }, new[] { 2, 3, 4, 0, 1 })]
    [DataRow(new[] { 4, 0, 1, 2, 3 }, new[] { 3, 4, 0, 1, 2 })]
    [DataRow(new[] { 2, 0, 1, 4, 3 }, new[] { 1, 2, 0, 3, 4 })]
    [DataRow(new[] { 0, 2, 1, 4, 3, 5 }, new[] { 0, 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 0, 2, 3 }, new[] { 0, 1, 2, 3 })]
    public void BuildArray_WithPermutationInput_ReturnsTransformedArrayUsingSelfIndexing(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BuildArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}