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

namespace LeetCode.Algorithms.DivideStringIntoGroupsOfSizeK;

/// <summary>
///     https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/description/
/// </summary>
public interface IDivideStringIntoGroupsOfSizeK
{
    string[] DivideString(string s, int k, char fill);
}