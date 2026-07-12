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

/// <summary>
///     https://leetcode.com/problems/generate-tag-for-video-caption/description/
/// </summary>
public interface IGenerateTagForVideoCaption
{
    /// <summary>
    ///     Generates a camel-case hashtag from <paramref name="caption" /> by removing spaces, prefixing it with '#', and
    ///     truncating the result to 100 characters.
    /// </summary>
    /// <param name="caption">The video caption to convert.</param>
    /// <returns>The generated tag for the video caption.</returns>
    string GenerateTag(string caption);
}