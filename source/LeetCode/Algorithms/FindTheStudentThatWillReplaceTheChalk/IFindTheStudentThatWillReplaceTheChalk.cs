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

namespace LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

/// <summary>
///     https://leetcode.com/problems/find-the-student-that-will-replace-the-chalk/
/// </summary>
public interface IFindTheStudentThatWillReplaceTheChalk
{
    /// <summary>
    ///     Finds the index of the student who will replace the chalk when the students, taking turns in order and cycling
    ///     back to the start, consume chalk according to <paramref name="chalk" /> until fewer than the required pieces
    ///     remain.
    /// </summary>
    /// <param name="chalk">The number of chalk pieces each student uses on their turn.</param>
    /// <param name="k">The initial number of chalk pieces.</param>
    /// <returns>The index of the student who will replace the chalk.</returns>
    int ChalkReplacer(int[] chalk, int k);
}