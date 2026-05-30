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
using LeetCode.Tests.Base.Extensions;

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
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 3 }, new IList<int>[] { Array.Empty<int>(), new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 3 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 1, 2, 3 } }];

        yield return [new[] { 0 }, new IList<int>[] { Array.Empty<int>(), new[] { 0 } }];
    }
}
