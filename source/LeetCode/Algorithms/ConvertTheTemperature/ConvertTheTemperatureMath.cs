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

namespace LeetCode.Algorithms.ConvertTheTemperature;

/// <inheritdoc />
public class ConvertTheTemperatureMath : IConvertTheTemperature
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="celsius"></param>
    /// <returns></returns>
    public double[] ConvertTemperature(double celsius)
    {
        var kelvin = celsius + 273.15;
        var fahrenheit = (celsius * 1.8) + 32;

        return [kelvin, fahrenheit];
    }
}