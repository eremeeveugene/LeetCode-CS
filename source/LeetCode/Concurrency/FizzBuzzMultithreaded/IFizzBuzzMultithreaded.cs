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

namespace LeetCode.Concurrency.FizzBuzzMultithreaded;

/// <summary>
///     https://leetcode.com/problems/fizz-buzz-multithreaded/description/
/// </summary>
public interface IFizzBuzzMultithreaded
{
    /// <summary>
    ///     Invokes <paramref name="printFizz" /> for every number, in sequence, that is divisible by 3 but not by
    ///     5, coordinating with the other threads printing the sequence.
    /// </summary>
    /// <param name="printFizz">The callback that prints "fizz".</param>
    void Fizz(Action printFizz);

    /// <summary>
    ///     Invokes <paramref name="printBuzz" /> for every number, in sequence, that is divisible by 5 but not by
    ///     3, coordinating with the other threads printing the sequence.
    /// </summary>
    /// <param name="printBuzz">The callback that prints "buzz".</param>
    void Buzz(Action printBuzz);

    /// <summary>
    ///     Invokes <paramref name="printFizzBuzz" /> for every number, in sequence, that is divisible by both 3 and
    ///     5, coordinating with the other threads printing the sequence.
    /// </summary>
    /// <param name="printFizzBuzz">The callback that prints "fizzbuzz".</param>
    void Fizzbuzz(Action printFizzBuzz);

    /// <summary>
    ///     Invokes <paramref name="printNumber" /> for every number, in sequence, that is not divisible by 3 or 5,
    ///     coordinating with the other threads printing the sequence.
    /// </summary>
    /// <param name="printNumber">The callback that prints the number itself.</param>
    void Number(Action<int> printNumber);
}