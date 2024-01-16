using System;
using System.Collections.Generic;
using System.Linq;

public class LFUCache
{
    private readonly int capacity;
    private int minFrequency;
    private readonly Dictionary<int, CacheNode> cache;
    private readonly Dictionary<int, LinkedList<CacheNode>> frequencyMap;

    public LFUCache(int capacity)
    {
        this.capacity = capacity;
        this.minFrequency = 0;
        this.cache = new Dictionary<int, CacheNode>();
        this.frequencyMap = new Dictionary<int, LinkedList<CacheNode>>();
    }

    public int Get(int key)
    {
        if (cache.TryGetValue(key, out var node))
        {
            UpdateFrequency(node);
            return node.Value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (capacity == 0)
            return;

        if (cache.Count >= capacity)
            Evict();

        if (!cache.ContainsKey(key))
        {
            var newNode = new CacheNode(key, value);
            cache[key] = newNode;
            minFrequency = 1;

            if (!frequencyMap.ContainsKey(1))
                frequencyMap[1] = new LinkedList<CacheNode>();

            frequencyMap[1].AddLast(newNode);
        }
        else
        {
            var existingNode = cache[key];
            existingNode.Value = value;
            UpdateFrequency(existingNode);
        }
    }

    private void UpdateFrequency(CacheNode node)
    {
        int frequency = node.Frequency;
        frequencyMap[frequency].Remove(node);

        if (frequencyMap[frequency].Count == 0)
        {
            frequencyMap.Remove(frequency);

            if (minFrequency == frequency)
                minFrequency++;
        }

        node.Frequency++;
        if (!frequencyMap.ContainsKey(node.Frequency))
            frequencyMap[node.Frequency] = new LinkedList<CacheNode>();

        frequencyMap[node.Frequency].AddLast(node);
    }

    private void Evict()
    {
        var minFrequencyList = frequencyMap[minFrequency];
        var nodeToRemove = minFrequencyList.First.Value;

        minFrequencyList.RemoveFirst();
        cache.Remove(nodeToRemove.Key);

        if (minFrequencyList.Count == 0)
            frequencyMap.Remove(minFrequency);
    }

    private class CacheNode
    {
        public int Key { get; }
        public int Value { get; set; }
        public int Frequency { get; set; }

        public CacheNode(int key, int value)
        {
            Key = key;
            Value = value;
            Frequency = 1;
        }
    }
}
