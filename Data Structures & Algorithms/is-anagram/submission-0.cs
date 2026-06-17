public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        char[] word1 = s.ToCharArray();
        char[] word2 = t.ToCharArray();
        Array.Sort(word1);
        Array.Sort(word2);

        return new string(word1) == new string(word2);
    }
}
