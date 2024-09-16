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

using System.Text;

namespace LeetCode.Algorithms.ApplyDiscountToPrices;

/// <inheritdoc />
public class ApplyDiscountToPricesIterative : IApplyDiscountToPrices
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="sentence"></param>
    /// <param name="discount"></param>
    /// <returns></returns>
    public string DiscountPrices(string sentence, int discount)
    {
        var resultStringBuilder = new StringBuilder(sentence.Length);

        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith('$') && words[i].Length > 1 && double.TryParse(words[i].AsSpan(1), out var number))
            {
                var pricePart = words[i].AsSpan(1);

                if (pricePart.Length > 1 && pricePart[1] == 'e')
                {
                    resultStringBuilder.Append(words[i]);
                }
                else
                {
                    var discountedPrice = number - (number * discount / 100);

                    resultStringBuilder.Append($"${discountedPrice:F2}");
                }
            }
            else
            {
                resultStringBuilder.Append(words[i]);
            }

            if (i < words.Length - 1)
            {
                resultStringBuilder.Append(' ');
            }
        }

        return resultStringBuilder.ToString();
    }
}