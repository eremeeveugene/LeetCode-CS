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

namespace LeetCode.Algorithms.LRUCache;

/// <inheritdoc />
public sealed class LRUCacheLinkedList : ILRUCache
{
    private const int MaxKey = 10_000;
    private readonly int _capacity;
    private readonly ushort[] _keyToSlotIndex = new ushort[MaxKey + 1];
    private readonly Node[] _nodes;
    private int _count;

    /// <summary>
    ///     Initializes a new cache with the given <paramref name="capacity" />, pre-allocating a fixed pool of
    ///     <paramref name="capacity" /> nodes plus one sentinel for the recency list, and a key-to-slot index
    ///     covering the problem's full key range (0-10000).
    /// </summary>
    /// <param name="capacity">The maximum number of entries the cache can hold before evicting.</param>
    /// <remarks>
    ///     Time complexity - O(n), where n is capacity
    ///     Space complexity - O(n), where n is capacity
    /// </remarks>
    public LRUCacheLinkedList(int capacity)
    {
        _capacity = capacity;
        _nodes = new Node[capacity + 1];
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Get(int key)
    {
        var slot = _keyToSlotIndex[key];

        if (slot == 0)
        {
            return -1;
        }

        MoveToFront(slot);

        return _nodes[slot].Value;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Put(int key, int value)
    {
        var slot = _keyToSlotIndex[key];

        if (slot == 0)
        {
            Add(key, value);
        }
        else
        {
            Update(slot, value);
        }
    }

    /// <summary>
    ///     Updates the value stored at <paramref name="slot" /> and marks it as the most recently used.
    /// </summary>
    /// <param name="slot">The slot of the existing node to update.</param>
    /// <param name="value">The new value to store.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void Update(ushort slot, int value)
    {
        _nodes[slot].Value = value;

        MoveToFront(slot);
    }

    /// <summary>
    ///     Inserts a new node for <paramref name="key" /> and <paramref name="value" />, evicting the least
    ///     recently used entry first if the cache is already at capacity.
    /// </summary>
    /// <param name="key">The key to insert.</param>
    /// <param name="value">The value to associate with <paramref name="key" />.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void Add(int key, int value)
    {
        ushort slot;

        if (_count == _capacity)
        {
            slot = _nodes[0].PreviousSlot;

            _keyToSlotIndex[_nodes[slot].Key] = 0;

            Unlink(slot);
        }
        else
        {
            _count++;

            slot = (ushort)_count;
        }

        ref var node = ref _nodes[slot];

        node.Key = key;
        node.Value = value;

        _keyToSlotIndex[key] = slot;

        InsertAfterSentinel(slot);
    }

    /// <summary>
    ///     Moves the node at <paramref name="slot" /> to the front of the recency list, marking it as the most
    ///     recently used.
    /// </summary>
    /// <param name="slot">The slot of the node to move.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void MoveToFront(ushort slot)
    {
        Unlink(slot);

        InsertAfterSentinel(slot);
    }

    /// <summary>
    ///     Inserts the node at <paramref name="slot" /> immediately after the sentinel (slot <c>0</c>), making it
    ///     the most recently used node in the recency list.
    /// </summary>
    /// <param name="slot">The slot of the node to insert.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void InsertAfterSentinel(ushort slot)
    {
        ref var sentinel = ref _nodes[0];
        ref var node = ref _nodes[slot];

        var oldHeadSlot = sentinel.NextSlot;

        node.PreviousSlot = 0;
        node.NextSlot = oldHeadSlot;

        _nodes[oldHeadSlot].PreviousSlot = slot;
        sentinel.NextSlot = slot;
    }

    /// <summary>
    ///     Unlinks the node at <paramref name="slot" /> from the recency list without modifying the node itself.
    /// </summary>
    /// <param name="slot">The slot of the node to remove.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void Unlink(ushort slot)
    {
        ref var node = ref _nodes[slot];

        var previousSlot = node.PreviousSlot;
        var nextSlot = node.NextSlot;

        _nodes[previousSlot].NextSlot = nextSlot;
        _nodes[nextSlot].PreviousSlot = previousSlot;
    }

    /// <summary>
    ///     A slot in the pre-allocated node pool: either a cache entry, or (at index <c>0</c>) the sentinel linking
    ///     the most and least recently used ends of the recency list.
    /// </summary>
    private struct Node
    {
        /// <summary>
        ///     The cache key held by this slot.
        /// </summary>
        public int Key;

        /// <summary>
        ///     The value currently associated with <see cref="Key" />.
        /// </summary>
        public int Value;

        /// <summary>
        ///     The slot closer to the sentinel from the front, i.e. more recently used.
        /// </summary>
        public ushort PreviousSlot;

        /// <summary>
        ///     The slot closer to the sentinel from the back, i.e. less recently used.
        /// </summary>
        public ushort NextSlot;
    }
}