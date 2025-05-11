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

using System.Collections;
using System.Text.Json;

namespace LeetCode.Core.Helpers;

/// <summary>
///     Provides JSON deserialization helpers for arrays and jagged collections of <typeparamref name="T" />.
/// </summary>
public static class JsonHelper<T>
{
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

    private static readonly JsonSerializerOptions Options = JsonHelperOptions.Options;

    /// <summary>
    ///     Deserializes a JSON string to the specified type <typeparamref name="T"/>.
    ///     Supports primitives, strings, Nullable<T>, any jagged arrays, IDictionary<string, U>,
    ///     and falls back to System.Text.Json for other types.
    /// </summary>
    public static T Parse(string json)
    {
        using var doc = JsonDocument.Parse(json);
        object? result = ParseElement(typeof(T), doc.RootElement);
        if (result is T t)
            return t;

        throw new JsonException($"Failed to convert JSON to {typeof(T)}.");
    }

    private static object? ParseElement(Type targetType, JsonElement element)
    {
        // 1. Nullable<T> support
        if (targetType.IsGenericType &&
            targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            Type innerType = Nullable.GetUnderlyingType(targetType)!;
            if (element.ValueKind == JsonValueKind.Null)
                return null;
            return ParseElement(innerType, element);
        }

        // 2. Dynamic (object) fallback
        if (targetType == typeof(object))
            return ConvertElement(element);

        // 3. Jagged or multidimensional arrays of any rank
        if (targetType.IsArray)
        {
            if (element.ValueKind != JsonValueKind.Array)
                throw new JsonException($"Expected JSON array for type {targetType}.");

            Type elemType = targetType.GetElementType()!;
            var items = element
                .EnumerateArray()
                .Select(e => ParseElement(elemType, e))
                .ToArray();

            var arr = Array.CreateInstance(elemType, items.Length);
            for (int i = 0; i < items.Length; i++)
                arr.SetValue(items[i], i);

            return arr;
        }

        // 4. IDictionary<string, U>
        if (targetType.IsGenericType &&
            targetType.GetGenericTypeDefinition() == typeof(IDictionary<,>))
        {
            Type[] args = targetType.GetGenericArguments();
            if (args[0] != typeof(string))
                throw new NotSupportedException("Only string keys are supported for dictionaries.");

            Type valueType = args[1];
            if (element.ValueKind != JsonValueKind.Object)
                throw new JsonException($"Expected JSON object for type {targetType}.");

            var dict = (IDictionary)Activator.CreateInstance(targetType)!;
            foreach (var prop in element.EnumerateObject())
            {
                object? val = ParseElement(valueType, prop.Value);
                dict.Add(prop.Name, val);
            }
            return dict;
        }

        // 5. Everything else: let System.Text.Json deserialize
        return JsonSerializer
            .Deserialize(element.GetRawText(), targetType, Options)
            ?? throw new JsonException($"Unable to deserialize to {targetType}.");
    }

    private static object? ConvertElement(JsonElement el) =>
        el.ValueKind switch
        {
            JsonValueKind.Object => ConvertObject(el),
            JsonValueKind.Array => el.EnumerateArray().Select(ConvertElement).ToArray(),
            JsonValueKind.String => el.GetString(),
            JsonValueKind.Number => ConvertNumber(el),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.Null => null,
            _ => throw new NotSupportedException($"Unsupported JSON kind: {el.ValueKind}")
        };

    private static object ConvertNumber(JsonElement el)
    {
        if (el.TryGetInt32(out int i)) return i;
        if (el.TryGetInt64(out long l)) return l;
        return el.GetDouble();
    }

    private static IDictionary<string, object?> ConvertObject(JsonElement el)
    {
        var dict = new Dictionary<string, object?>();
        foreach (var prop in el.EnumerateObject())
            dict[prop.Name] = ConvertElement(prop.Value);
        return dict;
    }
}