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
    // allow trailing commas in all JsonDocument parsing
    private static readonly JsonDocumentOptions DocumentOptions = new JsonDocumentOptions
    {
        AllowTrailingCommas = true
    };

    // clone your existing options and also allow trailing commas during JsonSerializer.Deserialize
    private static readonly JsonSerializerOptions SerializerOptions =
        new JsonSerializerOptions(JsonHelperOptions.Options)
        {
            AllowTrailingCommas = true
        };

    /// <summary>
    ///     Deserializes a JSON string to the specified type <typeparamref name="T"/>.
    ///     Supports primitives, strings, Nullable<T>, any jagged arrays,
    ///     IDictionary&lt;string, U&gt;, and falls back to System.Text.Json for other types.
    ///     Trailing commas are permitted.
    /// </summary>
    public static T Parse(string json)
    {
        using var doc = JsonDocument.Parse(json, DocumentOptions);
        object? result = ParseElement(typeof(T), doc.RootElement);
        if (result is T t)
            return t;
        throw new JsonException($"Failed to convert JSON to {typeof(T)}.");
    }

    private static object? ParseElement(Type targetType, JsonElement element)
    {
        // 1) Nullable<T>
        if (targetType.IsGenericType &&
            targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            Type inner = Nullable.GetUnderlyingType(targetType)!;
            return element.ValueKind == JsonValueKind.Null
                ? null
                : ParseElement(inner, element);
        }

        // 2) object → dynamic fallback
        if (targetType == typeof(object))
            return ConvertElement(element);

        // 3) arrays (including jagged)
        if (targetType.IsArray)
        {
            if (element.ValueKind != JsonValueKind.Array)
                throw new JsonException($"Expected JSON array for type {targetType}.");

            Type elemType = targetType.GetElementType()!;
            var items = element.EnumerateArray()
                               .Select(e => ParseElement(elemType, e))
                               .ToArray();

            var arr = Array.CreateInstance(elemType, items.Length);
            for (int i = 0; i < items.Length; i++)
                arr.SetValue(items[i], i);
            return arr;
        }

        // 4) IDictionary<string, U>
        if (targetType.IsGenericType &&
            targetType.GetGenericTypeDefinition() == typeof(IDictionary<,>))
        {
            var args = targetType.GetGenericArguments();
            if (args[0] != typeof(string))
                throw new NotSupportedException("Only string-keyed dictionaries are supported.");

            Type valType = args[1];
            if (element.ValueKind != JsonValueKind.Object)
                throw new JsonException($"Expected JSON object for type {targetType}.");

            var dict = (IDictionary)Activator.CreateInstance(targetType)!;
            foreach (var prop in element.EnumerateObject())
            {
                object? v = ParseElement(valType, prop.Value);
                dict.Add(prop.Name, v);
            }
            return dict;
        }

        // 5) fallback to System.Text.Json with trailing-comma support
        return JsonSerializer
            .Deserialize(element.GetRawText(), targetType, SerializerOptions)
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
        if (el.TryGetInt32(out var i)) return i;
        if (el.TryGetInt64(out var l)) return l;
        return el.GetDouble();
    }

    private static IDictionary<string, object?> ConvertObject(JsonElement el)
    {
        var d = new Dictionary<string, object?>();
        foreach (var p in el.EnumerateObject())
            d[p.Name] = ConvertElement(p.Value);
        return d;
    }
}