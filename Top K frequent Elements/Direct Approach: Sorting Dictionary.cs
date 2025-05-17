public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach(int num in nums)
    {
      if(freq.ContainsKey(num)) freq[num]++;
      else freq[num]=1;
    }
    return freq.OrderByDescending(kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToArray();
}
