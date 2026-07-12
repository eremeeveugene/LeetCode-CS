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

namespace LeetCode.Algorithms.GenerateTagForVideoCaption;

/// <inheritdoc />
public sealed class GenerateTagForVideoCaptionCharArray : IGenerateTagForVideoCaption
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public string GenerateTag(string caption)
    {
        if (string.IsNullOrWhiteSpace(caption))
        {
            return "#";
        }

        var chars = new char[100];

        chars[0] = '#';

        var isFirstWord = true;
        var isWord = false;

        var length = 1;

        foreach (var @char in caption)
        {
            if (@char == ' ')
            {
                isWord = false;

                continue;
            }

            char charToAppend;

            if (isWord)
            {
                charToAppend = char.ToLowerInvariant(@char);
            }
            else
            {
                isWord = true;

                charToAppend = isFirstWord ? char.ToLowerInvariant(@char) : char.ToUpperInvariant(@char);

                isFirstWord = false;
            }

            if (TryAppend(chars, ref length, charToAppend))
            {
                break;
            }
        }

        return new string(chars, 0, length);
    }

    private static bool TryAppend(char[] chars, ref int length, char @char)
    {
        if (length == 100)
        {
            return true;
        }

        chars[length] = @char;

        length++;

        return false;
    }
}