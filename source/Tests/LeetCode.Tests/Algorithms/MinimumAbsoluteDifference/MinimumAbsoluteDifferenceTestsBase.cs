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

using LeetCode.Algorithms.MinimumAbsoluteDifference;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MinimumAbsoluteDifference;

public abstract class MinimumAbsoluteDifferenceTestsBase<T> where T : IMinimumAbsoluteDifference, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumAbsDifference_WithDistinctIntegersArray_ReturnsAllPairsWithMinimumAbsoluteDifference(
        int[] arr, IList<IList<int>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumAbsDifference(arr);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 4, 2, 1, 3 }, new IList<int>[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }];

        yield return [new[] { 1, 3, 6, 10, 15 }, new IList<int>[] { new[] { 1, 3 } }];

        yield return [new[] { 3, 8, -10, 23, 19, -4, -14, 27 }, new IList<int>[] { new[] { -14, -10 }, new[] { 19, 23 }, new[] { 23, 27 } }];
    }
}
