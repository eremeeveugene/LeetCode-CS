// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.PushDominoes;

/// <inheritdoc />
public class PushDominoesForceArray : IPushDominoes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="dominoes"></param>
    /// <returns></returns>
    public string PushDominoes(string dominoes)
    {
        var forces = new int[dominoes.Length];

        var leftForce = 0;

        for (var left = 0; left < dominoes.Length; left++)
        {
            leftForce = dominoes[left] switch
            {
                'R' => dominoes.Length,
                'L' => 0,
                _ => Math.Max(0, leftForce - 1)
            };

            forces[left] += leftForce;
        }

        var rightForce = 0;

        for (var right = dominoes.Length - 1; right >= 0; right--)
        {
            rightForce = dominoes[right] switch
            {
                'R' => 0,
                'L' => dominoes.Length,
                _ => Math.Max(0, rightForce - 1)
            };

            forces[right] -= rightForce;
        }

        var result = new char[dominoes.Length];

        for (var i = 0; i < forces.Length; i++)
        {
            result[i] = forces[i] switch
            {
                > 0 => 'R',
                < 0 => 'L',
                _ => '.'
            };
        }

        return new string(result);
    }
}