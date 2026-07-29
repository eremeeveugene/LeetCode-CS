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

namespace LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;

/// <inheritdoc />
public sealed class MinimumNumberOfPeopleToTeachGreedyCounting : IMinimumNumberOfPeopleToTeach
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n), where m is the number of users and n is the number of languages
    ///     Space complexity - O(m * n), where m is the number of users and n is the number of languages
    /// </remarks>
    public int MinimumTeachings(int languagesCount, int[][] languages, int[][] friendships)
    {
        var usersCount = languages.Length;

        Span<bool> userLanguages = stackalloc bool[usersCount * languagesCount];

        for (var i = 0; i < usersCount; i++)
        {
            foreach (var language in languages[i])
            {
                userLanguages[GetUserLanguageIndex(i, language - 1, languagesCount)] = true;
            }
        }

        Span<bool> usersToTeach = stackalloc bool[usersCount];

        Span<int> usersToTeachIndices = stackalloc int[usersCount];

        var usersToTeachCount = 0;

        foreach (var friendship in friendships)
        {
            var userA = friendship[0] - 1;
            var userB = friendship[1] - 1;

            if (HaveCommonLanguage(userLanguages, userA, userB, languagesCount))
            {
                continue;
            }

            AddUserToTeach(userA, usersToTeach, usersToTeachIndices, ref usersToTeachCount);
            AddUserToTeach(userB, usersToTeach, usersToTeachIndices, ref usersToTeachCount);
        }

        var mostCommonLanguageCount = GetMostCommonLanguageCount(userLanguages, usersToTeachIndices, usersToTeachCount, languagesCount);

        return usersToTeachCount - mostCommonLanguageCount;
    }

    private static bool HaveCommonLanguage(ReadOnlySpan<bool> userLanguages, int userA, int userB, int languagesCount)
    {
        for (var language = 0; language < languagesCount; language++)
        {
            if (userLanguages[GetUserLanguageIndex(userA, language, languagesCount)] &&
                userLanguages[GetUserLanguageIndex(userB, language, languagesCount)])
            {
                return true;
            }
        }

        return false;
    }

    private static void AddUserToTeach(int user, Span<bool> usersToTeach, Span<int> usersToTeachIndices, ref int usersToTeachCount)
    {
        if (usersToTeach[user])
        {
            return;
        }

        usersToTeach[user] = true;
        usersToTeachIndices[usersToTeachCount] = user;
        usersToTeachCount++;
    }

    private static int GetMostCommonLanguageCount(
        ReadOnlySpan<bool> userLanguages,
        ReadOnlySpan<int> usersToTeachIndices,
        int usersToTeachCount,
        int languagesCount)
    {
        var mostCommonLanguageCount = 0;

        for (var language = 0; language < languagesCount; language++)
        {
            var currentLanguageCount = 0;

            for (var i = 0; i < usersToTeachCount; i++)
            {
                var user = usersToTeachIndices[i];

                if (userLanguages[GetUserLanguageIndex(user, language, languagesCount)])
                {
                    currentLanguageCount++;
                }
            }

            mostCommonLanguageCount = Math.Max(mostCommonLanguageCount, currentLanguageCount);
        }

        return mostCommonLanguageCount;
    }

    private static int GetUserLanguageIndex(int user, int language, int languagesCount)
    {
        return (user * languagesCount) + language;
    }
}