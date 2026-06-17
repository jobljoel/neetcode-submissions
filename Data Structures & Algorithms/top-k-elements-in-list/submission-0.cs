public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!seen.ContainsKey(num)) {
                seen.Add(num, 1);
            } else {
                seen[num] = seen[num] + 1;
            }
        }
        var sorted = seen.OrderByDescending(key => key.Value);
        return sorted.Take(k).Select(w => w.Key).ToArray();
    }
}
