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

namespace LeetCode.Algorithms.StudentAttendanceRecord1;

/// <summary>
///     https://leetcode.com/problems/student-attendance-record-i/description/
/// </summary>
public interface IStudentAttendanceRecord1
{
    /// <summary>
    ///     Determines whether the attendance record <paramref name="s" /> qualifies the student for an award,
    ///     which requires fewer than 2 absences ('A') and no 3 or more consecutive late days ('L').
    /// </summary>
    /// <param name="s">The attendance record consisting of 'A' (absent), 'L' (late), and 'P' (present).</param>
    /// <returns><see langword="true" /> if the student qualifies for the award; otherwise, <see langword="false" />.</returns>
    bool CheckRecord(string s);
}