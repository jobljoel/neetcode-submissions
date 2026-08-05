public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            if (seen.ContainsKey(complement)) {
                return [seen[complement], i];
            } else {
                seen.Add(nums[i], i);
            }
        }
        return [0, 1];
    }
}
