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

using LeetCode.Algorithms.DivideArrayIntoArraysWithMaxDifference;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DivideArrayIntoArraysWithMaxDifference;

public abstract class DivideArrayIntoArraysWithMaxDifferenceTestsBase<T> where T : IDivideArrayIntoArraysWithMaxDifference, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DivideArray_WithVariousInputs_ReturnsCorrectTripletGroupingOrEmptyArray(int[] nums, int k, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DivideArray(nums, k);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 8, 7, 9, 3, 5, 1 }, 2, new[] { new[] { 1, 1, 3 }, new[] { 3, 4, 5 }, new[] { 7, 8, 9 } }];

        yield return [new[] { 2, 4, 2, 2, 5, 2 }, 2, Array.Empty<int[]>()];

        yield return
        [
            new[] { 4, 2, 9, 8, 2, 12, 7, 12, 10, 5, 8, 5, 5, 7, 9, 2, 5, 11 },
            14,
            new[] { new[] { 2, 2, 2 }, new[] { 4, 5, 5 }, new[] { 5, 5, 7 }, new[] { 7, 8, 8 }, new[] { 9, 9, 10 }, new[] { 11, 12, 12 } }
        ];
    }
}