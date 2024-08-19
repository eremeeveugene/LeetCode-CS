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

using Newtonsoft.Json;

namespace LeetCode.Core.Helpers;

public static class JsonHelper<T>
{
    public static T[] DeserializeToArray(string jsonArray)
    {
        return JsonConvert.DeserializeObject<T[]>(jsonArray) ??
               throw new JsonException("Failed to deserialize array.");
    }

    public static IList<T> DeserializeToList(string jsonArray)
    {
        return JsonConvert.DeserializeObject<List<T>>(jsonArray) ??
               throw new JsonException("Failed to deserialize list.");
    }

    public static T[][] DeserializeToJaggedArray(string jsonArray)
    {
        return JsonConvert.DeserializeObject<T[][]>(jsonArray) ??
               throw new JsonException("Failed to deserialize jagged array.");
    }

    public static IList<IList<T>> DeserializeToJaggedList(string jsonArray)
    {
        return JsonConvert.DeserializeObject<IList<IList<T>>>(jsonArray) ??
               throw new JsonException("Failed to deserialize jagged list.");
    }
}