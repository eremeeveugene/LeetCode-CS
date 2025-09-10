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

namespace LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;

/// <inheritdoc />
public class MinimumNumberOfPeopleToTeachGreedyCounting : IMinimumNumberOfPeopleToTeach
{
    /// <summary>
    ///     Time complexity - O(m * n + f * n), where m is the number of users, n is the number of languages and f is the
    ///     number of friendships
    ///     Space complexity - O(m * n), where m is the number of users and n is the number of languages
    /// </summary>
    /// <param name="languagesCount"></param>
    /// <param name="languages"></param>
    /// <param name="friendships"></param>
    /// <returns></returns>
    public int MinimumTeachings(int languagesCount, int[][] languages, int[][] friendships)
    {
        var usersCount = languages.Length;

        var userLanguages = new bool[usersCount, languagesCount];

        for (var i = 0; i < usersCount; i++)
        {
            foreach (var language in languages[i])
            {
                userLanguages[i, language - 1] = true;
            }
        }

        Span<bool> usersToTeach = stackalloc bool[usersCount];

        var usersToTeachCount = 0;

        foreach (var friendship in friendships)
        {
            var userA = friendship[0] - 1;
            var userB = friendship[1] - 1;

            var isOverlap = false;

            for (var language = 0; language < languagesCount; language++)
            {
                if (!userLanguages[userA, language] || !userLanguages[userB, language])
                {
                    continue;
                }

                isOverlap = true;

                break;
            }

            if (isOverlap)
            {
                continue;
            }

            if (!usersToTeach[userA])
            {
                usersToTeach[userA] = true;

                usersToTeachCount++;
            }

            if (!usersToTeach[userB])
            {
                usersToTeach[userB] = true;

                usersToTeachCount++;
            }
        }

        if (usersToTeachCount == 0)
        {
            return 0;
        }

        var mostCommonLanguageCount = 0;

        for (var language = 0; language < languagesCount; language++)
        {
            var currentLanguageCount = 0;

            for (var user = 0; user < usersCount; user++)
            {
                if (!usersToTeach[user])
                {
                    continue;
                }

                if (userLanguages[user, language])
                {
                    currentLanguageCount++;
                }
            }

            mostCommonLanguageCount = Math.Max(mostCommonLanguageCount, currentLanguageCount);
        }

        return usersToTeachCount - mostCommonLanguageCount;
    }
}