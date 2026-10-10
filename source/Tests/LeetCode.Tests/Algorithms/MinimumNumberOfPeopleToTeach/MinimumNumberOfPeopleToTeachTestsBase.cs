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
    public void MinimumTeachings_WithUsersLackingCommonLanguageInFriendships_ReturnsMinimumUsersToTeach(
        int languagesCount,
        int[][] languages,
        int[][] friendships,
        int expectedResult)
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

        yield return
        [
            3,
            new[] { new[] { 2 }, new[] { 1, 3 }, new[] { 1, 2 }, new[] { 3 } },
            new[] { new[] { 1, 4 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 2, 3 } },
            2
        ];
        yield return [5, new[] { new[] { 3, 4 }, new[] { 4 }, new[] { 4 }, new[] { 2, 5 }, new[] { 3 } }, new[] { new[] { 2, 4 }, new[] { 1, 4 }, new[] { 2, 3 }, new[] { 1, 2 }, new[] { 1, 3 } }, 1];
        yield return [4, new[] { new[] { 2 }, new[] { 4 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 3 } }, new[] { new[] { 2, 6 } }, 0];
        yield return [2, new[] { new[] { 1, 2 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 2, 3 } }, 0];
        yield return [2, new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 2 }, new[] { 1 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 3, 4 }, new[] { 2, 3 }, new[] { 2, 5 }, new[] { 2, 6 }, new[] { 3, 5 }, new[] { 1, 3 }, new[] { 1, 5 } }, 1];
        yield return [2, new[] { new[] { 1 }, new[] { 1 }, new[] { 1, 2 }, new[] { 2 }, new[] { 2 } }, new[] { new[] { 1, 4 }, new[] { 1, 2 }, new[] { 1, 5 }, new[] { 2, 3 } }, 1];
        yield return [2, new[] { new[] { 1 }, new[] { 1, 2 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 2, 4 } }, 0];
        yield return [5, new[] { new[] { 4, 5 }, new[] { 2 }, new[] { 4 }, new[] { 3 } }, new[] { new[] { 2, 3 } }, 1];
        yield return [3, new[] { new[] { 1, 3 }, new[] { 2 }, new[] { 1, 3 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 3 } }, new[] { new[] { 4, 6 }, new[] { 1, 2 }, new[] { 2, 5 }, new[] { 1, 6 }, new[] { 3, 4 }, new[] { 3, 6 }, new[] { 1, 3 } }, 2];
        yield return [5, new[] { new[] { 2 }, new[] { 2 }, new[] { 1, 5 } }, new[] { new[] { 2, 3 }, new[] { 1, 2 }, new[] { 1, 3 } }, 1];
        yield return [5, new[] { new[] { 2, 4 }, new[] { 1 }, new[] { 1 }, new[] { 3 }, new[] { 1, 2 }, new[] { 2 }, new[] { 2 } }, new[] { new[] { 2, 3 }, new[] { 5, 6 }, new[] { 3, 6 }, new[] { 1, 4 }, new[] { 1, 7 }, new[] { 4, 7 } }, 2];
        yield return [2, new[] { new[] { 1 }, new[] { 1 }, new[] { 2 }, new[] { 2 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 3, 4 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 3, 6 }, new[] { 2, 5 }, new[] { 4, 5 }, new[] { 2, 4 } }, 2];
        yield return [4, new[] { new[] { 4 }, new[] { 1, 3 }, new[] { 4 }, new[] { 3 }, new[] { 4 }, new[] { 4 }, new[] { 4 } }, new[] { new[] { 6, 7 }, new[] { 1, 3 }, new[] { 1, 6 }, new[] { 1, 2 }, new[] { 1, 7 }, new[] { 2, 3 }, new[] { 2, 7 }, new[] { 2, 6 } }, 1];
        yield return [5, new[] { new[] { 1 }, new[] { 5 }, new[] { 2 }, new[] { 1, 5 }, new[] { 2, 4 } }, new[] { new[] { 2, 3 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 1, 2 } }, 3];
        yield return [4, new[] { new[] { 3, 4 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 4 }, new[] { 3 } }, new[] { new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 1, 2 } }, 2];
        yield return [2, new[] { new[] { 1 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 2 }, new[] { 1, 2 } }, new[] { new[] { 1, 4 }, new[] { 3, 5 }, new[] { 1, 5 }, new[] { 3, 6 } }, 1];
        yield return [2, new[] { new[] { 2 }, new[] { 1 }, new[] { 2 }, new[] { 1 }, new[] { 2 }, new[] { 1, 2 }, new[] { 1 } }, new[] { new[] { 3, 6 }, new[] { 1, 5 }, new[] { 2, 7 }, new[] { 6, 7 }, new[] { 4, 5 } }, 1];
        yield return [3, new[] { new[] { 2 }, new[] { 1 }, new[] { 1 }, new[] { 2, 3 }, new[] { 1 }, new[] { 3 } }, new[] { new[] { 4, 5 }, new[] { 1, 4 }, new[] { 5, 6 }, new[] { 3, 5 } }, 1];
        yield return [3, new[] { new[] { 1 }, new[] { 1 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1 }, new[] { 2, 3 }, new[] { 2, 3 } }, new[] { new[] { 2, 6 }, new[] { 3, 6 }, new[] { 1, 2 }, new[] { 5, 7 } }, 2];
        yield return [4, new[] { new[] { 4 }, new[] { 3 }, new[] { 3, 4 }, new[] { 1, 2 }, new[] { 3 }, new[] { 3 } }, new[] { new[] { 4, 6 }, new[] { 2, 3 }, new[] { 1, 3 }, new[] { 1, 5 }, new[] { 4, 5 }, new[] { 2, 5 } }, 2];
        yield return [5, new[] { new[] { 2 }, new[] { 4 }, new[] { 1, 5 }, new[] { 3 }, new[] { 1, 2 }, new[] { 1 }, new[] { 1 } }, new[] { new[] { 1, 6 }, new[] { 1, 3 }, new[] { 3, 5 } }, 1];
        yield return [1, new[] { new[] { 1 }, new[] { 1 } }, new[] { new[] { 1, 2 } }, 0];

        var largeLanguages = new int[500][];
        var largeFriendships = new int[499][];

        for (var i = 0; i < 500; i++)
        {
            largeLanguages[i] = [i + 1];
        }

        for (var i = 0; i < 499; i++)
        {
            largeFriendships[i] = [i + 1, i + 2];
        }

        yield return [500, largeLanguages, largeFriendships, 499];
    }
}