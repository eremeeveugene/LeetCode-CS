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

namespace LeetCode.Algorithms.InsertDeleteGetRandom;

/// <summary>
///     https://leetcode.com/problems/insert-delete-getrandom-o1/description/
/// </summary>
public interface IInsertDeleteGetRandom
{
    bool Insert(int value);
    bool Remove(int value);
    int GetRandom();
}