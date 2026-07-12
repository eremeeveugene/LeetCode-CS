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

namespace LeetCode.Algorithms.OneBitAndTwoBitCharacters;

/// <inheritdoc />
public sealed class OneBitAndTwoBitCharactersIterative : IOneBitAndTwoBitCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsOneBitCharacter(int[] bits)
    {
        var i = 0;

        while (i < bits.Length - 1)
        {
            if (bits[i] == 0)
            {
                i++;
            }
            else
            {
                i += 2;
            }
        }

        return i == bits.Length - 1;
    }
}