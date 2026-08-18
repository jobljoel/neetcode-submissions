public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            var sorted = word.ToCharArray();
            Array.Sort(sorted);
            var sortedString = new string(sorted);
            if (!groups.ContainsKey(sortedString)) {
                groups[sortedString] = new List<string>();
            }

            groups[sortedString].Add(word);
        }
        return new List<List<string>>(groups.Values);
    }
}
