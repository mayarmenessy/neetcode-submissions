public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> sCount = new();
        Dictionary<char, int> tCount = new();

        for (int i = 0; i < s.Length; i++) {
            if (!sCount.ContainsKey(s[i]))
                sCount[s[i]] = 0;

            if (!tCount.ContainsKey(t[i]))
                tCount[t[i]] = 0;

            sCount[s[i]]++;
            tCount[t[i]]++;
        }

        foreach (char c in sCount.Keys) {
            if (!tCount.ContainsKey(c) || sCount[c] != tCount[c])
                return false;
        }

        return true;
    }
}