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
    public const string EmptyArray = "[]";

    public static IList<T?> JsonArrayToList(string jsonArray)
    {
        if (jsonArray == EmptyArray)
        {
            return [];
        }

        return JsonConvert.DeserializeObject<List<T?>>(jsonArray) ?? throw new InvalidOperationException();
    }

    public static T[][] JsonArrayToJaggedArray(string jsonArray)
    {
        if (jsonArray == EmptyArray)
        {
            return [];
        }

        return JsonConvert.DeserializeObject<T[][]>(jsonArray) ?? throw new InvalidOperationException();
    }

    public static IList<IList<T>> JsonArrayToJaggedList(string jsonArray)
    {
        if (jsonArray == EmptyArray)
        {
            return [];
        }

        return JsonConvert.DeserializeObject<IList<IList<T>>>(jsonArray) ?? throw new InvalidOperationException();
    }
}