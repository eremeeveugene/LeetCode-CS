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

namespace LeetCode.Algorithms.DefangingAnIPAddress;

/// <summary>
///     https://leetcode.com/problems/defanging-an-ip-address/description/
/// </summary>
public interface IDefangingAnIPAddress
{
    /// <summary>
    ///     Returns a defanged version of <paramref name="address" /> in which every period "." is replaced with "[.]".
    /// </summary>
    /// <param name="address">The valid IPv4 address to defang.</param>
    /// <returns>The defanged IP address.</returns>
    string DefangIPaddr(string address);
}