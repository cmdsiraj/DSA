public int[] TopKFrequent(int[] nums, int k)
{
    var freq = new Dictionary<int, int>();
    
    foreach(var num in nums)
    {
        if (!freq.ContainsKey(num)) freq[num] = 0;
        freq[num]++;
    }

    var bucket = new List<int>[freq.Count+1]; // give in the question that k lies between 1 and number of unique number in nums.
    foreach(var kvp in freq)
    {
        if (bucket[kvp.Value - 1] == null) bucket[kvp.Value - 1] = new List<int>();
        bucket[kvp.Value-1].Add(kvp.Key);
    }

    var ans = new List<int>();
    for (int i = bucket.Length - 1; i >= 0; i--)
    {
        if (bucket[i]!=null)
        {
            int j = 0;
            while(ans.Count<=k && j < bucket[i].Count)
            {
                ans.Add(bucket[i][j]);
                j++;
            }
        }
        if (ans.Count == k) break;
    }

    return ans.ToArray();
}
