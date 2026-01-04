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

namespace LeetCode.Algorithms.FindUniqueBinaryString;

/// <inheritdoc />
public class FindUniqueBinaryStringIterative : IFindUniqueBinaryString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public string FindDifferentBinaryString(string[] nums)
    {
        var result = new char[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i][i] == '0' ? '1' : '0';
        }

        return new string(result);
    }
}