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

    /// <summary>
    ///     Deserializes a JSON string to the specified type <typeparamref name="T" />.
    ///     Handles all primitive types, arrays, jagged arrays, dynamic objects, and dictionaries.
    /// </summary>
    public static T Parse(string json)
    {
        if (typeof(T) == typeof(object))
        {
            using var doc = JsonDocument.Parse(json);
            return (T)ConvertElement(doc.RootElement)!;
        }

        if (typeof(T) == typeof(object[]))
        {
            using var doc = JsonDocument.Parse(json);
            var result = ConvertElement(doc.RootElement);
            return result is object[] array
                ? (T)(object)array
                : throw new InvalidCastException("Expected object[] in JSON root.");
        }

        if (typeof(T) == typeof(object[][]))
        {
            using var doc = JsonDocument.Parse(json);
            if (doc.RootElement.ValueKind != JsonValueKind.Array)
            {
                throw new JsonException("Expected a jagged array at JSON root.");
            }

            var jagged = doc.RootElement.EnumerateArray()
                .Select(inner =>
                    inner.ValueKind == JsonValueKind.Array
                        ? inner.EnumerateArray().Select(ConvertElement).ToArray()
                        : throw new JsonException("Expected all inner elements to be arrays.")
                ).ToArray();

            return (T)(object)jagged!;
        }

        // Default path: rely on strong typing if T is known (int[], string[], etc.)
        return JsonSerializer.Deserialize<T>(json, JsonHelperOptions.Options)
               ?? throw new JsonException($"Failed to deserialize JSON to type '{typeof(T)}'.");
    }

    private static object? ConvertElement(JsonElement element)
    {
        return element.ValueKind switch
        {
            JsonValueKind.Object => ConvertObject(element),
            JsonValueKind.Array => element.EnumerateArray().Select(ConvertElement).ToArray(),
            JsonValueKind.String => element.GetString(),
            JsonValueKind.Number => ConvertNumber(element),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.Null => null,
            _ => throw new NotSupportedException($"Unsupported JSON kind: {element.ValueKind}")
        };
    }

    private static object ConvertNumber(JsonElement element)
    {
        if (element.TryGetInt32(out var i))
        {
            return i;
        }

        if (element.TryGetInt64(out var l))
        {
            return l;
        }

        return element.GetDouble();
    }

    private static IDictionary<string, object?> ConvertObject(JsonElement element)
    {
        var dict = new Dictionary<string, object?>();
        foreach (var prop in element.EnumerateObject())
        {
            dict[prop.Name] = ConvertElement(prop.Value);
        }

        return dict;
    }
}