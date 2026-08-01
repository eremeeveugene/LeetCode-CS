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

namespace LeetCode.Algorithms.AllOneDataStructure;

/// <inheritdoc />
public sealed class AllOneDataStructureLinkedList : IAllOneDataStructure
{
    private readonly Node _headNode = new(int.MinValue);
    private readonly Dictionary<string, Node> _keyNodeDictionary = new();
    private readonly Node _tailNode = new(int.MaxValue);

    public AllOneDataStructureLinkedList()
    {
        _headNode.NextNode = _tailNode;
        _tailNode.PreviousNode = _headNode;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public void Inc(string key)
    {
        if (_keyNodeDictionary.TryGetValue(key, out var currentNode))
        {
            var nextNode = currentNode.NextNode;

            if (nextNode.Count != currentNode.Count + 1)
            {
                var newNode = new Node(currentNode.Count + 1);

                InsertNodeAfter(currentNode, newNode);

                nextNode = newNode;
            }

            MoveKey(key, currentNode, nextNode);
        }
        else
        {
            if (_headNode.NextNode.Count != 1)
            {
                var newNode = new Node(1);

                InsertNodeAfter(_headNode, newNode);
            }

            _headNode.NextNode.KeysHashSet.Add(key);
            _keyNodeDictionary[key] = _headNode.NextNode;
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public void Dec(string key)
    {
        if (!_keyNodeDictionary.TryGetValue(key, out var currentNode))
        {
            return;
        }

        if (currentNode.Count == 1)
        {
            _keyNodeDictionary.Remove(key);

            currentNode.KeysHashSet.Remove(key);

            if (currentNode.KeysHashSet.Count == 0)
            {
                RemoveNode(currentNode);
            }
        }
        else
        {
            var prevNode = currentNode.PreviousNode;

            if (prevNode.Count != currentNode.Count - 1)
            {
                var newNode = new Node(currentNode.Count - 1);

                InsertNodeAfter(prevNode, newNode);

                prevNode = newNode;
            }

            MoveKey(key, currentNode, prevNode);
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public string GetMaxKey()
    {
        if (_tailNode.PreviousNode == _headNode)
        {
            return string.Empty;
        }

        return _tailNode.PreviousNode.KeysHashSet.First();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </remarks>
    public string GetMinKey()
    {
        if (_headNode.NextNode == _tailNode)
        {
            return string.Empty;
        }

        return _headNode.NextNode.KeysHashSet.First();
    }

    private void MoveKey(string key, Node fromNode, Node toNode)
    {
        fromNode.KeysHashSet.Remove(key);

        if (fromNode.KeysHashSet.Count == 0)
        {
            RemoveNode(fromNode);
        }

        toNode.KeysHashSet.Add(key);

        _keyNodeDictionary[key] = toNode;
    }

    private static void InsertNodeAfter(Node prevNode, Node newNode)
    {
        newNode.PreviousNode = prevNode;
        newNode.NextNode = prevNode.NextNode;

        prevNode.NextNode.PreviousNode = newNode;
        prevNode.NextNode = newNode;
    }

    private static void RemoveNode(Node node)
    {
        node.PreviousNode.NextNode = node.NextNode;
        node.NextNode.PreviousNode = node.PreviousNode;
    }

    private class Node
    {
        public Node(int count)
        {
            Count = count;
            PreviousNode = this;
            NextNode = this;
        }

        public int Count { get; }

        public HashSet<string> KeysHashSet { get; } = [];

        public Node PreviousNode { get; set; }

        public Node NextNode { get; set; }
    }
}