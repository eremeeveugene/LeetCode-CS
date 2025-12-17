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

using LeetCode.Algorithms.DesignBrowserHistory;

namespace LeetCode.Tests.Algorithms.DesignBrowserHistory;

[TestClass]
public sealed class DesignBrowserHistoryArrayTests : DesignBrowserHistoryTestsBase
{
    protected override IDesignBrowserHistory GetSolution(string homepage)
    {
        return new DesignBrowserHistoryArray(homepage);
    }
}