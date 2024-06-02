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

using LeetCode.Algorithms.Permutations;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Permutations;

public abstract class PermutationsTestsBase<T> where T : IPermutations, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, "[[0]]")]
    [DataRow(new[] { 0, 1 }, "[[0,1],[1,0]]")]
    [DataRow(new[] { 0, 1, 2 }, "[[1,2,0],[1,0,2],[2,1,0],[2,0,1],[0,1,2],[0,2,1]]")]
    public void Permute_WithDifferentArraySizes_ReturnsAllPermutations(int[] nums, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int>.JsonArrayToJaggedList(expectedResultJsonArray);

        // Act
        var actualResult = solution.Permute(nums);

        // Assert
        JaggedListAssert.AreEquivalent(expectedResult, actualResult);
    }
}