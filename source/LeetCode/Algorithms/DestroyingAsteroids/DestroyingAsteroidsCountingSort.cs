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
public sealed class DestroyingAsteroidsCountingSort : IDestroyingAsteroids
{
    private const int MaxAsteroidMass = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        var n = asteroids.Length;

        Span<int> asteroidsCounts = stackalloc int[MaxAsteroidMass + 1];

        var minAsteroid = MaxAsteroidMass;
        var maxAsteroid = 1;

        for (var i = 0; i < n; i++)
        {
            var asteroid = asteroids[i];

            minAsteroid = Math.Min(minAsteroid, asteroid);
            maxAsteroid = Math.Max(maxAsteroid, asteroid);

            asteroidsCounts[asteroid]++;
        }

        long totalMass = mass;

        var asteroidMass = minAsteroid;

        while (asteroidMass <= maxAsteroid)
        {
            var count = asteroidsCounts[asteroidMass];

            if (count == 0)
            {
                asteroidMass++;

                continue;
            }

            if (totalMass < asteroidMass)
            {
                return false;
            }

            totalMass += (long)asteroidMass * count;

            if (totalMass > MaxAsteroidMass)
            {
                return true;
            }

            asteroidMass++;
        }

        return true;
    }
}