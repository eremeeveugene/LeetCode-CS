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

using LeetCode.Algorithms.CombinationSum2;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CombinationSum2;

public abstract class CombinationSum2TestsBase<T> where T : ICombinationSum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CombinationSum2_WithCandidatesAndTarget_ReturnsAllUniqueCombinationsSummingToTarget(
        int[] candidates,
        int target,
        IList<IList<int>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CombinationSum2(candidates, target);

        // Assert
        NestedCollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { 10, 1, 2, 7, 6, 1, 5 }, 8,
            new List<IList<int>> { new List<int> { 1, 1, 6 }, new List<int> { 1, 2, 5 }, new List<int> { 1, 7 }, new List<int> { 2, 6 } }
        ];

        yield return [new[] { 2, 5, 2, 1, 2 }, 5, new List<IList<int>> { new List<int> { 1, 2, 2 }, new List<int> { 5 } }];
    }
}