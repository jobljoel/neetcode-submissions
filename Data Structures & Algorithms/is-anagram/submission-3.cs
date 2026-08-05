public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] s1 = new int[26];
        int[] t1 = new int[26];

        for (int i = 0; i < s.Length; i++) {
            s1[s[i] - 'a']++;
            t1[t[i] - 'a']++;
        }

        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] != t1[i]) return false;
        }
        return true;
    }
}
