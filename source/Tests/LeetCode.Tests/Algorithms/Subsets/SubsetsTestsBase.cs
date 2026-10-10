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

using LeetCode.Algorithms.Subsets;

namespace LeetCode.Tests.Algorithms.Subsets;

public abstract class SubsetsTestsBase<T> where T : ISubsets, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Subsets_GivenArrayOfNumbers_ReturnsAllPossibleSubsets(int[] nums, IList<IList<int>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Subsets(nums);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { 1, 2, 3 },
            new IList<int>[]
            {
                Array.Empty<int>(), new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 3 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 1, 2, 3 }
            }
        ];

        yield return [new[] { 0 }, new IList<int>[] { Array.Empty<int>(), new[] { 0 } }];

        yield return [new[] { 5 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 5 }
        }];

        yield return [new[] { -1, 1 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -1 }, new[] { 1 }, new[] { -1, 1 }
        }];

        yield return [new[] { 1, 2 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 1 }, new[] { 2 }, new[] { 1, 2 }
        }];

        yield return [new[] { 3, 1 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 3 }, new[] { 1 }, new[] { 3, 1 }
        }];

        yield return [new[] { -10, 10 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -10 }, new[] { 10 }, new[] { -10, 10 }
        }];

        yield return [new[] { 1, 2, 3, 4 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 3 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 1, 2, 3 }, new[] { 4 }, new[] { 1, 4 }, new[] { 2, 4 }, new[] { 1, 2, 4 }, new[] { 3, 4 }, new[] { 1, 3, 4 }, new[] { 2, 3, 4 }, new[] { 1, 2, 3, 4 }
        }];

        yield return [new[] { 0, 1, 2, 3 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 0 }, new[] { 1 }, new[] { 0, 1 }, new[] { 2 }, new[] { 0, 2 }, new[] { 1, 2 }, new[] { 0, 1, 2 }, new[] { 3 }, new[] { 0, 3 }, new[] { 1, 3 }, new[] { 0, 1, 3 }, new[] { 2, 3 }, new[] { 0, 2, 3 }, new[] { 1, 2, 3 }, new[] { 0, 1, 2, 3 }
        }];

        yield return [new[] { -1, -2, -3 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -1 }, new[] { -2 }, new[] { -1, -2 }, new[] { -3 }, new[] { -1, -3 }, new[] { -2, -3 }, new[] { -1, -2, -3 }
        }];

        yield return [new[] { 10, -10, 0 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 10 }, new[] { -10 }, new[] { 10, -10 }, new[] { 0 }, new[] { 10, 0 }, new[] { -10, 0 }, new[] { 10, -10, 0 }
        }];

        yield return [new[] { 7, 8, 9, 4 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 7 }, new[] { 8 }, new[] { 7, 8 }, new[] { 9 }, new[] { 7, 9 }, new[] { 8, 9 }, new[] { 7, 8, 9 }, new[] { 4 }, new[] { 7, 4 }, new[] { 8, 4 }, new[] { 7, 8, 4 }, new[] { 9, 4 }, new[] { 7, 9, 4 }, new[] { 8, 9, 4 }, new[] { 7, 8, 9, 4 }
        }];

        yield return [new[] { 2, 4, 6, 8 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 2 }, new[] { 4 }, new[] { 2, 4 }, new[] { 6 }, new[] { 2, 6 }, new[] { 4, 6 }, new[] { 2, 4, 6 }, new[] { 8 }, new[] { 2, 8 }, new[] { 4, 8 }, new[] { 2, 4, 8 }, new[] { 6, 8 }, new[] { 2, 6, 8 }, new[] { 4, 6, 8 }, new[] { 2, 4, 6, 8 }
        }];

        yield return [new[] { 1, 2, 3, 4, 5 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 3 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 1, 2, 3 }, new[] { 4 }, new[] { 1, 4 }, new[] { 2, 4 }, new[] { 1, 2, 4 }, new[] { 3, 4 }, new[] { 1, 3, 4 }, new[] { 2, 3, 4 }, new[] { 1, 2, 3, 4 }, new[] { 5 }, new[] { 1, 5 }, new[] { 2, 5 }, new[] { 1, 2, 5 }, new[] { 3, 5 }, new[] { 1, 3, 5 }, new[] { 2, 3, 5 }, new[] { 1, 2, 3, 5 }, new[] { 4, 5 }, new[] { 1, 4, 5 }, new[] { 2, 4, 5 }, new[] { 1, 2, 4, 5 }, new[] { 3, 4, 5 }, new[] { 1, 3, 4, 5 }, new[] { 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }
        }];

        yield return [new[] { -5, 0, 5 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -5 }, new[] { 0 }, new[] { -5, 0 }, new[] { 5 }, new[] { -5, 5 }, new[] { 0, 5 }, new[] { -5, 0, 5 }
        }];

        yield return [new[] { -10 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -10 }
        }];

        yield return [new[] { -3, -2, -1, 0 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -3 }, new[] { -2 }, new[] { -3, -2 }, new[] { -1 }, new[] { -3, -1 }, new[] { -2, -1 }, new[] { -3, -2, -1 }, new[] { 0 }, new[] { -3, 0 }, new[] { -2, 0 }, new[] { -3, -2, 0 }, new[] { -1, 0 }, new[] { -3, -1, 0 }, new[] { -2, -1, 0 }, new[] { -3, -2, -1, 0 }
        }];

        yield return [new[] { 9, 8, 7 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 9 }, new[] { 8 }, new[] { 9, 8 }, new[] { 7 }, new[] { 9, 7 }, new[] { 8, 7 }, new[] { 9, 8, 7 }
        }];

        yield return [new[] { 6, -6 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 6 }, new[] { -6 }, new[] { 6, -6 }
        }];

        yield return [new[] { 4, 2 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { 4 }, new[] { 2 }, new[] { 4, 2 }
        }];

        yield return [new[] { -7, 7, 0, 3 }, new IList<int>[]
        {
            Array.Empty<int>(), new[] { -7 }, new[] { 7 }, new[] { -7, 7 }, new[] { 0 }, new[] { -7, 0 }, new[] { 7, 0 }, new[] { -7, 7, 0 }, new[] { 3 }, new[] { -7, 3 }, new[] { 7, 3 }, new[] { -7, 7, 3 }, new[] { 0, 3 }, new[] { -7, 0, 3 }, new[] { 7, 0, 3 }, new[] { -7, 7, 0, 3 }
        }];
    }
}