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
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { 10, 1, 2, 7, 6, 1, 5 },
            8,
            new List<IList<int>> { new List<int> { 1, 1, 6 }, new List<int> { 1, 2, 5 }, new List<int> { 1, 7 }, new List<int> { 2, 6 } }
        ];

        yield return [new[] { 2, 5, 2, 1, 2 }, 5, new List<IList<int>> { new List<int> { 1, 2, 2 }, new List<int> { 5 } }];

        yield return [new[] { 1 }, 1, new List<IList<int>> { new List<int> { 1 } }];

        yield return [new[] { 1 }, 2, new List<IList<int>>()];

        yield return [new[] { 2 }, 1, new List<IList<int>>()];

        yield return [new[] { 1, 1 }, 2, new List<IList<int>> { new List<int> { 1, 1 } }];

        yield return [new[] { 1, 1, 1 }, 2, new List<IList<int>> { new List<int> { 1, 1 } }];

        yield return [new[] { 1, 2 }, 3, new List<IList<int>> { new List<int> { 1, 2 } }];

        yield return [new[] { 1, 2, 3 }, 3, new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 3 } }];

        yield return [new[] { 2, 3, 6, 7 }, 7, new List<IList<int>> { new List<int> { 7 } }];

        yield return [new[] { 2, 2, 2 }, 4, new List<IList<int>> { new List<int> { 2, 2 } }];

        yield return [new[] { 1, 2, 3, 4, 5 }, 5, new List<IList<int>> { new List<int> { 1, 4 }, new List<int> { 2, 3 }, new List<int> { 5 } }];

        yield return
        [
            new[] { 3, 1, 3, 5, 1, 1 },
            8,
            new List<IList<int>> { new List<int> { 1, 1, 1, 5 }, new List<int> { 1, 1, 3, 3 }, new List<int> { 3, 5 } }
        ];

        yield return [new[] { 5, 5, 5, 5 }, 10, new List<IList<int>> { new List<int> { 5, 5 } }];

        yield return [new[] { 4, 4, 4, 1, 4 }, 8, new List<IList<int>> { new List<int> { 4, 4 } }];

        yield return
        [
            new[] { 1, 1, 2, 5, 6, 7, 10 },
            8,
            new List<IList<int>> { new List<int> { 1, 1, 6 }, new List<int> { 1, 2, 5 }, new List<int> { 1, 7 }, new List<int> { 2, 6 } }
        ];

        yield return [new[] { 2, 3, 5 }, 8, new List<IList<int>> { new List<int> { 3, 5 } }];

        yield return [new[] { 9, 8, 7 }, 1, new List<IList<int>>()];

        yield return [new[] { 1, 2, 2, 2, 3 }, 5, new List<IList<int>> { new List<int> { 1, 2, 2 }, new List<int> { 2, 3 } }];

        yield return [new[] { 6, 6, 6 }, 18, new List<IList<int>> { new List<int> { 6, 6, 6 } }];

        yield return [new[] { 1, 3, 5, 7, 9 }, 10, new List<IList<int>> { new List<int> { 1, 9 }, new List<int> { 3, 7 } }];

        yield return [new[] { 1, 1, 1, 1 }, 4, new List<IList<int>> { new List<int> { 1, 1, 1, 1 } }];
    }
}