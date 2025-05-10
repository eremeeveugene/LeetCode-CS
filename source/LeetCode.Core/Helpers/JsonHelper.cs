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

using System.Text.Json;

namespace LeetCode.Core.Helpers;

/// <summary>
///     Provides JSON deserialization helpers for arrays and jagged collections of <typeparamref name="T" />.
/// </summary>
public static class JsonHelper<T>
{
    /// <summary>
    ///     Deserializes the JSON in <paramref name="json" /> to a <see cref="T" />[].
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="JsonException"></exception>
    public static T[] DeserializeToArray(string json)
    {
        return JsonSerializer.Deserialize<T[]>(json, JsonHelperOptions.Options)
               ?? throw new JsonException("Failed to deserialize JSON array.");
    }

    /// <summary>
    ///     Deserializes the JSON in <paramref name="json" /> to a jagged array of <see cref="T" />[][].
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="JsonException"></exception>
    public static T[][] DeserializeToJaggedArray(string json)
    {
        return JsonSerializer.Deserialize<T[][]>(json, JsonHelperOptions.Options)
               ?? throw new JsonException("Failed to deserialize JSON jagged array.");
    }

    /// <summary>
    ///     Deserializes the JSON in <paramref name="json" /> to a jagged list of <see cref="T" /> (`IList&lt;IList&lt;T&gt;
    ///     &gt;`).
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="JsonException"></exception>
    public static IList<IList<T>> DeserializeToJaggedList(string json)
    {
        return JsonSerializer.Deserialize<IList<IList<T>>>(json, JsonHelperOptions.Options)
               ?? throw new JsonException("Failed to deserialize JSON jagged list.");
    }
}