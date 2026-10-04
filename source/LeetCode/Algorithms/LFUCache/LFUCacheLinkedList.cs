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

namespace LeetCode.Algorithms.LFUCache;

/// <inheritdoc />
public sealed class LFUCacheLinkedList : LFUCacheBase
{
    private readonly Dictionary<int, NodeList<Node>> _frequencyToFrequencyListDictionary = [];
    private readonly Dictionary<int, Node> _keyToNodeDictionary = [];
    private int _minimumFrequency;

    /// <summary>
    ///     Initializes a new cache with the given <paramref name="capacity" />.
    /// </summary>
    /// <param name="capacity">The maximum number of entries the cache can hold before evicting.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public LFUCacheLinkedList(int capacity) : base(capacity)
    {
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected override bool TryGetAndCountUse(int key, out int value)
    {
        var node = _keyToNodeDictionary.GetValueOrDefault(key);

        if (node is null)
        {
            value = 0;

            return false;
        }

        IncrementFrequency(node);

        value = node.Value;

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected override bool TryUpdateAndCountUse(int key, int value)
    {
        var node = _keyToNodeDictionary.GetValueOrDefault(key);

        if (node is null)
        {
            return false;
        }

        node.Value = value;

        IncrementFrequency(node);

        return true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected override void Add(int key, int value)
    {
        if (_keyToNodeDictionary.Count == Capacity)
        {
            EvictLeastFrequentlyUsed();
        }

        var node = new Node(key, value);

        _keyToNodeDictionary[key] = node;
        _minimumFrequency = node.Frequency;

        AddToFrequencyList(node);
    }

    /// <summary>
    ///     Moves <paramref name="node" /> from its current frequency list to the list for the next frequency,
    ///     making it the most recently used node there.
    /// </summary>
    /// <param name="node">The node that has just been used.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void IncrementFrequency(Node node)
    {
        var frequencyList = _frequencyToFrequencyListDictionary[node.Frequency];

        frequencyList.Remove(node);

        if (frequencyList.IsEmpty)
        {
            _frequencyToFrequencyListDictionary.Remove(node.Frequency);

            if (_minimumFrequency == node.Frequency)
            {
                _minimumFrequency++;
            }
        }

        node.Frequency++;

        AddToFrequencyList(node);
    }

    /// <summary>
    ///     Adds <paramref name="node" /> as the most recently used node of the list for its frequency, creating the
    ///     list if it does not exist yet.
    /// </summary>
    /// <param name="node">The node to add.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void AddToFrequencyList(Node node)
    {
        if (!_frequencyToFrequencyListDictionary.TryGetValue(node.Frequency, out var frequencyList))
        {
            frequencyList = new NodeList<Node>();

            _frequencyToFrequencyListDictionary[node.Frequency] = frequencyList;
        }

        frequencyList.AddFirst(node);
    }

    /// <summary>
    ///     Removes the least recently used node among those with the minimum frequency.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void EvictLeastFrequentlyUsed()
    {
        var frequencyList = _frequencyToFrequencyListDictionary[_minimumFrequency];

        var node = frequencyList.RemoveLast();

        if (frequencyList.IsEmpty)
        {
            _frequencyToFrequencyListDictionary.Remove(_minimumFrequency);
        }

        _keyToNodeDictionary.Remove(node.Key);
    }

    /// <summary>
    ///     A cache entry together with its use counter.
    /// </summary>
    private sealed class Node : NodeBase<Node>
    {
        public Node(int key, int value) : base(key, value)
        {
            Frequency = 1;
        }

        public int Frequency { get; set; }
    }
}