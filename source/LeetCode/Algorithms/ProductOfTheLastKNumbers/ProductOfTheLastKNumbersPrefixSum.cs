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

namespace LeetCode.Algorithms.ProductOfTheLastKNumbers;

/// <inheritdoc />
public class ProductOfTheLastKNumbersPrefixSum : IProductOfTheLastKNumbers
{
    private readonly List<int> _products = [];

    public void Add(int num)
    {
        if (num == 0)
        {
            _products.Clear();
        }
        else
        {
            if (_products.Count == 0)
            {
                _products.Add(num);
            }
            else
            {
                _products.Add(_products[^1] * num);
            }
        }
    }

    public int GetProduct(int k)
    {
        if (k > _products.Count)
        {
            return 0;
        }

        if (k == _products.Count)
        {
            return _products[^1];
        }

        return _products[^1] / _products[_products.Count - k - 1];
    }
}