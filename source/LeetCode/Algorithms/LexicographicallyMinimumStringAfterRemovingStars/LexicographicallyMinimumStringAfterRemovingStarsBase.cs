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

namespace LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

public abstract class LexicographicallyMinimumStringAfterRemovingStarsBase :
    ILexicographicallyMinimumStringAfterRemovingStars
{
    public abstract string ClearStars(string s);

    protected static string BuildResult(char[] chars)
    {
        var lastLetterIndex = 0;

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '*')
            {
                continue;
            }

            chars[lastLetterIndex] = chars[i];

            lastLetterIndex++;
        }

        return new string(chars, 0, lastLetterIndex);
    }
}