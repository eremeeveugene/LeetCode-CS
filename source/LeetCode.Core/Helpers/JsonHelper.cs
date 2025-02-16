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

public static class JsonHelper<T>
{
    public static T[] DeserializeToArray(string jsonArray)
    {
        return JsonSerializer.Deserialize<T[]>(jsonArray, JsonHelperOptions.Options) ??
               throw new JsonException("Failed to deserialize array.");
    }

    public static T[][] DeserializeToJaggedArray(string jsonArray)
    {
        return JsonSerializer.Deserialize<T[][]>(jsonArray, JsonHelperOptions.Options) ??
               throw new JsonException("Failed to deserialize jagged array.");
    }

    public static IList<IList<T>> DeserializeToJaggedList(string jsonArray)
    {
        return JsonSerializer.Deserialize<IList<IList<T>>>(jsonArray, JsonHelperOptions.Options) ??
               throw new JsonException("Failed to deserialize jagged list.");
    }
}