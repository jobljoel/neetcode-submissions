public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            char[] current = strs[i].ToCharArray();
            Array.Sort(current);
            string sorted = new string(current);
            if (!groups.ContainsKey(sorted)) {
                groups[sorted] = new List<string>();
            }

            groups[sorted].Add(strs[i]);
        }
        return groups.Values.Select(w => w.ToList()).ToList();

    }
}
