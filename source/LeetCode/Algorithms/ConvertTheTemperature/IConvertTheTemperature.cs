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

namespace LeetCode.Algorithms.ConvertTheTemperature;

/// <summary>
///     https://leetcode.com/problems/convert-the-temperature/description/
/// </summary>
public interface IConvertTheTemperature
{
    /// <summary>
    ///     Converts the temperature <paramref name="celsius" /> from Celsius to Kelvin and Fahrenheit.
    /// </summary>
    /// <param name="celsius">The temperature in degrees Celsius.</param>
    /// <returns>An array containing the temperature in Kelvin followed by the temperature in Fahrenheit.</returns>
    double[] ConvertTemperature(double celsius);
}