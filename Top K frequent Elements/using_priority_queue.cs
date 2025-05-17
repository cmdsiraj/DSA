public int[] TopKFrequent(int[] nums, int k)
{
    var pq = new PriorityQueue<int,int>();
    var freq = new Dictionary<int,int>();
    foreach(int num in nums)
    {
        if(!freq.ContainsKey(num)) freq[num]=0;
        freq[num]++;
    }
    foreach(KeyValuePair<int,int> pair in freq)
    {
        if(pq.Count<k)
        {
            pq.Enqueue(pair.Key, pair.Value);
        }else if (pair.Value > freq[pq.Peek()])
        {
            pq.Dequeue();
            pq.Enqueue(pair.Key, pair.Value);
        }
    }
    var ans = new List<int>();
    while (pq.Count > 0)
    {
        ans.Add(pq.Dequeue());
    }
    return ans.ToArray();
}


// Time & Space Complexity:

// Time:
// O(n) to count frequencies
// O(d log k) for heap operations where d = unique elements
// So overall: O(n + d log k)

// Space:
// Frequency map: O(n) in worst case
// Heap: O(k)
// So overall: O(n)
