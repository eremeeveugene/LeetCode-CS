// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TimeNeededToBuyTickets;

/// <inheritdoc />
public class TimeNeededToBuyTicketsIterative : ITimeNeededToBuyTickets
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="tickets"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var time = 0;

        for (var i = 0; i < tickets.Length; i++)
        {
            if (i == k)
            {
                time += tickets[k];
            }
            else
            {
                if (tickets[i] >= tickets[k])
                {
                    if (i > k)
                    {
                        time += tickets[k] - 1;
                    }
                    else
                    {
                        time += tickets[k];
                    }
                }
                else
                {
                    time += tickets[i];
                }
            }
        }

        return time;
    }
}