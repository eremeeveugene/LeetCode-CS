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
public sealed class LFUCacheLinkedList : ILFUCache
{
    private readonly int _capacity;
    private readonly Dictionary<int, FrequencyList> _frequencyToFrequencyListDictionary = [];
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
    public LFUCacheLinkedList(int capacity)
    {
        _capacity = capacity;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Get(int key)
    {
        if (!_keyToNodeDictionary.TryGetValue(key, out var node))
        {
            return -1;
        }

        IncrementFrequency(node);

        return node.Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Put(int key, int value)
    {
        if (_keyToNodeDictionary.TryGetValue(key, out var node))
        {
            node.Value = value;

            IncrementFrequency(node);

            return;
        }

        if (_keyToNodeDictionary.Count == _capacity)
        {
            EvictLeastFrequentlyUsed();
        }

        var newNode = new Node(key, value);

        _keyToNodeDictionary[key] = newNode;
        _minimumFrequency = newNode.Frequency;

        AddToFrequencyList(newNode);
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
            frequencyList = new FrequencyList();

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
    ///     A cache entry together with its use counter and its links within the frequency list.
    /// </summary>
    private sealed class Node
    {
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Frequency = 1;
        }

        public int Key { get; }

        public int Value { get; set; }

        public int Frequency { get; set; }

        public Node? PreviousNode { get; set; }

        public Node? NextNode { get; set; }
    }

    /// <summary>
    ///     A doubly linked list of nodes sharing the same frequency, ordered from the most recently used head to the
    ///     least recently used tail.
    /// </summary>
    private sealed class FrequencyList
    {
        private Node? _head;
        private Node? _tail;

        public bool IsEmpty => _head is null;

        public void AddFirst(Node node)
        {
            node.PreviousNode = null;
            node.NextNode = _head;

            if (_head is null)
            {
                _tail = node;
            }
            else
            {
                _head.PreviousNode = node;
            }

            _head = node;
        }

        public void Remove(Node node)
        {
            var previousNode = node.PreviousNode;
            var nextNode = node.NextNode;

            if (previousNode is null)
            {
                _head = nextNode;
            }
            else
            {
                previousNode.NextNode = nextNode;
            }

            if (nextNode is null)
            {
                _tail = previousNode;
            }
            else
            {
                nextNode.PreviousNode = previousNode;
            }
        }

        public Node RemoveLast()
        {
            var lastNode = _tail!;

            Remove(lastNode);

            return lastNode;
        }
    }
}