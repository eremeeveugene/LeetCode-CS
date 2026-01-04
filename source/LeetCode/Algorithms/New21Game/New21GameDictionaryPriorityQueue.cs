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

namespace LeetCode.Algorithms.New21Game;

/// <inheritdoc />
public class New21GameDictionaryPriorityQueue : INew21Game
{
    /// <summary>
    ///     Time complexity - O(k * maxPts * log k)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <param name="maxPts"></param>
    /// <returns></returns>
    public double New21Game(int n, int k, int maxPts)
    {
        if (k == 0 || n >= k - 1 + maxPts)
        {
            return 1;
        }

        var result = 0.0;

        var probabilityByScoreDictionary = new Dictionary<int, double>();

        for (var point = 1; point <= maxPts; point++)
        {
            probabilityByScoreDictionary.Add(point, 1.0 / maxPts);
        }

        var scoresPriorityQueue = new PriorityQueue<int, int>();

        foreach (var (score, probability) in probabilityByScoreDictionary)
        {
            if (score < k)
            {
                scoresPriorityQueue.Enqueue(score, score);
            }
            else if (score <= n)
            {
                result += probability;
            }
        }

        while (scoresPriorityQueue.Count > 0)
        {
            var currentScore = scoresPriorityQueue.Dequeue();

            var currentProbability = probabilityByScoreDictionary[currentScore];

            if (currentProbability == 0.0)
            {
                continue;
            }

            probabilityByScoreDictionary[currentScore] = 0.0;

            var probabilityPerDraw = currentProbability / maxPts;

            for (var drawValue = 1; drawValue <= maxPts; drawValue++)
            {
                var nextScore = currentScore + drawValue;

                if (nextScore < k)
                {
                    probabilityByScoreDictionary.TryGetValue(nextScore, out var oldProbability);
                    probabilityByScoreDictionary[nextScore] = oldProbability + probabilityPerDraw;

                    scoresPriorityQueue.Enqueue(nextScore, nextScore);
                }
                else if (nextScore <= n)
                {
                    result += probabilityPerDraw;
                }
            }
        }

        return result;
    }
}