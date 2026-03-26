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

using LeetCode.Algorithms.DesignParkingSystem;

namespace LeetCode.Tests.Algorithms.DesignParkingSystem;

[TestClass]
public sealed class DesignParkingSystemCountingTests : DesignParkingSystemTestsBase
{
    protected override IDesignParkingSystem GetSolution(int bigCapacity, int mediumCapacity, int smallCapacity)
    {
        return new DesignParkingSystemCounting(bigCapacity, mediumCapacity, smallCapacity);
    }
}