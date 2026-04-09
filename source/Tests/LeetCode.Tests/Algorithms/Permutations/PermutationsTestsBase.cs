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

using LeetCode.Algorithms.Permutations;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Permutations;

public abstract class PermutationsTestsBase<T> where T : IPermutations, new()
{
    [TestMethod]
    [DataRow("[0]", "[[0]]")]
    [DataRow("[0,1]", "[[0,1],[1,0]]")]
    [DataRow("[0,1,2]", "[[1,2,0],[1,0,2],[2,1,0],[2,0,1],[0,1,2],[0,2,1]]")]
    public void Permute_WithDifferentArraySizes_ReturnsAllPermutations(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper<IList<IList<int>>>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Permute(nums);

        // Assert
        NestedCollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}