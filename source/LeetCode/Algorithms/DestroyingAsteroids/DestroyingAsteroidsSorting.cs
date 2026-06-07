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

namespace LeetCode.Algorithms.DestroyingAsteroids;

/// <inheritdoc />
public sealed class DestroyingAsteroidsSorting : IDestroyingAsteroids
{
    private const int MaxAsteroidMass = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        var n = asteroids.Length;

        Array.Sort(asteroids);

        for (var i = 0; i < n; i++)
        {
            var asteroid = asteroids[i];

            if (mass < asteroid)
            {
                return false;
            }

            mass += asteroid;

            if (mass > MaxAsteroidMass)
            {
                return true;
            }
        }

        return true;
    }
}