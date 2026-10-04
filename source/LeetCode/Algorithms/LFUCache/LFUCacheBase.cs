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

/// <summary>
///     The shared flow of the LFU cache implementations: a key that is present is read or updated and counted as
///     used, and a key that is absent is added. How use counters are tracked is left to the derived class.
/// </summary>
public abstract class LFUCacheBase : ILFUCache
{
    /// <summary>
    ///     Initializes a new cache with the given <paramref name="capacity" />.
    /// </summary>
    /// <param name="capacity">The maximum number of entries the cache can hold before evicting.</param>
    protected LFUCacheBase(int capacity)
    {
        Capacity = capacity;
    }

    /// <summary>
    ///     Gets the maximum number of entries the cache can hold before evicting.
    /// </summary>
    protected int Capacity { get; }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Get(int key)
    {
        return TryGetAndCountUse(key, out var value) ? value : -1;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Put(int key, int value)
    {
        if (!TryUpdateAndCountUse(key, value))
        {
            Add(key, value);
        }
    }

    /// <summary>
    ///     Reads the value of <paramref name="key" /> and counts one more use of it, if the key is present.
    /// </summary>
    /// <param name="key">The key to look up.</param>
    /// <param name="value">The value associated with <paramref name="key" />, if present.</param>
    /// <returns><c>true</c> if <paramref name="key" /> is present; otherwise, <c>false</c>.</returns>
    protected abstract bool TryGetAndCountUse(int key, out int value);

    /// <summary>
    ///     Replaces the value of <paramref name="key" /> and counts one more use of it, if the key is present.
    /// </summary>
    /// <param name="key">The key to update.</param>
    /// <param name="value">The new value to associate with <paramref name="key" />.</param>
    /// <returns><c>true</c> if <paramref name="key" /> is present; otherwise, <c>false</c>.</returns>
    protected abstract bool TryUpdateAndCountUse(int key, int value);

    /// <summary>
    ///     Inserts a new entry with a use counter of one, first evicting the least frequently used entry, breaking
    ///     ties by the least recently used, if the cache is already at capacity.
    /// </summary>
    /// <param name="key">The key to insert, which is not present yet.</param>
    /// <param name="value">The value to associate with <paramref name="key" />.</param>
    protected abstract void Add(int key, int value);

    /// <summary>
    ///     A cache entry that can be linked into a <see cref="NodeList{TNode}" />.
    /// </summary>
    /// <typeparam name="TNode">The concrete node type, used to type the links between nodes.</typeparam>
    protected abstract class NodeBase<TNode> where TNode : NodeBase<TNode>
    {
        protected NodeBase(int key, int value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        ///     The cache key held by this node.
        /// </summary>
        public int Key { get; set; }

        /// <summary>
        ///     The value currently associated with <see cref="Key" />.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        ///     The neighbouring node closer to the head of the list, i.e. more recently used.
        /// </summary>
        public TNode? PreviousNode { get; set; }

        /// <summary>
        ///     The neighbouring node closer to the tail of the list, i.e. less recently used.
        /// </summary>
        public TNode? NextNode { get; set; }
    }

    /// <summary>
    ///     A doubly linked list of nodes ordered from the most recently used head to the least recently used tail.
    /// </summary>
    /// <typeparam name="TNode">The concrete node type held by the list.</typeparam>
    protected class NodeList<TNode> where TNode : NodeBase<TNode>
    {
        private TNode? _head;
        private TNode? _tail;

        /// <summary>
        ///     Gets a value indicating whether the list holds no nodes.
        /// </summary>
        public bool IsEmpty => _head is null;

        /// <summary>
        ///     Adds <paramref name="node" /> at the head of the list, making it the most recently used node.
        /// </summary>
        /// <param name="node">The node to add.</param>
        public void AddFirst(TNode node)
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

        /// <summary>
        ///     Unlinks <paramref name="node" />, which must belong to this list, from its neighbours.
        /// </summary>
        /// <param name="node">The node to remove.</param>
        public void Remove(TNode node)
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

        /// <summary>
        ///     Removes the least recently used node, which must exist.
        /// </summary>
        /// <returns>The removed node.</returns>
        public TNode RemoveLast()
        {
            var lastNode = _tail!;

            Remove(lastNode);

            return lastNode;
        }
    }
}