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

using LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;

namespace LeetCode.Tests.Algorithms.SmallestRangeCoveringElementsFromKLists;

public abstract class SmallestRangeCoveringElementsFromKListsTestsBase<T> where T : ISmallestRangeCoveringElementsFromKLists, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SmallestRange_WithMultipleSortedLists_ReturnsMinimumRangeIncludingAtLeastOneElementFromEachList(IList<IList<int>> nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestRange(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new IList<int>[] { new[] { 10 }, new[] { 11 } }, new[] { 10, 11 }];

        yield return [new IList<int>[] { new[] { 4, 10, 15, 24, 26 }, new[] { 0, 9, 12, 20 }, new[] { 5, 18, 22, 30 } }, new[] { 20, 24 }];

        yield return [new IList<int>[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 } }, new[] { 1, 1 }];
    }
}