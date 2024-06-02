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

using LeetCode.Algorithms.Subsets;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Subsets;

public abstract class SubsetsTestsBase<T> where T : ISubsets, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, "[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]")]
    [DataRow(new[] { 0 }, "[[],[0]]")]
    public void Subsets_GivenArrayOfNumbers_ReturnsAllPossibleSubsets(int[] nums, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int>.JsonArrayToJaggedList(expectedResultJsonArray);

        // Act
        var actualResult = solution.Subsets(nums);

        // Assert
        AssertExtensions.AssertJaggedArrayEqual(expectedResult, actualResult);
    }
}