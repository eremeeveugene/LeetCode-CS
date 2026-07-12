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

namespace LeetCode.Algorithms.FindTheKthCharacterInStringGame1;

/// <summary>
///     Find the K-th Character in String Game I
/// </summary>
public interface IFindTheKthCharacterInStringGame1
{
    /// <summary>
    ///     Returns the <paramref name="k" />-th character of the string built by repeatedly appending to "a" a copy of the
    ///     current string with each character changed to its next character in the alphabet.
    /// </summary>
    /// <param name="k">The 1-based position of the character to return.</param>
    /// <returns>The <paramref name="k" />-th character of the generated string.</returns>
    char KthCharacter(int k);
}