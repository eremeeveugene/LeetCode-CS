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

using LeetCode.Algorithms.SpecialArray2;

namespace LeetCode.Tests.Algorithms.SpecialArray2;

public abstract class SpecialArray2TestsBase<T> where T : ISpecialArray2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsArraySpecial_WithSubarrayQueries_ReturnsWhetherEachSubarrayHasAlternatingParity(int[] nums, int[][] queries, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsArraySpecial(nums, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3, 4, 1, 2, 6 }, new[] { new[] { 0, 4 } }, new[] { false }];

        yield return [new[] { 4, 3, 1, 6 }, new[] { new[] { 0, 2 }, new[] { 2, 3 } }, new[] { false, true }];
    }
}