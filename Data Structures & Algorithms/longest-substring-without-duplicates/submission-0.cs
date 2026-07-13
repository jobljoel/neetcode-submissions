public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int left = 0;
        HashSet<char> seen = new HashSet<char>();
        for (int right = 0; right < s.Length; right++) {
            while (seen.Contains(s[right])) {
                seen.Remove(s[left]);
                left++;
            }
            seen.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
