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

using LeetCode.Algorithms.ToggleLightBulbs;

namespace LeetCode.Tests.Algorithms.ToggleLightBulbs;

public abstract class ToggleLightBulbsTestsBase<T> where T : IToggleLightBulbs, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ToggleLightBulbs_WithGivenBulbSequence_ReturnsSwitchedOnBulbsSortedInAscendingOrder(
        List<int> bulbs, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ToggleLightBulbs(bulbs).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new List<int> { 100, 100 }, Array.Empty<int>()];

        yield return [new List<int> { 10, 30, 20, 10 }, new[] { 20, 30 }];
    }
}