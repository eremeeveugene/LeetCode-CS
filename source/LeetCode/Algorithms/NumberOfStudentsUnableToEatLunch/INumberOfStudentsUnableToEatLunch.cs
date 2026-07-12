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

namespace LeetCode.Algorithms.NumberOfStudentsUnableToEatLunch;

/// <summary>
///     https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/description/
/// </summary>
public interface INumberOfStudentsUnableToEatLunch
{
    /// <summary>
    ///     Simulates students in a queue repeatedly taking the sandwich at the top of the stack if it matches their
    ///     preference, and returns the number of students left unable to eat once no more students can take a
    ///     sandwich.
    /// </summary>
    /// <param name="students">The queue of students, each represented by their preferred sandwich type (0 or 1).</param>
    /// <param name="sandwiches">The stack of available sandwiches, each represented by its type (0 or 1).</param>
    /// <returns>The number of students who are unable to eat.</returns>
    int CountStudents(int[] students, int[] sandwiches);
}