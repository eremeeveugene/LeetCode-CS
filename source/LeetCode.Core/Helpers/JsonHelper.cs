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

using System.Collections;
using System.Globalization;
using System.Text.Json;

namespace LeetCode.Core.Helpers;

public static class JsonHelper<T>
{
    private static readonly Type TargetType = typeof(T);

    public static T Parse(string json)
    {
        using var jsonDocument = JsonDocument.Parse(json, JsonHelperOptions.JsonDocumentOptions);

        var result = DeserializeElement(jsonDocument.RootElement, TargetType);

        return result switch
        {
            null when !typeof(T).IsValueType || Nullable.GetUnderlyingType(typeof(T)) is not null => default!,
            T t => t,
            _ => throw new JsonException($"JsonHelper<{TargetType.Name}>: could not convert JSON to {TargetType}.")
        };
    }

    private static object? DeserializeElement(JsonElement jsonElement, Type type)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            if (jsonElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            type = Nullable.GetUnderlyingType(type)!;
        }

        if (type == typeof(object))
        {
            return ConvertElement(jsonElement);
        }

        if (IsPrimitiveType(type))
        {
            return ConvertToPrimitive(jsonElement, type);
        }

        if (type.IsArray)
        {
            return DeserializeArray(jsonElement, type.GetElementType()!);
        }

        if (IsListType(type, out var itemType))
        {
            return DeserializeList(jsonElement, type, itemType);
        }

        if (IsDictionaryType(type, out var valueType))
        {
            return DeserializeDictionary(jsonElement, type, valueType);
        }

        return JsonSerializer.Deserialize(jsonElement.GetRawText(), type, JsonHelperOptions.JsonSerializerOptions) ??
               throw new JsonException($"Unable to deserialize JSON to {type}.");
    }

    private static bool IsPrimitiveType(Type type)
    {
        return type == typeof(string) ||
               type == typeof(bool) ||
               type == typeof(int) ||
               type == typeof(long) ||
               type == typeof(double) ||
               type == typeof(decimal);
    }

    private static object? ConvertToPrimitive(JsonElement jsonElement, Type type)
    {
        return type switch
        {
            _ when type == typeof(string) => jsonElement.GetString(),
            _ when type == typeof(bool) => jsonElement.GetBoolean(),
            _ when type == typeof(int) => jsonElement.GetInt32(),
            _ when type == typeof(long) => jsonElement.GetInt64(),
            _ when type == typeof(double) => jsonElement.GetDouble(),
            _ when type == typeof(decimal) => jsonElement.GetDecimal(),
            _ => Convert.ChangeType(ConvertElement(jsonElement), type, CultureInfo.InvariantCulture)
        };
    }

    private static Array DeserializeArray(JsonElement jsonElement, Type type)
    {
        if (jsonElement.ValueKind != JsonValueKind.Array)
        {
            throw new JsonException($"Expected JSON array for {type}[]");
        }

        var items = jsonElement.EnumerateArray()
            .Select(item => DeserializeElement(item, type))
            .ToArray();

        var array = Array.CreateInstance(type, items.Length);

        for (var i = 0; i < items.Length; i++)
        {
            array.SetValue(items[i], i);
        }

        return array;
    }

    private static IList DeserializeList(JsonElement jsonElement, Type listType, Type itemType)
    {
        if (jsonElement.ValueKind != JsonValueKind.Array)
        {
            throw new JsonException($"Expected JSON array for {listType.Name}");
        }

        var list = (IList)Activator.CreateInstance(listType)!;

        foreach (var item in jsonElement.EnumerateArray())
        {
            list.Add(DeserializeElement(item, itemType));
        }

        return list;
    }

    private static IDictionary DeserializeDictionary(JsonElement jsonElement, Type dictionaryType, Type valueType)
    {
        if (jsonElement.ValueKind != JsonValueKind.Object)
        {
            throw new JsonException($"Expected JSON object for {dictionaryType.Name}");
        }

        var dictionary = (IDictionary)Activator.CreateInstance(dictionaryType)!;

        foreach (var property in jsonElement.EnumerateObject())
        {
            var value = DeserializeElement(property.Value, valueType);

            dictionary.Add(property.Name, value);
        }

        return dictionary;
    }

    private static object? ConvertElement(JsonElement jsonElement)
    {
        return jsonElement.ValueKind switch
        {
            JsonValueKind.Object => jsonElement.EnumerateObject()
                .ToDictionary(p => p.Name, p => ConvertElement(p.Value)),
            JsonValueKind.Array => jsonElement.EnumerateArray()
                .Select(ConvertElement)
                .ToArray(),
            JsonValueKind.String => jsonElement.GetString(),
            JsonValueKind.Number => jsonElement.TryGetInt32(out var i) ? i
                : jsonElement.TryGetInt64(out var l) ? l
                : jsonElement.TryGetDecimal(out var d) ? d
                : jsonElement.GetDouble(),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.Null => null,
            JsonValueKind.Undefined => throw new JsonException(
                "Encountered undefined JSON element—likely a missing property or uninitialized JsonElement"),
            _ => throw new NotSupportedException($"Unsupported JSON kind: {jsonElement.ValueKind}")
        };
    }

    private static bool IsListType(Type type, out Type itemType)
    {
        var iListType = type.GetInterfaces()
            .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IList<>));

        if (iListType != null)
        {
            itemType = iListType.GetGenericArguments()[0];

            return true;
        }

        itemType = null!;

        return false;
    }

    private static bool IsDictionaryType(Type type, out Type valueType)
    {
        var iDictionaryType = type.GetInterfaces()
            .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDictionary<,>));

        if (iDictionaryType != null)
        {
            var args = iDictionaryType.GetGenericArguments();

            valueType = args[1];

            return true;
        }

        valueType = null!;

        return false;
    }
}