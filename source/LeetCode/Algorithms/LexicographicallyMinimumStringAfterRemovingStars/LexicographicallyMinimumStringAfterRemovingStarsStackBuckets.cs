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

namespace LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

/// <inheritdoc />
public sealed class LexicographicallyMinimumStringAfterRemovingStarsStackBuckets :
    LexicographicallyMinimumStringAfterRemovingStarsBase
{
    private const int Length = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public override string ClearStars(string s)
    {
        var indexesStacks = new Stack<int>[Length];

        for (var i = 0; i < indexesStacks.Length; i++)
        {
            indexesStacks[i] = new Stack<int>();
        }

        var chars = s.ToCharArray();

        for (var i = 0; i < chars.Length; i++)
        {
            var c = chars[i];

            if (c == '*')
            {
                foreach (var indexesStack in indexesStacks)
                {
                    if (indexesStack.Count == 0)
                    {
                        continue;
                    }

                    var indexToRemove = indexesStack.Pop();

                    chars[indexToRemove] = '*';

                    break;
                }
            }
            else
            {
                indexesStacks[c - 'a'].Push(i);
            }
        }

        return BuildResult(chars);
    }
}