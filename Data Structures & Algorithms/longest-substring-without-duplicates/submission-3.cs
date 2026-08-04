public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charPos = new();

        int left=0;
        int maxLength = 0;
        for (int right=0; right < s.Length; right++){
            if(charPos.ContainsKey(s[right])){
                left = Math.Max(left, charPos[s[right]] + 1);
                charPos[s[right]] = right;
            } else {
                charPos.Add(s[right], right);
            }


            maxLength = Math.Max(maxLength, right-left+1);
       
        }
        return maxLength;
    }
}
