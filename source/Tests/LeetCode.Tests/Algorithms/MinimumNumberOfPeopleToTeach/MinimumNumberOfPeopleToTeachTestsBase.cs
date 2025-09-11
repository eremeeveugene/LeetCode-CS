// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfPeopleToTeach;

public abstract class MinimumNumberOfPeopleToTeachTestsBase<T> where T : IMinimumNumberOfPeopleToTeach, new()
{
    [TestMethod]
    [DataRow(2, "[[1],[2],[1,2]]", "[[1,2],[1,3],[2,3]]", 1)]
    [DataRow(3, "[[2],[1,3],[1,2],[3]]", "[[1,4],[1,2],[3,4],[2,3]]", 2)]
    public void MinimumTeachings_WithUsersLackingCommonLanguageInFriendships_ReturnsMinimumUsersToTeach(
        int languagesCount, string languagesJson, string friendshipsJson, int expectedResult)
    {
        // Arrange
        var languages = JsonHelper<int[][]>.Parse(languagesJson);
        var friendships = JsonHelper<int[][]>.Parse(friendshipsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumTeachings(languagesCount, languages, friendships);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}