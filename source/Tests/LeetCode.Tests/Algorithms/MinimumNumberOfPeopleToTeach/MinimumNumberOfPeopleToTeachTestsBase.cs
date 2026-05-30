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

using LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfPeopleToTeach;

public abstract class MinimumNumberOfPeopleToTeachTestsBase<T> where T : IMinimumNumberOfPeopleToTeach, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumTeachings_WithUsersLackingCommonLanguageInFriendships_ReturnsMinimumUsersToTeach(int languagesCount, int[][] languages, int[][] friendships, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumTeachings(languagesCount, languages, friendships);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [2, new[] { new[] { 1 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 3 } }, 1];

        yield return [3, new[] { new[] { 2 }, new[] { 1, 3 }, new[] { 1, 2 }, new[] { 3 } }, new[] { new[] { 1, 4 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 2, 3 } }, 2];
    }
}