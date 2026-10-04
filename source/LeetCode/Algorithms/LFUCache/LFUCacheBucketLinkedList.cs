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
public sealed class LFUCacheBucketLinkedList : ILFUCache
{
    private const int MaxKey = 100_000;
    private readonly int _capacity;
    private readonly Node?[] _keyToNode = new Node?[MaxKey + 1];
    private int _count;
    private Bucket? _firstBucket;
    private Bucket? _freeBucket;

    /// <summary>
    ///     Initializes a new cache with the given <paramref name="capacity" />, allocating a key-to-node index
    ///     covering the problem's full key range (0-100000).
    /// </summary>
    /// <param name="capacity">The maximum number of entries the cache can hold before evicting.</param>
    /// <remarks>
    ///     Time complexity - O(k), where k is the key range
    ///     Space complexity - O(k), where k is the key range
    /// </remarks>
    public LFUCacheBucketLinkedList(int capacity)
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
        var node = _keyToNode[key];

        if (node is null)
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
        var node = _keyToNode[key];

        if (node is not null)
        {
            node.Value = value;

            IncrementFrequency(node);

            return;
        }

        Add(key, value);
    }

    /// <summary>
    ///     Inserts a new node for <paramref name="key" /> and <paramref name="value" /> with a frequency of one,
    ///     first evicting the least frequently used node if the cache is already at capacity and reusing its
    ///     instance for the new entry.
    /// </summary>
    /// <param name="key">The key to insert.</param>
    /// <param name="value">The value to associate with <paramref name="key" />.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void Add(int key, int value)
    {
        Node? evictedNode = null;

        if (_count == _capacity)
        {
            evictedNode = EvictLeastFrequentlyUsed();
        }
        else
        {
            _count++;
        }

        var bucket = GetFirstBucketWithFrequencyOne();

        Node node;

        if (evictedNode is null)
        {
            node = new Node(key, value, bucket);
        }
        else
        {
            node = evictedNode;

            node.Key = key;
            node.Value = value;
            node.Bucket = bucket;
        }

        _keyToNode[key] = node;

        bucket.AddFirst(node);
    }

    /// <summary>
    ///     Moves <paramref name="node" /> from its current bucket to the bucket for the next frequency, making it
    ///     the most recently used node there and discarding its old bucket if that becomes empty.
    /// </summary>
    /// <param name="node">The node that has just been used.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void IncrementFrequency(Node node)
    {
        var bucket = node.Bucket;
        var nextFrequency = bucket.Frequency + 1;

        var nextBucket = bucket.NextBucket;

        if (nextBucket is null || nextBucket.Frequency != nextFrequency)
        {
            nextBucket = CreateBucket(nextFrequency);

            InsertBucketAfter(bucket, nextBucket);
        }

        bucket.Remove(node);

        node.Bucket = nextBucket;

        nextBucket.AddFirst(node);

        if (bucket.IsEmpty)
        {
            RemoveBucket(bucket);
        }
    }

    /// <summary>
    ///     Removes the least recently used node from the bucket with the lowest frequency.
    /// </summary>
    /// <returns>The removed node, whose instance can be reused.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private Node EvictLeastFrequentlyUsed()
    {
        var bucket = _firstBucket!;

        var node = bucket.RemoveLast();

        _keyToNode[node.Key] = null;

        if (bucket.IsEmpty)
        {
            RemoveBucket(bucket);
        }

        return node;
    }

    /// <summary>
    ///     Returns the bucket for frequency one, which is always the first bucket if it exists, creating it if
    ///     necessary.
    /// </summary>
    /// <returns>The bucket for frequency one.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private Bucket GetFirstBucketWithFrequencyOne()
    {
        if (_firstBucket is { Frequency: 1 })
        {
            return _firstBucket;
        }

        var bucket = CreateBucket(1);

        InsertBucketAfter(null, bucket);

        return bucket;
    }

    /// <summary>
    ///     Links <paramref name="bucket" /> into the bucket list immediately after <paramref name="previousBucket" />,
    ///     or at the front of the list if <paramref name="previousBucket" /> is <c>null</c>.
    /// </summary>
    /// <param name="previousBucket">The bucket to insert after, or <c>null</c> to insert at the front.</param>
    /// <param name="bucket">The bucket to insert.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void InsertBucketAfter(Bucket? previousBucket, Bucket bucket)
    {
        var nextBucket = previousBucket is null ? _firstBucket : previousBucket.NextBucket;

        bucket.PreviousBucket = previousBucket;
        bucket.NextBucket = nextBucket;

        if (previousBucket is null)
        {
            _firstBucket = bucket;
        }
        else
        {
            previousBucket.NextBucket = bucket;
        }

        nextBucket?.PreviousBucket = bucket;
    }

    /// <summary>
    ///     Unlinks the empty <paramref name="bucket" /> from the bucket list and keeps it for reuse.
    /// </summary>
    /// <param name="bucket">The empty bucket to remove.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private void RemoveBucket(Bucket bucket)
    {
        var previousBucket = bucket.PreviousBucket;
        var nextBucket = bucket.NextBucket;

        if (previousBucket is null)
        {
            _firstBucket = nextBucket;
        }
        else
        {
            previousBucket.NextBucket = nextBucket;
        }

        nextBucket?.PreviousBucket = previousBucket;

        bucket.PreviousBucket = null;
        bucket.NextBucket = _freeBucket;

        _freeBucket = bucket;
    }

    /// <summary>
    ///     Returns an empty, unlinked bucket for <paramref name="frequency" />, reusing a removed bucket if one is
    ///     available.
    /// </summary>
    /// <param name="frequency">The frequency of the bucket.</param>
    /// <returns>The empty bucket.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private Bucket CreateBucket(int frequency)
    {
        var bucket = _freeBucket;

        if (bucket is null)
        {
            return new Bucket(frequency);
        }

        _freeBucket = bucket.NextBucket;

        bucket.Frequency = frequency;

        return bucket;
    }

    /// <summary>
    ///     A cache entry together with the bucket of its use counter and its links within that bucket.
    /// </summary>
    private sealed class Node
    {
        public Node(int key, int value, Bucket bucket)
        {
            Key = key;
            Value = value;
            Bucket = bucket;
        }

        public int Key { get; set; }

        public int Value { get; set; }

        public Bucket Bucket { get; set; }

        public Node? PreviousNode { get; set; }

        public Node? NextNode { get; set; }
    }

    /// <summary>
    ///     A doubly linked list of nodes sharing the same frequency, ordered from the most recently used head to the
    ///     least recently used tail, which is itself linked into a list of buckets ordered by frequency.
    /// </summary>
    private sealed class Bucket
    {
        private Node? _head;
        private Node? _tail;

        public Bucket(int frequency)
        {
            Frequency = frequency;
        }

        public int Frequency { get; set; }

        public Bucket? PreviousBucket { get; set; }

        public Bucket? NextBucket { get; set; }

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