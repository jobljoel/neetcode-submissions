public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in nums) {
            if (!numSet.Contains(num - 1)) {
                int currentNumber = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNumber + 1)) {
                    currentNumber += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
}
