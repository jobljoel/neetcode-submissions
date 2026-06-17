public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (seen.Contains(complement)) {
                int firstIndex = Array.IndexOf(nums, complement);
                return [firstIndex, i];
            }
            
            seen.Add(nums[i]);
        }
        return [0, 0];
    }
}
