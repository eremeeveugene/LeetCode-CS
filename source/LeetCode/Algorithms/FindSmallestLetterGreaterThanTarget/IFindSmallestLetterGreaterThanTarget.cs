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

namespace LeetCode.Algorithms.FindSmallestLetterGreaterThanTarget;

/// <summary>
///     https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/
/// </summary>
public interface IFindSmallestLetterGreaterThanTarget
{
    char NextGreatestLetter(char[] letters, char target);
}