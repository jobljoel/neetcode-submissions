public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> output = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            int runningTotal = 1;
            for (int j = 0; j < nums.Length; j++) {
                if (j != i) {
                    runningTotal = runningTotal * nums[j];
                }
            }
            output.Add(runningTotal);
        }
        return output.ToArray();        
    }
}
