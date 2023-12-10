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
    public static List<T?> ToList(string inputArrayJson)
    {
        if (inputArrayJson == JsonHelper.EmptyArray)
        {
            return new List<T?> { default };
        }

        return JsonConvert.DeserializeObject<List<T?>>(inputArrayJson) ?? throw new InvalidOperationException();
    }
}