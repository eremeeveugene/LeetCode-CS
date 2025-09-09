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

namespace LeetCode.Algorithms.NumberOfPeopleAwareOfSecret;

/// <inheritdoc />
public class NumberOfPeopleAwareOfSecretLineSweep : INumberOfPeopleAwareOfSecret
{
    private const int Modulo = 1_000_000_007;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="delay"></param>
    /// <param name="forget"></param>
    /// <returns></returns>
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        var length = n + forget + 2;

        Span<long> peopleWhoLearnOnDay = stackalloc long[length];

        peopleWhoLearnOnDay[1] = 1;

        Span<long> sharingDelta = stackalloc long[length];

        long currentKnowCount = 1;

        var personDelay = delay + 1;

        if (personDelay < length)
        {
            sharingDelta[personDelay] = (sharingDelta[personDelay] + 1) % Modulo;
        }

        var personForget = forget + 1;

        if (personForget < length)
        {
            sharingDelta[personForget] = (sharingDelta[personForget] - 1 + Modulo) % Modulo;
        }

        long currentSharers = 0;

        for (var day = 2; day <= n; day++)
        {
            currentSharers = (currentSharers + sharingDelta[day]) % Modulo;

            peopleWhoLearnOnDay[day] = currentSharers;

            currentKnowCount = (currentKnowCount + peopleWhoLearnOnDay[day]) % Modulo;

            var forgetDay = day - forget;

            if (forgetDay >= 1)
            {
                currentKnowCount = (currentKnowCount - peopleWhoLearnOnDay[forgetDay]) % Modulo;

                if (currentKnowCount < 0)
                {
                    currentKnowCount += Modulo;
                }
            }

            var shareStartDay = day + delay;
            var shareEndDay = day + forget;

            if (shareStartDay < length)
            {
                sharingDelta[shareStartDay] = (sharingDelta[shareStartDay] + peopleWhoLearnOnDay[day]) % Modulo;
            }

            if (shareEndDay < length)
            {
                sharingDelta[shareEndDay] = (sharingDelta[shareEndDay] - peopleWhoLearnOnDay[day] + Modulo) % Modulo;
            }
        }

        return (int)(currentKnowCount % Modulo);
    }
}