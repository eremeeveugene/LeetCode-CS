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

using System.Text;

namespace LeetCode.Algorithms.GenerateTagForVideoCaption;

/// <inheritdoc />
public class GenerateTagForVideoCaptionStringBuilder : IGenerateTagForVideoCaption
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="caption"></param>
    /// <returns></returns>
    public string GenerateTag(string caption)
    {
        if (string.IsNullOrWhiteSpace(caption))
        {
            return "#";
        }

        var words = caption.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var tagStringBuilder = new StringBuilder(100, 100);

        tagStringBuilder.Append('#');

        var firstWord = words[0].ToLowerInvariant();

        foreach (var c in firstWord)
        {
            if (tagStringBuilder.Length == 100)
            {
                return tagStringBuilder.ToString();
            }

            tagStringBuilder.Append(c);
        }

        for (var i = 1; i < words.Length; i++)
        {
            if (tagStringBuilder.Length == 100)
            {
                break;
            }

            tagStringBuilder.Append(char.ToUpperInvariant(words[i][0]));

            for (var j = 1; j < words[i].Length; j++)
            {
                if (tagStringBuilder.Length == 100)
                {
                    break;
                }

                tagStringBuilder.Append(char.ToLowerInvariant(words[i][j]));
            }
        }

        return tagStringBuilder.ToString();
    }
}