public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> s1 = CountChars(s);
        Dictionary <char, int>t1 = CountChars(t);

        if (s.Length != t.Length)
            return false;

        foreach(var kvPair in s1){
            if (!t1.ContainsKey(kvPair.Key))   
                return false;

            if (s1[kvPair.Key] != t1[kvPair.Key])    
                return false;
        }

        return true;
    }


    private static Dictionary<char, int> CountChars(string s)
    {
        var map = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!map.ContainsKey(c))
                map[c] = 0;
            map[c]++;
        }
        return map;
    }
}
