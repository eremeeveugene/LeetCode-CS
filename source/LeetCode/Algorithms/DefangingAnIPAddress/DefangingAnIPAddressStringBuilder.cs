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

using System.Text;

namespace LeetCode.Algorithms.DefangingAnIPAddress;

/// <inheritdoc />
public class DefangingAnIPAddressStringBuilder : IDefangingAnIPAddress
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public string DefangIPaddr(string address)
    {
        var stringBuilder = new StringBuilder();

        foreach (var @char in address)
        {
            if (@char == '.')
            {
                stringBuilder.Append("[.]");
            }
            else
            {
                stringBuilder.Append(@char);
            }
        }

        return stringBuilder.ToString();
    }
}