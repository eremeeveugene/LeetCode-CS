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

using LeetCode.Algorithms.DesignEventManager;

namespace LeetCode.Tests.Algorithms.DesignEventManager;

[TestClass]
public sealed class DesignEventManagerDictionaryWithPriorityQueueTests : DesignEventManagerTestsBase
{
    protected override IDesignEventManager GetSolution(int[][] events)
    {
        return new DesignEventManagerDictionaryWithPriorityQueue(events);
    }
}