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

using LeetCode.Algorithms.CheckIfAllOnesAreAtLeastLengthKPlacesAway;

namespace LeetCode.Tests.Algorithms.CheckIfAllOnesAreAtLeastLengthKPlacesAway;

public abstract class CheckIfAllOnesAreAtLeastLengthKPlacesAwayTestsBase<T> where T : ICheckIfAllOnesAreAtLeastLengthKPlacesAway, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2, true)]
    [DataRow(new[] { 1, 0, 0, 1, 0, 1 }, 2, false)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0, true)]
    [DataRow(new[] { 0, 1, 0, 1 }, 1, true)]
    [DataRow(new[] { 0, 1, 0, 1 }, 2, false)]
    [DataRow(new[] { 1, 0, 1 }, 1, true)]
    [DataRow(new[] { 1, 0, 1 }, 2, false)]
    [DataRow(new[] { 1 }, 5, true)]
    [DataRow(new[] { 0 }, 3, true)]
    [DataRow(new[] { 0, 0, 0 }, 2, true)]
    [DataRow(new[] { 1, 1 }, 0, true)]
    [DataRow(new[] { 1, 1 }, 1, false)]
    [DataRow(new[] { 1, 0, 0, 1 }, 2, true)]
    [DataRow(new[] { 1, 0, 0, 1 }, 3, false)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 1 }, 4, true)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 1 }, 5, false)]
    [DataRow(new[] { 0, 1, 0, 0, 1, 0 }, 2, true)]
    [DataRow(new[] { 0, 1, 0, 0, 1, 0 }, 3, false)]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, 1, true)]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, 2, false)]
    [DataRow(new[] { 1, 0, 0, 1, 0, 0, 1 }, 2, true)]
    public void KLengthApart_WithNumsArrayAndKDistance_ReturnsTrueIfOnesAreAtLeastKApart(int[] nums, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.KLengthApart(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}