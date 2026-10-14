public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!hash.ContainsKey(num))
                hash.Add(num, 0);
            hash[num]++;
        }
        int[] result = hash.OrderByDescending(x=>x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
        return result;
    }
}
