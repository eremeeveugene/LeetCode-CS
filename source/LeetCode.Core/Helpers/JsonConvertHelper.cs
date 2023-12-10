// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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

public static class JsonConvertHelper<T>
{
    public static List<T?> JsonArrayToList(string jsonArray)
    {
        if (jsonArray == JsonHelper.EmptyArray)
        {
            return new List<T?>();
        }

        return JsonConvert.DeserializeObject<List<T?>>(jsonArray) ?? throw new InvalidOperationException();
    }
}