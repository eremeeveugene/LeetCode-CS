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

using LeetCode.Algorithms.SearchInsertPosition;

namespace LeetCode.Tests.Algorithms.SearchInsertPosition;

public abstract class SearchInsertPositionTestsBase
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 6 }, 2, 1)]
    [DataRow(new[] { 1, 3, 5, 6 }, 5, 2)]
    [DataRow(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void SearchInsert_WithSortedArrayAndTarget_ReturnsCorrectInsertionIndex(int[] nums, int target,
        int expectedResult)
    {
        // Arrange
        var solution = GetSolution();

        // Act
        var actualResult = solution.SearchInsert(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    protected abstract ISearchInsertPosition GetSolution();
}