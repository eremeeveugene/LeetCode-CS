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

namespace LeetCode.Algorithms.NumberOfStepsToReduceNumberInBinaryRepresentationToOne;

/// <summary>
///     https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one/description/
/// </summary>
public interface INumberOfStepsToReduceNumberInBinaryRepresentationToOne
{
    /// <summary>
    ///     Computes the number of steps required to reduce the binary number represented by <paramref name="s" /> to
    ///     the value 1, where each step halves the number if it is even or subtracts 1 if it is odd.
    /// </summary>
    /// <param name="s">The binary representation of a positive integer, as a string of '0' and '1' characters.</param>
    /// <returns>The number of steps required to reduce the number represented by <paramref name="s" /> to 1.</returns>
    int NumSteps(string s);
}